using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO; 

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ImageList list_image = new ImageList();
        public Form1()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void connectAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Settings1.Default.auth)
            {
                new Form2().Show();
            }
            
            btn_Friends.Enabled = true;
            btn_Messages.Enabled = true;
            btn_Profile.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            string name_user = String.Empty;
            string image_user = String.Empty;

            var result = lib_vk.users_get("21881340", "photo_max_orig");
            var response = result["response"];
            string url_photo = response[0]["photo_max_orig"];
            string str = response[0]["first_name"];
            name_user = lib_encode.encode_str(str);
            //name_user += " " + lib_encode.encode_str(response[0]["last_name"]);
            pictureBox1.Load(url_photo);
            label1.Text = name_user;
        }
    }
}
