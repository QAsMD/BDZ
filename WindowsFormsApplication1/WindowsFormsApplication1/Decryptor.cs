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
    public partial class Decryptor : Form
    {
        public Decryptor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && NameBox2.Text!= "")
            {
                label4.Text = "Message: ";
                pictureBox1.Load(textBox1.Text);
                download_content(NameBox2.Text, textBox1.Text);
            }
            else
            {
                MessageBox.Show("Заполните все поля формы!");
            }
        }

        private void download_content(string name_file, string url, string type_content=".jpg")
        {
            name_file += type_content;
            // Делаем загрузку с помощью System.Net.WebClient.
            var webClient = new WebClient();
            var beforeProgress = 0; // счетчик прогресса

            // подписываемся на событие изменения прогресса, чтобы выводить на экран
            webClient.DownloadProgressChanged += (s, e) =>
            {
                // ну и выводим соответственно через каждые 10%
                if (e.ProgressPercentage - 10 > beforeProgress)
                {
                    beforeProgress += 10;
                    toolStripProgressBar1.Value = beforeProgress;
                }
            };

            // подписываемся на событие окончания загрузки, чтобы знать когда загрузка закончится
            webClient.DownloadFileCompleted += (s, e) =>
            {
                toolStripProgressBar1.Value += 10;
                IconEncrypt.BalloonTipTitle = "Status decrypt:";
                IconEncrypt.BalloonTipText = "File downloaded: Done";
                IconEncrypt.ShowBalloonTip(1000);
                string encrypt_message = get_encrypt_message(name_file, name_file);
                IconEncrypt.BalloonTipText = "Data encrypt get: Done.";
                IconEncrypt.ShowBalloonTip(1000);
                var result = ClassSecurity.Decrypt(encrypt_message, name_file.Substring(name_file.LastIndexOf("_") + 1));
                IconEncrypt.BalloonTipText = "Data decrypt get: Done.";
                IconEncrypt.ShowBalloonTip(1000);
                label4.Text += result;
            };

            // запускаем загрузку асинхронно.
            webClient.DownloadFileAsync(new Uri(url), name_file);
        }

        private string get_encrypt_message(string name_file, string path_file)
        {
            string key = name_file.Substring(name_file.LastIndexOf("_") + 1);
            string str_size;
            byte[] message;

            using (StreamReader sr = new StreamReader(path_file))
            {
                var result = sr.ReadToEnd();
                str_size = result.Substring(result.LastIndexOf("_") + 1);
                sr.Close();
            }

            using (FileStream fs = File.OpenRead(path_file))
            {
                int size_read = (int)fs.Length - Convert.ToInt32(str_size) - str_size.Length - 1;
                message = new byte[size_read];
                fs.Seek(Convert.ToInt32(str_size), SeekOrigin.Current);
                fs.Read(message, 0, size_read);

            }
            return Encoding.Default.GetString(message);
        }
    }
}
