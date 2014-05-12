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
        public Messages()
        {
            InitializeComponent();
            var friends = lib_vk.friends_get(Settings1.Default.id);
            int count = 0;
            foreach (var friend in friends)
            {
                count++;
                string name = count.ToString() + ". " + friend["first_name"] + " " + friend["last_name"] + " ID:" + friend["uid"];
                listBoxFriends.Items.Add(name);
            }
        }

        private void butAttachment_Click(object sender, EventArgs e)
        {
            openFileDialogImage.ShowDialog();
            PATH_JPG = openFileDialogImage.FileName;
            MessageBox.Show(PATH_JPG);
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            string friend = "";
            string id_send = "";
            if (richTextBox1.Text != "" && PATH_JPG != "")
            {
                try
                {
                    friend = listBoxFriends.SelectedItem.ToString();
                    id_send = friend.Substring(friend.IndexOf("ID:") + 3);
                    MessageBox.Show(friend);
                }
                catch
                {
                    MessageBox.Show("Выберите друга для отправки сообщения");
                }
                var content = lib_vk.message_send(Convert.ToInt32(id_send), richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Введите сообщение и выберите файл для отправки");
            }
        }
    }
}
