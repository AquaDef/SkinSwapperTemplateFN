namespace Aqua_Swapper
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemTXT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LOG = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.REVERT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.swapped_img = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swapped_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.minBTN);
            this.panel2.Controls.Add(this.itemTXT);
            this.panel2.Controls.Add(this.bunifuImageButton3);
            this.panel2.Controls.Add(this.closeBTN);
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 50);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PosChanger);
            // 
            // itemTXT
            // 
            this.itemTXT.AutoSize = true;
            this.itemTXT.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTXT.Location = new System.Drawing.Point(8, 15);
            this.itemTXT.Name = "itemTXT";
            this.itemTXT.Size = new System.Drawing.Size(197, 23);
            this.itemTXT.TabIndex = 3;
            this.itemTXT.Text = "Recon Expert blah blah blah";
            this.itemTXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PosChanger);
            // 
            // LOG
            // 
            this.LOG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LOG.Enabled = false;
            this.LOG.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LOG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LOG.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LOG.HintText = "";
            this.LOG.isPassword = false;
            this.LOG.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.LOG.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LOG.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.LOG.LineThickness = 3;
            this.LOG.Location = new System.Drawing.Point(12, 312);
            this.LOG.Margin = new System.Windows.Forms.Padding(4);
            this.LOG.Name = "LOG";
            this.LOG.Size = new System.Drawing.Size(259, 44);
            this.LOG.TabIndex = 7;
            this.LOG.Text = "[LOG]";
            this.LOG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "CONVERT ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 271);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(123, 34);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "CONVERT ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // REVERT
            // 
            this.REVERT.Activecolor = System.Drawing.Color.Brown;
            this.REVERT.BackColor = System.Drawing.Color.Brown;
            this.REVERT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.REVERT.BorderRadius = 0;
            this.REVERT.ButtonText = "REVERT ";
            this.REVERT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.REVERT.DisabledColor = System.Drawing.Color.Gray;
            this.REVERT.Iconcolor = System.Drawing.Color.Transparent;
            this.REVERT.Iconimage = ((System.Drawing.Image)(resources.GetObject("REVERT.Iconimage")));
            this.REVERT.Iconimage_right = null;
            this.REVERT.Iconimage_right_Selected = null;
            this.REVERT.Iconimage_Selected = null;
            this.REVERT.IconMarginLeft = 0;
            this.REVERT.IconMarginRight = 0;
            this.REVERT.IconRightVisible = true;
            this.REVERT.IconRightZoom = 0D;
            this.REVERT.IconVisible = false;
            this.REVERT.IconZoom = 90D;
            this.REVERT.IsTab = false;
            this.REVERT.Location = new System.Drawing.Point(148, 271);
            this.REVERT.Name = "REVERT";
            this.REVERT.Normalcolor = System.Drawing.Color.Brown;
            this.REVERT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.REVERT.OnHoverTextColor = System.Drawing.Color.White;
            this.REVERT.selected = false;
            this.REVERT.Size = new System.Drawing.Size(123, 34);
            this.REVERT.TabIndex = 5;
            this.REVERT.Text = "REVERT ";
            this.REVERT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.REVERT.Textcolor = System.Drawing.Color.White;
            this.REVERT.TextFont = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REVERT.Click += new System.EventHandler(this.REVERT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // minBTN
            // 
            this.minBTN.BackColor = System.Drawing.Color.Transparent;
            this.minBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minBTN.Image = global::Aqua_Swapper.Properties.Resources.minimize;
            this.minBTN.ImageActive = null;
            this.minBTN.Location = new System.Drawing.Point(204, 7);
            this.minBTN.Name = "minBTN";
            this.minBTN.Size = new System.Drawing.Size(34, 36);
            this.minBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minBTN.TabIndex = 9;
            this.minBTN.TabStop = false;
            this.minBTN.Zoom = 0;
            this.minBTN.Click += new System.EventHandler(this.BunifuImageButton3_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton3.Image = global::Aqua_Swapper.Properties.Resources.minimize;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(604, 7);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(34, 36);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 7;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 0;
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.Transparent;
            this.closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBTN.Image = global::Aqua_Swapper.Properties.Resources.close;
            this.closeBTN.ImageActive = null;
            this.closeBTN.Location = new System.Drawing.Point(237, 7);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(34, 36);
            this.closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBTN.TabIndex = 8;
            this.closeBTN.TabStop = false;
            this.closeBTN.Zoom = 0;
            this.closeBTN.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::Aqua_Swapper.Properties.Resources.close;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(637, 7);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(34, 36);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 0;
            // 
            // swapped_img
            // 
            this.swapped_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.swapped_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.swapped_img.Location = new System.Drawing.Point(171, 56);
            this.swapped_img.Name = "swapped_img";
            this.swapped_img.Size = new System.Drawing.Size(100, 87);
            this.swapped_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.swapped_img.TabIndex = 8;
            this.swapped_img.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 363);
            this.Controls.Add(this.swapped_img);
            this.Controls.Add(this.LOG);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.REVERT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Swapping ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PosChanger);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swapped_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton minBTN;
        private Bunifu.Framework.UI.BunifuImageButton closeBTN;
        private Bunifu.Framework.UI.BunifuCustomLabel itemTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton REVERT;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LOG;
        private System.Windows.Forms.PictureBox swapped_img;
    }
}