namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_Friends = new System.Windows.Forms.Button();
            this.btn_Messages = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labName = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.labFriends = new System.Windows.Forms.Label();
            this.labTextLastSeen = new System.Windows.Forms.Label();
            this.labTextStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectAPIToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // connectAPIToolStripMenuItem
            // 
            this.connectAPIToolStripMenuItem.Name = "connectAPIToolStripMenuItem";
            this.connectAPIToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.connectAPIToolStripMenuItem.Text = "Connect API";
            this.connectAPIToolStripMenuItem.Click += new System.EventHandler(this.connectAPIToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Enabled = false;
            this.btn_Profile.Location = new System.Drawing.Point(9, 25);
            this.btn_Profile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(143, 39);
            this.btn_Profile.TabIndex = 1;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_Friends
            // 
            this.btn_Friends.Enabled = false;
            this.btn_Friends.Location = new System.Drawing.Point(199, 25);
            this.btn_Friends.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Friends.Name = "btn_Friends";
            this.btn_Friends.Size = new System.Drawing.Size(143, 39);
            this.btn_Friends.TabIndex = 2;
            this.btn_Friends.Text = "Music";
            this.btn_Friends.UseVisualStyleBackColor = true;
            // 
            // btn_Messages
            // 
            this.btn_Messages.Enabled = false;
            this.btn_Messages.Location = new System.Drawing.Point(388, 25);
            this.btn_Messages.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Messages.Name = "btn_Messages";
            this.btn_Messages.Size = new System.Drawing.Size(143, 39);
            this.btn_Messages.TabIndex = 3;
            this.btn_Messages.Text = "Messages";
            this.btn_Messages.UseVisualStyleBackColor = true;
            this.btn_Messages.Click += new System.EventHandler(this.btn_Messages_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(11, 68);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(219, 295);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labName
            // 
            this.labName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labName.Location = new System.Drawing.Point(234, 68);
            this.labName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(212, 39);
            this.labName.TabIndex = 5;
            this.labName.Text = "name_user";
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(235, 107);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(43, 13);
            this.labStatus.TabIndex = 6;
            this.labStatus.Text = "Status: ";
            // 
            // labFriends
            // 
            this.labFriends.AutoSize = true;
            this.labFriends.Location = new System.Drawing.Point(235, 134);
            this.labFriends.Name = "labFriends";
            this.labFriends.Size = new System.Drawing.Size(61, 13);
            this.labFriends.TabIndex = 7;
            this.labFriends.Text = "Last Seen: ";
            // 
            // labTextLastSeen
            // 
            this.labTextLastSeen.AutoSize = true;
            this.labTextLastSeen.Location = new System.Drawing.Point(296, 134);
            this.labTextLastSeen.Name = "labTextLastSeen";
            this.labTextLastSeen.Size = new System.Drawing.Size(0, 13);
            this.labTextLastSeen.TabIndex = 8;
            // 
            // labTextStatus
            // 
            this.labTextStatus.AutoSize = true;
            this.labTextStatus.Location = new System.Drawing.Point(296, 107);
            this.labTextStatus.Name = "labTextStatus";
            this.labTextStatus.Size = new System.Drawing.Size(0, 13);
            this.labTextStatus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 374);
            this.Controls.Add(this.labTextStatus);
            this.Controls.Add(this.labTextLastSeen);
            this.Controls.Add(this.labFriends);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.btn_Messages);
            this.Controls.Add(this.btn_Friends);
            this.Controls.Add(this.btn_Profile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Encryption Message";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectAPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Button btn_Friends;
        private System.Windows.Forms.Button btn_Messages;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labFriends;
        private System.Windows.Forms.Label labTextLastSeen;
        private System.Windows.Forms.Label labTextStatus;
    }
}

