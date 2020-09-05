using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCClubNostalgia
{
    public class AppPather
    {
        public ObjectId Id { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string iconPath { get; set; }
    }

    
}
