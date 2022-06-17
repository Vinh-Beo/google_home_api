using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.DeviceChannelItemResponseModel
{
    public class DeviceChannelItemResponseModel
    {
        public long UserId { get; set; }

        public string UserApiKey { get; set; }
        public List<Homes> Homes { get; set; }
    }
    public class Homes
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Channels> Channels { get; set; }
        public List<SceneItemViewModel> Scenes { get; set; }
    }
    public class Channels
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public int Index { get; set; }
        public int Channel { get; set; }

        public string DeviceName { get; set; }
        public string ChannelName { get; set; }

        public string TypeMore { get; set; }
    }

    public class SceneItemViewModel
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public int HwIndex { get; set; }
        public string Name { get; set; }
    }
}