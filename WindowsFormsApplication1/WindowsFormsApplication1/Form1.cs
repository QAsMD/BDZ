﻿using System;
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

            var result = lib_vk.users_get("21881340", "photo_max_orig, status, last_seen, counters");
            string url_photo = result["photo_max_orig"];
            try
            {
                var status = result["status_audio"];
                labStatus.Text = "AudioPlay: ";
                labTextStatus.Text = status["artist"] + " - " + status["title"];
            }
            catch
            {
                labStatus.Text = "Status: ";
                labTextStatus.Text = result["status"];
            }
            name_user = result["first_name"] + " " + result["last_name"];
            labTextLastSeen.Text = lib_vk.ConvertFromUnixTimestamp((double)result["last_seen"]["time"]);
            pictureBoxProfile.Load(url_photo);
            labName.Text = name_user;
        }

        private void btn_Messages_Click(object sender, EventArgs e)
        {
            new Messages().Show();
        }
    }
}
