using System;
using System.Xml.Serialization;

namespace LogoRemoteControl
{
    class Component
    {
        [XmlAttribute]
        public int _BYTE;
        [XmlAttribute]
        public _BitNumber _Bit;
    }
}
