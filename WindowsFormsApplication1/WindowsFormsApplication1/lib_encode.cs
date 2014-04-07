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
    class lib_encode
    {
        public static string encode_str(string str)
        {
            Encoding srcEncodingFormat = Encoding.Default;
            Encoding dstEncodingFormat = Encoding.UTF8;
            byte[] originalByteString = srcEncodingFormat.GetBytes(str);
            string name = dstEncodingFormat.GetString(originalByteString);
            return name;
        }
    }
}
