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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.butAttachment = new System.Windows.Forms.Button();
            this.pictureBoxAttach = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttach)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 215);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(459, 110);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(477, 271);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(145, 54);
            this.butSend.TabIndex = 1;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // butAttachment
            // 
            this.butAttachment.Location = new System.Drawing.Point(477, 215);
            this.butAttachment.Name = "butAttachment";
            this.butAttachment.Size = new System.Drawing.Size(145, 50);
            this.butAttachment.TabIndex = 2;
            this.butAttachment.Text = "Attach";
            this.butAttachment.UseVisualStyleBackColor = true;
            this.butAttachment.Click += new System.EventHandler(this.butAttachment_Click);
            // 
            // pictureBoxAttach
            // 
            this.pictureBoxAttach.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAttach.Name = "pictureBoxAttach";
            this.pictureBoxAttach.Size = new System.Drawing.Size(204, 197);
            this.pictureBoxAttach.TabIndex = 3;
            this.pictureBoxAttach.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(222, 27);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(400, 173);
            this.listBoxFriends.TabIndex = 4;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.DefaultExt = "jpg";
            this.openFileDialogImage.Filter = "Изображения JPEG|*.jpg";
            this.openFileDialogImage.Title = "Выберите изображение для шифрования";
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 337);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.pictureBoxAttach);
            this.Controls.Add(this.butAttachment);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Messages";
            this.Text = "Messages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Button butAttachment;
        private System.Windows.Forms.PictureBox pictureBoxAttach;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
    }
}