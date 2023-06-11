using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace AparatBot.DTOs
{
    public class Media
    {
        public string id { get; set; }
        public string title { get; set; }
        public string username { get; set; }
        public long userid { get; set; }
        public long visit_cnt { get; set; }
        public string uid { get; set; }
        public bool isHidden { get; set; }
        public string process { get; set; }
        public string sender_name { get; set; }
        public string big_poster { get; set; }
        public string small_poster { get; set; }
        public string profilePhoto { get; set; }
        public string duration { get; set; }
        public string sdate { get; set; }
        public string create_date { get; set; }
        public string sdate_timediff { get; set; }
        public string frame { get; set; }
        public string official { get; set; }
        public string autoplay { get; set; }
        public string video_date_status { get; set; }

    }



}


