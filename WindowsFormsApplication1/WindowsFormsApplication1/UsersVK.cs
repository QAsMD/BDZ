using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class UsersVK
    {
        public string name_user = String.Empty;
        public string url_photo = String.Empty;
        public string id_user = String.Empty;
        public string status_online = String.Empty;
        private dynamic data_user = String.Empty;
        public UsersVK(dynamic vk_data)
        {
            string name = vk_data["first_name"] + " " + vk_data["last_name"];
            name_user = name;
            if (vk_data["online"] == 0)
                status_online = "Offline";
            else
                status_online = "Online";
            url_photo = vk_data["photo_max_orig"];
            id_user = vk_data["uid"];
            data_user = vk_data;
        }

        public string update_status_user()
        {
            var result = lib_vk.users_get(id_user, "status");
            if (result["online"] == 0)
            {
                status_online = "Offline";
                return "online";
            }
            else
            {
                status_online = "Online";
                return "online";
            }
        }
    }
}
