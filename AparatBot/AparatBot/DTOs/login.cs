using System;
using System.Collections.Generic;
using System.Text;
using static System.Collections.Specialized.BitVector32;

namespace AparatBot.DTOs
{
    public class login
    {
        public string passsalt { get; set; }
        public string ltoken { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string pic { get; set; }
        public string banned { get; set; }
        public string id { get; set; }
        public string email { get; set; }
        public string pic_app { get; set; }
        public string mobile_number { get; set; }
        public string mobile_valid { get; set; }
        public string device_type { get; set; }
        public string action { get; set; }
        public string pic_s { get; set; }
        public string pic_m { get; set; }
        public string pic_b { get; set; }

    }
}
