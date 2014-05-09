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
        public static Dictionary<string, dynamic> friends_get(string id_user, string fields)
        {
            Dictionary<string, dynamic> result;
            string error;

            var request = new HttpRequest();
            request.AddUrlParam("user_ids", id_user);
            request.AddUrlParam("order", "hints");
            request.AddUrlParam("fields", fields);
            string content = request.Get(uri_api + "friends.get?").ToString();
            try
            {
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);

                return result;
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
            string content = request.Get(uri_api + "users.get?").ToString();
            try
            {
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

        //public static Dictionary<string, dynamic> messages_get(int count = 20)
        //{
        //    WebClient client = new WebClient();
        //    Dictionary<string, dynamic> result;
        //    string error = "";
        //    client.QueryString.Add("out", "0");
        //    client.QueryString.Add("time_offset", "0");
        //    client.QueryString.Add("count", count.ToString());
        //    client.QueryString.Add("access_token", Settings1.Default.token);
        //    try
        //    {
        //        string response = client.DownloadString(uri_api + "messages.get");
        //        result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(error = ex.Message + " " + ex.InnerException);
        //        return null;
        //    }
        //}
        //public static Dictionary<string, dynamic> message_send(int user_id, string message = "Привет от Шарпов(C#)", string attachment = "doc21881340_285976245")
        //{
        //    WebClient client = new WebClient();
        //    Dictionary<string, dynamic> result;
        //    string error = "";
        //    client.QueryString.Add("user_id", user_id.ToString());
        //    client.QueryString.Add("message", message);
        //    client.QueryString.Add("attachment", attachment);
        //    client.QueryString.Add("access_token", Settings1.Default.token);
        //    try
        //    {
        //        string response = client.DownloadString(uri_api + "messages.send");
        //        result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(error = ex.Message + " " + ex.InnerException);
        //        return null;
        //    }
        //}
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