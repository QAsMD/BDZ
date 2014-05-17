using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Messages : Form
    {
        string PATH_JPG = String.Empty;
        Dictionary<string, string> friend_dict = new Dictionary<string, string>();
        List<UsersVK> friends_vk = new List<UsersVK>();
        public Messages()
        {
            InitializeComponent();
            var friends = lib_vk.friends_get(Settings1.Default.id);
            int count = 0;
            foreach (var friend in friends)
            {
                count++;
                UsersVK friend_user = new UsersVK(friend);
                friends_vk.Add(friend_user);
                listBoxFriends.Items.Add(count.ToString() + ". " + friend_user.name_user);
            }
            listBoxFriends.SetSelected(0, true);
            pictureBoxAttach.Load(friends_vk[0].url_photo);
            labNameFriend.Text = friends_vk[0].name_user;
            labStatusUser.Text = friends_vk[0].status_online;
            groupBox2.Text = "Друзья (" + count.ToString() + "):";
        }
        private void butAttachment_Click(object sender, EventArgs e)
        {
            openFileDialogImage.ShowDialog();
            PATH_JPG = openFileDialogImage.FileName;
            MessageBox.Show(PATH_JPG);
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            int index = listBoxFriends.SelectedIndex;
            string id_send = friends_vk[index].id_user;
            MessageBox.Show(id_send);

            if (richTextBox1.Text != "" && PATH_JPG == "")
            {
                var content = lib_vk.message_send(id_send, richTextBox1.Text, "");
            }
            else if (richTextBox1.Text == "" && PATH_JPG != "")
            {
                string name_file = PATH_JPG.Substring(PATH_JPG.LastIndexOf("\\") + 1);
                var file = lib_vk.docs_save(PATH_JPG, name_file);
                var content = lib_vk.message_send(id_send, richTextBox1.Text, file);
            }
            else if (richTextBox1.Text != "" && PATH_JPG != "")
            {
                string name_file = PATH_JPG.Substring(PATH_JPG.LastIndexOf("\\") + 1);
                var file = lib_vk.docs_save(PATH_JPG, name_file);
                var content = lib_vk.message_send(id_send, richTextBox1.Text, file);
            }
            else
            {
                MessageBox.Show("Введите сообщение или выберите файл для отправки");
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxFriends.SelectedIndex;
            UsersVK friend = friends_vk[index];
            pictureBoxAttach.Load(friend.url_photo);
            labNameFriend.Text = friend.name_user;
            labStatusUser.Text = friend.status_online;
            get_message_history(friend.id_user, friend.name_user);
        }

        private void get_message_history(string id_user, string name_user)
        {
            string message;
            List<string> list_message = new List<string>();
            var message_history = lib_vk.messages_history(id_user);
            groupBox1.Text = "Chat with '" + name_user + "'. Unread: ";
            try
            {
                string unread_message = message_history["unread"];
                groupBox1.Text += unread_message;
            }
            catch
            {
                groupBox1.Text += "0";
            }
            foreach (var element in message_history["items"])
            {
                string time = lib_vk.ConvertFromUnixTimestamp((double)element["date"]);
                if (element["out"] == 0)
                {
                    message = name_user + ": " + element["body"];
                }
                else
                {
                    message = "Вы: " + element["body"];
                }
                list_message.Add(message + "\n\t\t\t" + time + "\n\n\n");
            }
            list_message.Reverse();
            ListChat.Text = "";
            foreach (var element in list_message)
            {
                ListChat.Text += element;
            }
        }
    }
}
