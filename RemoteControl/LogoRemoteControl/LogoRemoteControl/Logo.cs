using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogoRemoteControl
{
    class Logo
    {
        private static int __RACK = 0;
        private static int __SLOT = 1;
        private static Dictionary<string, Logo> __LogoInstance = null;

        private libnodave.daveOSserialType _fds;
        private libnodave.daveInterface _daveI = null;
        private libnodave.daveConnection _dc = null;

        private Logo()
        {
        }

        private Logo(string IP)
        {
            int connPLC = 0;
            int res = -1;

            _fds.rfd = libnodave.openSocket(102, IP);
            _fds.wfd = _fds.rfd;

            if (_fds.rfd > 0)
            {
                //ToDo: Logging => Conn established

                _daveI = new libnodave.daveInterface(_fds, "IF1", 0, libnodave.daveProtoISOTCP, libnodave.daveSpeed187k);
                _daveI.setTimeout(1000000);
                res = _daveI.initAdapter();	// does nothing in ISO_TCP. But call it to keep your programs indpendent of protocols

                // ToDo: Looging => libnodave.daveStrerror(res);

                if (res == 0)
                {
                    _dc = new libnodave.daveConnection(_daveI, 0, __RACK, __SLOT);

                    connPLC = _dc.connectPLC();
                    if (0 == connPLC)
                    {
                        // ToDo: Logging => Connection successfull
                    }
                }
            }
            else
            {
                // ToDo: Logging => Connection failed
            }
        }

        ~Logo()
        {
            _dc.disconnectPLC();
            _daveI.disconnectAdapter();	// does nothing in ISO_TCP. But call it to keep your programs indpendent of protocols
            libnodave.closeSocket(_fds.rfd);
        }

        public bool WriteBit(int byteAdress, int bitNumber, bool bitState)
        {
            int res = -1;
            res = _dc.writeBits(libnodave.daveDB, 1, (byteAdress * 8) + bitNumber, 1, BitConverter.GetBytes(bitState));

            if ( res == 0)
            {
                return true;
            }

            return false;
        }

        public bool ReadBit(int byteAdress, int bitNumber, bool bitState)
        {
            int res = -1;
            res = _dc.readBits(libnodave.daveDB, 1, (byteAdress * 8) + bitNumber, 1, BitConverter.GetBytes(bitState));

            if (res == 0)
            {
                return true;
            }

            return false;
        }

        public static Logo Instance(string IP)
        {
            if (__LogoInstance == null)
            {
                __LogoInstance = new Dictionary<string, Logo>();
            }

            if (!(__LogoInstance.ContainsKey(IP)))
            {
                __LogoInstance.Add(IP, new Logo(IP));
            }
            return __LogoInstance[IP];
        }
    }
}
