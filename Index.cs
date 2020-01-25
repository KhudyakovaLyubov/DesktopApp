using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace FileEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SFD(string text)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, text);
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = null;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            textBoxFile.Text = openFileDialog1.FileName;
        }

        public static string Encrypt(string text, string key)
        {
            if (key.Length == 0)
                throw new KeyException();
            if (text.Length == 0)
                throw new TextException();
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();
            byte[] keyToByte = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            byte[] textToByte = Encoding.UTF8.GetBytes(text);
            provider.Key = keyToByte;
            provider.Mode = CipherMode.ECB;
            string encrypted = Convert.ToBase64String(provider.CreateEncryptor().TransformFinalBlock(textToByte, 0, textToByte.Length));
            return encrypted;
        }

        public static string Decrypt(string encryptedText, string key)
        {
            if (key.Length == 0)
                throw new KeyException();
            if (encryptedText.Length == 0)
                throw new TextException();
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();
            byte[] keyToByte = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            byte[] textToByte = Convert.FromBase64String(encryptedText);
            provider.Key = keyToByte;
            provider.Mode = CipherMode.ECB;
            string decryptText = Encoding.UTF8.GetString(provider.CreateDecryptor().TransformFinalBlock(textToByte, 0, textToByte.Length));
            return decryptText;
        }

        public void EncryptFile()
        {
            try
            {
                try
                {
                    string s = File.ReadAllText(textBoxFile.Text);
                    string FileText = Encrypt(s, textBoxKey.Text);
                    SFD(FileText);
                    timer1.Start();
                }
                catch (KeyException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(TextException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DecryptFile()
        {
            try
            {
                try
                {
                    string s = File.ReadAllText(textBoxFile.Text);
                    string FileText = Decrypt(s, textBoxKey.Text);
                    SFD(FileText);
                    timer1.Start();
                }
                catch (KeyException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (TextException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            if (radioButtonEncrypt.Checked == true)
            {
                EncryptFile();
            }
            else
            {
                DecryptFile();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (textBoxFile.Text == "")
            {
                this.Close();
            }
            else
            {
                timer1.Stop();
                progressBar1.Value = 0;
                if (radioButtonEncrypt.Checked == true)
                {
                    DecryptFile();
                }
                else
                {
                    EncryptFile();
                }
            }

        }
    }

    [Serializable]
    public class KeyException:Exception
    {
        public KeyException() : base("Поле Ключ пустое. Введите ключ.") { }
    }

    [Serializable]
    public class TextException : Exception
    {
        public TextException() : base("Файл не найден. Добавьте файл.") { }
    }
}
