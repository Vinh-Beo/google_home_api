using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.HomeFloorRoomResponseModel
{
    public class HomeFloorRoomResponseModel
    {
        public long UserId { get; set; }
        public List<Homes> Homes { get; set; }
    }
    public class Homes
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Floors> Floors { get; set; }
    }
    public class Floors
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int FloorIndex { get; set; }
        public List<Rooms> Rooms { get; set; }
    }
    public class Rooms
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int RoomIndex { get; set; }
        public string Background { get; set; }
        public List<Devices> Devices { get; set; }
    }
    public class Devices
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        public int Index { get; set; }
        public int Channel { get; set; }

        public string TypeMore { get; set; }
    }
}