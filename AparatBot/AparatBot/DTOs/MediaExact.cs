using System;
using System.Collections.Generic;
using System.Text;

namespace AparatBot.DTOs
{
    public class MediaExact:Media
    {
        public List<tags> tags { get; set; }
        public string description { get; set; }
        public string cat_id { get; set; }
        public string cat_name { get; set; }
        public string like_cnt { get; set; }
        public string has_comment { get; set; }
        public string size { get; set; }
        public bool can_download { get; set; }
        public string ip_address { get; set; }
        public string file_link { get; set; }


    }
    public class tags 
    {
        public string name { get; set; }
        public string cnt { get; set; }

    }

}


//description 
//cat_id 16
//cat_name کسب و کار
//cat_name_en ads
//autoplay true
//video_date_status notset

//has_comment_txt 
//size 4982849
//watch_action
//type watch
//cost_type
//type free
//can_download true
//like_cnt 81
//follow_link
//follow_status
//ip_address 5.121.152.232
//file_link https://aspb15.asset.aparat.com/aparat-video/c16dcd85e4bfdd6a2f4fab91686d57ec1146420.apt?wmsAuthSign=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ0b2tlbiI6IjFjOTMzNTAwM2ZjMmJlOGNlYjY5MjlmMzcyN2U4MDNkIiwiZXhwIjoxNjg1OTI5NzQzLCJpc3MiOiJTYWJhIElkZWEgR1NJRyJ9.I1-fftqM8gZKMro-BbZY5j0HxFuBlyZySTcA_RGe6so
//file_link_all
//text دانلود ویدیو
//profile 
//urls
//https://aspb15.asset.aparat.com/aparat-video/c16dcd85e4bfdd6a2f4fab91686d57ec1146420.mp4?wmsAuthSign=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ0b2tlbiI6ImVmYjNiZWVjNDE1ZDdjZjZkNDBjNzE3ODRmZmM0MTY4IiwiZXhwIjoxNjg1OTI5NzQzLCJpc3MiOiJTYWJhIElkZWEgR1NJRyJ9.0m-qV2cec_SzPTvuJcQEm44nr4qj0n2SF-M_nUkADsw



