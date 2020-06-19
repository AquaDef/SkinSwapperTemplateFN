using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aqua_Swapper
{
    public partial class Form2 : Form
    {
        static string item_name;
        static Image image,swappedimage;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public static string Subject, qTitle, qBook, qAuthor, qPage, qPart, qNotes, qSubject, qID;
        private byte[] ReconExpert1, ReconExpert2;
        private void SetLog(string log)
        {
            LOG.Text = "[LOG] "+log;
        }
        private void Swap(string item,bool convert=true) {
            switch (item){
                case "Recon Expert":
                    byte[] ReconExpert1 = { 099, 105, 100, 095, 048, 049, 054, 095, 097, 116, 104, 101, 110, 097, 095, 099, 111, 109, 109, 097, 110, 100, 111, 095, 102 };
                    byte[] ReconExpert2 = { 099, 105, 100, 095, 048, 050, 050, 095, 097, 116, 104, 101, 110, 097, 095, 099, 111, 109, 109, 097, 110, 100, 111, 095, 102 };
                    
                    if (convert) {
                        SetLog("Converting...");
                        ReplaceBytes("pakchunk0-WindowsClient.pak", 366061968L, ReconExpert1);
                        ReplaceBytes("pakchunk0-WindowsClient.pak", 366058708L, ReconExpert2);
                    }
                    else
                    {
                        SetLog("Reverting...");
                        ReplaceBytes("pakchunk0-WindowsClient.pak", 366058708L, ReconExpert1);
                        ReplaceBytes("pakchunk0-WindowsClient.pak", 366061968L, ReconExpert2);
                    }
                    break;
                case "Codename ELF":
                    byte[] CodenameELF1 = { 067, 073, 068, 095, 048, 053, 049, 095, 065, 116, 104, 101, 110, 097, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 077, 095, 072, 111, 108, 105, 100, 097, 121, 069, 108, 102 };
                    byte[] CodenameELF2 = { 067, 073, 068, 095, 049, 054, 053, 095, 065, 116, 104, 101, 110, 097, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 077, 095, 068, 097, 114, 107, 086, 105, 107, 105, 110, 103 };

                    if (convert)
                    {
                        SetLog("Converting...");
                        ReplaceBytes("pakchunk0-WindowsClient.pak", 366275668L, CodenameELF1);
                        ReplaceBytes("pakchunk0-WindowsClient.pak", 366098453L, CodenameELF2);
                    }
                    else
                    {
                        SetLog("Reverting...");
                        ReplaceBytes("pakchunk0-WindowsClient.pak", 366098453L, CodenameELF1);
                        ReplaceBytes("pakchunk0-WindowsClient.pak", 366275668L, CodenameELF2);
                    }
                    break;

            }
        }

        private void REVERT_Click(object sender, EventArgs e)
        {
            Swap(Form1.item, false);
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Swap(Form1.item);
        }


        public static void ReplaceBytes(string pak, long offset, byte[] bytes)
        {
            try { 
                BinaryWriter binarywriter = new BinaryWriter(File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
                binarywriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                binarywriter.Write(bytes);
                binarywriter.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form2()
        {
            InitializeComponent();

        }
        private void PosChanger(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            item_name = Form1.item.ToUpper();
            itemTXT.Text = item_name;
            image = Form1.resource;
            pictureBox1.Image = image;
            swappedimage = Form1.resource2;
            swapped_img.Image = swappedimage;
            this.Text = item_name + " - Menu";
        }
    }
}
