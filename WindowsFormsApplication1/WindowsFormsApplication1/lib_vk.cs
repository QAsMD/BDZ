using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using xNet.Net;
using xNet;

namespace WindowsFormsApplication1
{
    class lib_vk
    {
        static string uri_api = "https://api.vk.com/method/";
        public static dynamic friends_get(string id_user, string fields = "screen_name")
        {
            Dictionary<string, dynamic> result;
            string error;

            var request = new HttpRequest();
            request.AddUrlParam("user_ids", id_user);
            request.AddUrlParam("order", "hints");
            request.AddUrlParam("fields", fields);
            request.AddUrlParam("access_token", Settings1.Default.token);
            try
            {
                string content = request.Get(uri_api + "friends.get?").ToString();
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);

                return result["response"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(error = ex.Message + " " + ex.InnerException);
                return null;
            }
        }

        public static dynamic users_get(string id_user, string fields)
        {
            Dictionary<string, dynamic> result;
            string error = "";

            var request = new HttpRequest();
            request.AddUrlParam("user_ids", id_user);
            request.AddUrlParam("access_token", Settings1.Default.token);
            request.AddUrlParam("fields", fields);
            try
            {
                string content = request.Get(uri_api + "users.get?").ToString();
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);
                return result["response"][0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(error = ex.Message + " " + ex.InnerException);
                return null;
            }
        }

        public static string ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp).ToString();
        }

        public static Dictionary<string, dynamic> messages_get(int count = 20)
        {
            Dictionary<string, dynamic> result;
            string error = "";
            var request = new HttpRequest();
            request.AddUrlParam("out", "0");
            request.AddUrlParam("access_token", Settings1.Default.token);
            request.AddUrlParam("count", count.ToString());
            request.AddUrlParam("time_offset", "0");
                
            try
            {
                string content = request.Get(uri_api + "messages.get?").ToString();
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(error = ex.Message + " " + ex.InnerException);
                return null;
            }
        }

        public static dynamic message_send(int user_id, string message = "Привет от Шарпов", string attachment = "doc21881340_285976245")
        {
            Dictionary<string, dynamic> result;
            string error = "";
            var request = new HttpRequest();
            request.AddUrlParam("user_id", user_id.ToString());
            request.AddUrlParam("message", message);
            request.AddUrlParam("attachment", attachment);
            request.AddUrlParam("access_token", Settings1.Default.token);
            try
            {
                string content = request.Get(uri_api + "messages.send?").ToString();
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);
                return result["response"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(error = ex.Message + " " + ex.InnerException);
                return null;
            }
        }
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