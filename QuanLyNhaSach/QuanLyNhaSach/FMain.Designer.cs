
namespace QuanLyNhaSach
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLyNhanVien,
            this.QuanLySach,
            this.ThongKe,
            this.dangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(878, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // QuanLyNhanVien
            // 
            this.QuanLyNhanVien.Name = "QuanLyNhanVien";
            this.QuanLyNhanVien.Size = new System.Drawing.Size(238, 36);
            this.QuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // QuanLySach
            // 
            this.QuanLySach.Name = "QuanLySach";
            this.QuanLySach.Size = new System.Drawing.Size(176, 36);
            this.QuanLySach.Text = "Quản lý sách";
            // 
            // ThongKe
            // 
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Size = new System.Drawing.Size(261, 36);
            this.ThongKe.Text = "Thống kê doanh thu";
            // 
            // dangXuat
            // 
            this.dangXuat.Name = "dangXuat";
            this.dangXuat.Size = new System.Drawing.Size(149, 36);
            this.dangXuat.Text = "Đăng xuất";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 444);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà sách";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem QuanLySach;
        private System.Windows.Forms.ToolStripMenuItem ThongKe;
        private System.Windows.Forms.ToolStripMenuItem dangXuat;
    }
}