namespace WindowsFormsApplication1
{
    partial class Messages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox groupBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.label1 = new System.Windows.Forms.Label();
            this.ListChat = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.butAttachment = new System.Windows.Forms.Button();
            this.pictureBoxAttach = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labNameFriend = new System.Windows.Forms.Label();
            this.labStatusUser = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.label1);
            groupBox1.Controls.Add(this.butSend);
            groupBox1.Controls.Add(this.ListChat);
            groupBox1.Controls.Add(this.butAttachment);
            groupBox1.Location = new System.Drawing.Point(4, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(389, 345);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chat User";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message Input:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListChat
            // 
            this.ListChat.FormattingEnabled = true;
            this.ListChat.Location = new System.Drawing.Point(8, 19);
            this.ListChat.Name = "ListChat";
            this.ListChat.Size = new System.Drawing.Size(373, 173);
            this.ListChat.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 233);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(251, 110);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(265, 283);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(116, 54);
            this.butSend.TabIndex = 1;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // butAttachment
            // 
            this.butAttachment.Location = new System.Drawing.Point(265, 227);
            this.butAttachment.Name = "butAttachment";
            this.butAttachment.Size = new System.Drawing.Size(116, 50);
            this.butAttachment.TabIndex = 2;
            this.butAttachment.Text = "Attach";
            this.butAttachment.UseVisualStyleBackColor = true;
            this.butAttachment.Click += new System.EventHandler(this.butAttachment_Click);
            // 
            // pictureBoxAttach
            // 
            this.pictureBoxAttach.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxAttach.Name = "pictureBoxAttach";
            this.pictureBoxAttach.Size = new System.Drawing.Size(176, 173);
            this.pictureBoxAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAttach.TabIndex = 3;
            this.pictureBoxAttach.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(6, 210);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(385, 121);
            this.listBoxFriends.TabIndex = 4;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.DefaultExt = "jpg";
            this.openFileDialogImage.Filter = "Изображения JPEG|*.jpg";
            this.openFileDialogImage.Title = "Выберите изображение для шифрования";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labStatusUser);
            this.groupBox2.Controls.Add(this.labNameFriend);
            this.groupBox2.Controls.Add(this.listBoxFriends);
            this.groupBox2.Controls.Add(this.pictureBoxAttach);
            this.groupBox2.Location = new System.Drawing.Point(399, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 337);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friends";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(187, 17);
            this.toolStripStatusLabel1.Text = "Контент к отправке не добавлен.";
            // 
            // labNameFriend
            // 
            this.labNameFriend.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labNameFriend.Location = new System.Drawing.Point(188, 37);
            this.labNameFriend.Name = "labNameFriend";
            this.labNameFriend.Size = new System.Drawing.Size(203, 50);
            this.labNameFriend.TabIndex = 5;
            this.labNameFriend.Text = "label2";
            this.labNameFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labStatusUser
            // 
            this.labStatusUser.AutoSize = true;
            this.labStatusUser.Location = new System.Drawing.Point(274, 87);
            this.labStatusUser.Name = "labStatusUser";
            this.labStatusUser.Size = new System.Drawing.Size(35, 13);
            this.labStatusUser.TabIndex = 6;
            this.labStatusUser.Text = "label2";
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 376);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Messages";
            this.Text = "Messages VK";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Button butAttachment;
        private System.Windows.Forms.PictureBox pictureBoxAttach;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListChat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labNameFriend;
        private System.Windows.Forms.Label labStatusUser;
    }
}