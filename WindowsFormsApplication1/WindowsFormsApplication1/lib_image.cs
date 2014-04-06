using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace WindowsFormsApplication1
{
    class lib_image
    {
        static WebClient client = new WebClient();
        public static Image download_image(string url)
        {
            Image picture;
            byte[] imageByte = client.DownloadData(url);
            using (MemoryStream ms = new MemoryStream(imageByte, 0, imageByte.Length))
            {
                ms.Write(imageByte, 0, imageByte.Length);
                picture = Image.FromStream(ms, true);
            }
            return picture;
        }
    }
}
