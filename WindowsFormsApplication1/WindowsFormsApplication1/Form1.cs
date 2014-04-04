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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
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
            listView1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            var result = lib_vk.users_get(Settings1.Default.id, "photo_max_orig");
            //listView1.Items.Add();
        }
    }
}
