using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


// @date; 2019-03-15
// @athor: benjamin zipperer
// The model for "Album".
namespace MUSIC_WEP_API.Models
{
    public class Album
    {
        public int      AlbumId              { get; set; }
        public string   Interpret         { get; set; }

        public string   AlbumTitle        { get; set; }

        public int      NumberTracks { get; set; }

        public string Description { get; set; }

        public string PicturePath { get; set; }
    }
}