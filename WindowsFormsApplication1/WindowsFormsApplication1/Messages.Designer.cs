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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListChat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butSend = new System.Windows.Forms.Button();
            this.butAttachment = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBoxAttach = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labStatusUser = new System.Windows.Forms.Label();
            this.labNameFriend = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListChat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butSend);
            this.groupBox1.Controls.Add(this.butAttachment);
            this.groupBox1.Location = new System.Drawing.Point(5, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(519, 425);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat User";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // ListChat
            // 
            this.ListChat.Location = new System.Drawing.Point(8, 23);
            this.ListChat.Margin = new System.Windows.Forms.Padding(4);
            this.ListChat.Name = "ListChat";
            this.ListChat.ReadOnly = true;
            this.ListChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ListChat.Size = new System.Drawing.Size(501, 219);
            this.ListChat.TabIndex = 3;
            this.ListChat.Text = "";
            this.ListChat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListChat_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message Input:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(353, 348);
            this.butSend.Margin = new System.Windows.Forms.Padding(4);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(155, 66);
            this.butSend.TabIndex = 1;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // butAttachment
            // 
            this.butAttachment.Location = new System.Drawing.Point(353, 279);
            this.butAttachment.Margin = new System.Windows.Forms.Padding(4);
            this.butAttachment.Name = "butAttachment";
            this.butAttachment.Size = new System.Drawing.Size(155, 62);
            this.butAttachment.TabIndex = 2;
            this.butAttachment.Text = "Attach";
            this.butAttachment.UseVisualStyleBackColor = true;
            this.butAttachment.Click += new System.EventHandler(this.butAttachment_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 287);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(333, 134);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // pictureBoxAttach
            // 
            this.pictureBoxAttach.Location = new System.Drawing.Point(8, 23);
            this.pictureBoxAttach.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAttach.Name = "pictureBoxAttach";
            this.pictureBoxAttach.Size = new System.Drawing.Size(235, 213);
            this.pictureBoxAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAttach.TabIndex = 3;
            this.pictureBoxAttach.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(8, 258);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(512, 148);
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
            this.groupBox2.Location = new System.Drawing.Point(532, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(529, 415);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friends";
            // 
            // labStatusUser
            // 
            this.labStatusUser.AutoSize = true;
            this.labStatusUser.Location = new System.Drawing.Point(365, 126);
            this.labStatusUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStatusUser.Name = "labStatusUser";
            this.labStatusUser.Size = new System.Drawing.Size(46, 17);
            this.labStatusUser.TabIndex = 6;
            this.labStatusUser.Text = "label2";
            // 
            // labNameFriend
            // 
            this.labNameFriend.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labNameFriend.Location = new System.Drawing.Point(251, 46);
            this.labNameFriend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNameFriend.Name = "labNameFriend";
            this.labNameFriend.Size = new System.Drawing.Size(271, 80);
            this.labNameFriend.TabIndex = 5;
            this.labNameFriend.Text = "label2";
            this.labNameFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1071, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(239, 20);
            this.toolStripStatusLabel1.Text = "Контент к отправке не добавлен.";
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 463);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Messages";
            this.Text = "Messages VK";
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labNameFriend;
        private System.Windows.Forms.Label labStatusUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox ListChat;
    }
}