using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamee
{
    public class Settings
    {
        public static int width { get; set; }
        public static int height { get; set; }
        public static string directions;
        public Settings()
        {
            width = 16;
            height = 16;
            directions = "left";
        }
    }
}
