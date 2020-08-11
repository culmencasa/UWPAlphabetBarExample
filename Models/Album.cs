using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{


    public class AlbumGroup
    {
        public string Name { get; set; }

        public List<Album> Albums { get; set; } = new List<Album>();
    }


    public class Album
    {
        public string Artist { get; set; }

        public string AlbumName { get; set; }

        public Uri Thumbnail { get; set; } = new Uri($"ms-appx:///Assets/album.png");

    }
}
