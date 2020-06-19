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
    public partial class Form1 : Form
    {
        Form2 form2;
        public static string item;
        public static Image resource, resource2;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
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
        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            skin_panel.BringToFront();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void ReconExpert_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            item = "Recon Expert";
            resource = Properties.Resources.recons;
            form2.Show();
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            home_panel.BringToFront();
        }

        private void BunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
        private bool IsItemID(string item)
        {
            if (item.StartsWith("CID_") || item.StartsWith("EID_") || item.StartsWith("PID_") || item.StartsWith("BID_")) { } else { return false; }
            return true;
        }
        public void ReplaceStrings(string pak, string item1, string item2)
        {
            try
            {
                BinaryWriter binarywriter = new BinaryWriter(File.Open(pak, FileMode.Open, FileAccess.ReadWrite));

                byte[] Item1BYTES = System.Text.Encoding.ASCII.GetBytes(item1);
                byte[] Item2BYTES = System.Text.Encoding.ASCII.GetBytes(item2);
                long Item1_offset = Boyer_Moore.IndexOf(binarywriter.BaseStream, Item1BYTES);
                long Item2_offset = Boyer_Moore.IndexOf(binarywriter.BaseStream, Item2BYTES);
                binarywriter.BaseStream.Seek(Item1_offset, SeekOrigin.Begin);
                binarywriter.Write(Item1BYTES);
                binarywriter.BaseStream.Seek(Item2_offset, SeekOrigin.Begin);
                binarywriter.Write(Item2BYTES);
                binarywriter.Close();
                SetLog("Finished...");
                MessageBox.Show("Item swapped successfully!", "Aqua Swapper", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void SetLog(string log)
        {
            LOG.Text = "[LOG] " + log;
        }
        private void Customitem(bool flag=true)
        {
            string Item1 = CustomItem1.Text, Item2=CustomItem2.Text;
            if(IsItemID(Item1) && IsItemID(Item2))
            {
                if (flag)
                {
                    SetLog("Converting...");
                    ReplaceStrings("pakchunk0-WindowsClient.pak", Item1,Item2);
                }
                else
                {
                    ReplaceStrings("pakchunk0-WindowsClient.pak", Item2, Item1);
                    SetLog("Reverting...");
                }
            }
            else
            {
                MessageBox.Show("Please only swap Item IDs", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Customitem();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1gVDgnzNyMCafIWa-dBO3mgNUHmHzgA9O5sWbfQy2Yfg/edit#gid=0");
        }

        private void REVERT_Click(object sender, EventArgs e)
        {
            Customitem(false);
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            customitems_panel.BringToFront();
        }

        private void CodenameELF_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            item = "Codename ELF";
            resource = Properties.Resources.CodenameELF;
            resource2 = Properties.Resources.Ragnarok;
            form2.Show();
        }
    }
}
