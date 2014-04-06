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
            Encoding srcEncodingFormat = Encoding.GetEncoding("UTF-16");
            Encoding dstEncodingFormat = Encoding.ASCII;
            byte[] originalByteString = srcEncodingFormat.GetBytes(str);
            byte[] convertedByteString = Encoding.Convert(srcEncodingFormat,
            dstEncodingFormat, originalByteString);
            string finalString = dstEncodingFormat.GetString(convertedByteString);
            return finalString;
        }
    }
}
