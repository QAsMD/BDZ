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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Friends = new System.Windows.Forms.Button();
            this.btn_Messages = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labName = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.labFriends = new System.Windows.Forms.Label();
            this.labTextLastSeen = new System.Windows.Forms.Label();
            this.labTextStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Friends
            // 
            this.btn_Friends.Enabled = false;
            this.btn_Friends.Location = new System.Drawing.Point(312, 161);
            this.btn_Friends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Friends.Name = "btn_Friends";
            this.btn_Friends.Size = new System.Drawing.Size(320, 48);
            this.btn_Friends.TabIndex = 2;
            this.btn_Friends.Text = "Music";
            this.btn_Friends.UseVisualStyleBackColor = true;
            // 
            // btn_Messages
            // 
            this.btn_Messages.Enabled = false;
            this.btn_Messages.Location = new System.Drawing.Point(312, 214);
            this.btn_Messages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Messages.Name = "btn_Messages";
            this.btn_Messages.Size = new System.Drawing.Size(320, 48);
            this.btn_Messages.TabIndex = 3;
            this.btn_Messages.Text = "Messages";
            this.btn_Messages.UseVisualStyleBackColor = true;
            this.btn_Messages.Click += new System.EventHandler(this.btn_Messages_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(15, 14);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(291, 312);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labName
            // 
            this.labName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labName.Location = new System.Drawing.Point(312, 14);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(320, 71);
            this.labName.TabIndex = 5;
            this.labName.Text = "name_user";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(315, 85);
            this.labStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(56, 17);
            this.labStatus.TabIndex = 6;
            this.labStatus.Text = "Status: ";
            // 
            // labFriends
            // 
            this.labFriends.AutoSize = true;
            this.labFriends.Location = new System.Drawing.Point(315, 121);
            this.labFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFriends.Name = "labFriends";
            this.labFriends.Size = new System.Drawing.Size(80, 17);
            this.labFriends.TabIndex = 7;
            this.labFriends.Text = "Last Seen: ";
            // 
            // labTextLastSeen
            // 
            this.labTextLastSeen.AutoSize = true;
            this.labTextLastSeen.Location = new System.Drawing.Point(396, 121);
            this.labTextLastSeen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTextLastSeen.Name = "labTextLastSeen";
            this.labTextLastSeen.Size = new System.Drawing.Size(0, 17);
            this.labTextLastSeen.TabIndex = 8;
            // 
            // labTextStatus
            // 
            this.labTextStatus.AutoSize = true;
            this.labTextStatus.Location = new System.Drawing.Point(380, 85);
            this.labTextStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTextStatus.Name = "labTextStatus";
            this.labTextStatus.Size = new System.Drawing.Size(0, 17);
            this.labTextStatus.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Connect API";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labTextStatus);
            this.Controls.Add(this.labTextLastSeen);
            this.Controls.Add(this.labFriends);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.btn_Messages);
            this.Controls.Add(this.btn_Friends);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Encryption Message";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Friends;
        private System.Windows.Forms.Button btn_Messages;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labFriends;
        private System.Windows.Forms.Label labTextLastSeen;
        private System.Windows.Forms.Label labTextStatus;
        private System.Windows.Forms.Button button1;
    }
}

