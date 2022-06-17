using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class SceneVoiceModel
    {
        private string _mceCode;
        public string MceCode { get => _mceCode; set { _mceCode = value; } }

        private string _name;
        public string Name { get => _name; set { _name = value; } }

        private string _type;
        public string Type { get => _type; set { _type = value; } }

        private long _index;
        public long Index { get => _index; set { _index = value; } }
    }
}