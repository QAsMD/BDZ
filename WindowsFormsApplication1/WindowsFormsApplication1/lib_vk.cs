using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net;
using xNet.Net;
using xNet;
using System.IO;

namespace WindowsFormsApplication1
{
    class lib_vk
    {
        static string uri_api = "https://api.vk.com/method/";
        public static dynamic friends_get(string id_user, string fields = "screen_name, photo_max_orig")
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
                string content = request.Get(uri_api + "friends.get").ToString();
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
                string content = request.Get(uri_api + "users.get").ToString();
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

        public static dynamic messages_get(int count = 20)
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
                string content = request.Get(uri_api + "messages.get").ToString();
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);
                return result["response"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(error = ex.Message + " " + ex.InnerException);
                return null;
            }
        }

        public static dynamic message_send(string user_id, string message = "Привет от Шарпов", string attachment = "doc21881340_285976245")
        {
            Dictionary<string, dynamic> result;
            string error = "";
            var request = new HttpRequest();
            request.AddUrlParam("user_id", user_id);
            request.AddUrlParam("message", message);
            request.AddUrlParam("attachment", attachment);
            request.AddUrlParam("access_token", Settings1.Default.token);
            try
            {
                string content = request.Get(uri_api + "messages.send").ToString();
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);
                return result["response"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(error = ex.Message + " " + ex.InnerException);
                return null;
            }
        }

        private static dynamic getUploadServer(string group_id = "", string v = "5.21")
        {
            Dictionary<string, dynamic> result;
            string error = "";
            var request = new HttpRequest();
            request.AddUrlParam("group_id", group_id);
            request.AddUrlParam("v", v);
            request.AddUrlParam("access_token", Settings1.Default.token);
            try
            {
                string content = request.Get(uri_api + "docs.getUploadServer").ToString();
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);
                return result["response"]["upload_url"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(error = ex.Message + " " + ex.InnerException);
                return null;
            }
        }

        public static dynamic docs_save(string path_file, string name_doc = "Unknown", string v = "5.21")
        {
            Dictionary<string, dynamic> result;
            string error = "";

            var request = new HttpRequest();
            request.AddUrlParam("access_token", Settings1.Default.token);
            request.AddUrlParam("v", v);

            try
            {
                string content = request.Get(uri_api + "docs.getUploadServer").ToString();
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);
                string url_upload = result["response"]["upload_url"];

                request = new HttpRequest();
                request.AddFile("file", path_file);
                content = request.Post(url_upload).ToString();
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);

                request = new HttpRequest();
                request.AddUrlParam("file", result["file"]);
                request.AddUrlParam("title", name_doc.Replace(".jpg", ""));
                request.AddUrlParam("access_token", Settings1.Default.token);
                request.AddUrlParam("v", v);

                content = request.Get(uri_api + "docs.save").ToString();
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);
                string result_string = "doc" + result["response"][0]["owner_id"] + "_" + result["response"][0]["id"];
                return result_string;
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