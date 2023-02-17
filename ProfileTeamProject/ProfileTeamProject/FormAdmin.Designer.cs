
namespace ProfileTeamProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLCN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTKHD = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thốngKêSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.MenuQuanLy,
            this.menuSP,
            this.menuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1402, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangXuat,
            this.MenuThoat});
            this.menuHeThong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(107, 27);
            this.menuHeThong.Text = "Hệ Thống";
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("menuDangXuat.Image")));
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(224, 28);
            this.menuDangXuat.Text = "Đăng Xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // MenuThoat
            // 
            this.MenuThoat.Image = ((System.Drawing.Image)(resources.GetObject("MenuThoat.Image")));
            this.MenuThoat.Name = "MenuThoat";
            this.MenuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuThoat.Size = new System.Drawing.Size(224, 28);
            this.MenuThoat.Text = "Thoát";
            this.MenuThoat.Click += new System.EventHandler(this.MenuThoat_Click);
            // 
            // MenuQuanLy
            // 
            this.MenuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLNV,
            this.menuQLKH,
            this.menuQLCN});
            this.MenuQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MenuQuanLy.Name = "MenuQuanLy";
            this.MenuQuanLy.Size = new System.Drawing.Size(98, 27);
            this.MenuQuanLy.Text = "Quản Lý";
            // 
            // menuQLNV
            // 
            this.menuQLNV.Name = "menuQLNV";
            this.menuQLNV.Size = new System.Drawing.Size(258, 28);
            this.menuQLNV.Text = "Nhân Viên";
            this.menuQLNV.Click += new System.EventHandler(this.menuQLNV_Click);
            // 
            // menuQLKH
            // 
            this.menuQLKH.Name = "menuQLKH";
            this.menuQLKH.Size = new System.Drawing.Size(258, 28);
            this.menuQLKH.Text = "Khách Hàng";
            this.menuQLKH.Click += new System.EventHandler(this.menuQLKH_Click);
            // 
            // menuQLCN
            // 
            this.menuQLCN.Name = "menuQLCN";
            this.menuQLCN.Size = new System.Drawing.Size(258, 28);
            this.menuQLCN.Text = "Thông Tin Cá Nhân";
            this.menuQLCN.Click += new System.EventHandler(this.menuQLCN_Click);
            // 
            // menuSP
            // 
            this.menuSP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKho,
            this.menuTK});
            this.menuSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuSP.Name = "menuSP";
            this.menuSP.Size = new System.Drawing.Size(107, 27);
            this.menuSP.Text = "Sản Phẩm";
            // 
            // menuKho
            // 
            this.menuKho.Name = "menuKho";
            this.menuKho.Size = new System.Drawing.Size(224, 28);
            this.menuKho.Text = "Kho Hàng";
            // 
            // menuTK
            // 
            this.menuTK.Name = "menuTK";
            this.menuTK.Size = new System.Drawing.Size(224, 28);
            this.menuTK.Text = "Thống Kê";
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTKHD,
            this.thốngKêSảnPhẩmToolStripMenuItem});
            this.menuBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(96, 27);
            this.menuBaoCao.Text = "Báo Cáo";
            // 
            // menuTKHD
            // 
            this.menuTKHD.Name = "menuTKHD";
            this.menuTKHD.Size = new System.Drawing.Size(263, 28);
            this.menuTKHD.Text = "Thống Kê Hóa Đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1402, 155);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = "ProfileTeam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(713, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(559, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Xin Chào,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(300, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(796, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chương Trình Quản Lý Bán Hàng Linh Kiện Máy Tính";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProfileTeamProject.Properties.Resources.linhkien1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1402, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // thốngKêSảnPhẩmToolStripMenuItem
            // 
            this.thốngKêSảnPhẩmToolStripMenuItem.Name = "thốngKêSảnPhẩmToolStripMenuItem";
            this.thốngKêSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.thốngKêSảnPhẩmToolStripMenuItem.Text = "Thống Kê Sản Phẩm";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Chương Trình Bán Hàng Linh Kiện Máy Tính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem MenuThoat;
        private System.Windows.Forms.ToolStripMenuItem MenuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuQLNV;
        private System.Windows.Forms.ToolStripMenuItem menuQLKH;
        private System.Windows.Forms.ToolStripMenuItem menuQLCN;
        private System.Windows.Forms.ToolStripMenuItem menuSP;
        private System.Windows.Forms.ToolStripMenuItem menuKho;
        private System.Windows.Forms.ToolStripMenuItem menuTK;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuTKHD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSảnPhẩmToolStripMenuItem;
    }
}