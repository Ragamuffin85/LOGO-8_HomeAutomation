﻿/*
 Very simple program to read from a 300/400 PLC via MPI adapter.
 This shall provide users with a simple starting point for their own
 applications.
 
 Part of Libnodave, a free communication libray for Siemens S7 200/300/400
  
 (C) Thomas Hergenhahn (thomas.hergenhahn@web.de) 2005

 Libnodave is free software; you can redistribute it and/or modify
 it under the terms of the GNU Library General Public License as published by
 the Free Software Foundation; either version 2, or (at your option)
 any later version.

 Libnodave is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU Library General Public License
 along with Libnodave; see the file COPYING.  If not, write to
 the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.  
*/

using System;
using System.Linq;

class test
{
    static libnodave.daveOSserialType fds;
    static libnodave.daveInterface daveI;
    static libnodave.daveConnection dc;
    static int RACK = 0;
    static int SLOT = 1;

    public static int Main(string[] args)
    {
        int a , b , c , res;
        float d = 0;

        a = b = c = res = 0;

        //libnodave.daveSetDebug(libnodave.daveDebugAll);

        fds.rfd = libnodave.openSocket(102, args[0]);
        fds.wfd = fds.rfd;

        if (fds.rfd > 0)
        {
            daveI = new libnodave.daveInterface(fds, "IF1", 0, libnodave.daveProtoISOTCP, libnodave.daveSpeed187k);
            daveI.setTimeout(1000000);
            //res=daveI.initAdapter();	// does nothing in ISO_TCP. But call it to keep your programs indpendent of protocols

            //if(res==0) {
                dc = new libnodave.daveConnection(daveI, 0, RACK, SLOT);
            
                int connPLC = dc.connectPLC();
                if (0 == connPLC)
                {
                    int byteAdress = 0;
                    int bitNumber = 0;

                    dc.writeBits(libnodave.daveDB, 1, (byteAdress * 8) + bitNumber, 1, BitConverter.GetBytes(true));
                    System.Threading.Thread.Sleep(1000);
                    dc.writeBits(libnodave.daveDB, 1, (byteAdress * 8) + bitNumber, 1, BitConverter.GetBytes(false));

                    //dc.writeBytes(libnodave.daveFlags, 0, 0, buff.Length, buff);
                    
                    res = dc.readBytes(libnodave.daveDB, 0, 0, 100, null);

                    if (res == 0)
                    {
                        for (int x = 0; x < 100; x++)
                            Console.WriteLine(dc.getS32());
                        /*
                        a = dc.getS32();
                        b = dc.getS32();
                        c = dc.getS32();
                        d = dc.getFloat();
                        Console.WriteLine("FD0: " + a);
                        Console.WriteLine("FD4: " + b);
                        Console.WriteLine("FD8: " + c);
                        Console.WriteLine("FD12: " + d);*/
                    }
                    else
                        Console.WriteLine("error " + res + " " + libnodave.daveStrerror(res));
                     
                }
                else
                {
                    Console.WriteLine("PLC connect failed.");
                    Console.WriteLine("Ensure that PORT 102 is not blocked by other services.");
                }
                dc.disconnectPLC();
            //}	    
            daveI.disconnectAdapter();	// does nothing in ISO_TCP. But call it to keep your programs indpendent of protocols
            libnodave.closeSocket(fds.rfd);
        }
        else
        {
            Console.WriteLine("Couldn't open TCP connaction to " + args[0]);
            return -1;
        }
        Console.ReadKey();
        return 0;
    }
}

/*
Version 0.8.4.5    
07/10/09  	Added closeSocket()
*/

