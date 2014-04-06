﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class lib_vk
    {
        static WebClient client = new WebClient();
        static string uri_api = "https://api.vk.com/method/";

        public static void remover()
        {
            var keys = client.QueryString.Keys;

            foreach (var key in keys)
            {
                client.QueryString.Remove((string)key);
            }
        }
        
        
        public static Dictionary<string,dynamic> friends_get(string id_user, string fields)
        {
            Dictionary<string, dynamic> result;
            string error = "";
                        
            client.QueryString.Add("user_ids", id_user);
            client.QueryString.Add("order", "hints");
            client.QueryString.Add("fields", fields);

            try
            {
                string response = client.DownloadString(uri_api + "friends.get");
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response);

                lib_vk.remover();

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(error = ex.Message + " " + ex.InnerException);
                return null;
            }
        }
        
        public static Dictionary<string, dynamic> users_get(string id_user, string fields)
        {
            Dictionary<string, dynamic> result;
            string error = "";
            client.QueryString.Add("user_ids", id_user);
            client.QueryString.Add("fields", fields);
            client.QueryString.Add("v", "5.17");
            client.QueryString.Add("access_token", Settings1.Default.token);
            try
            {
                string response = client.DownloadString(uri_api + "users.get");
                result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response);
                
                lib_vk.remover();
                
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(error = ex.Message + " " + ex.InnerException);
                return null;
            }
        }
    }
}