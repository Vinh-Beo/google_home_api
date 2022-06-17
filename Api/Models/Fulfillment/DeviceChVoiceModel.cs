using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class DeviceChVoiceModel
    {
        private string _code;
        public string Code { get => _code; set { _code = value;} }
        private string _type;
        public string Type { get => _type; set { _type = value;  } }
        private int _index;
        public int Index { get => _index; set { _index = value; } }
        private int _channel;
        public int Channel { get => _channel; set { _channel = value; } }
        private string _name;
        public string Name { get => _name; set { _name = value;} }

        private long _id;
        public long Id { get => _id; set { _id = value; } }
    }
}