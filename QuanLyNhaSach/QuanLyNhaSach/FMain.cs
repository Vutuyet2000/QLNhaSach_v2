using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (menuStrip1.Items[0].Selected)
            {
                QuanLyNhanVien f1 = new QuanLyNhanVien();
                this.Hide();
                f1.ShowDialog();
                this.Show();
            }
            else if (menuStrip1.Items[1].Selected)
            {
                QuanLySach f2 = new QuanLySach();
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if (menuStrip1.Items[2].Selected)
            {
                FHoaDon f3 = new FHoaDon();
                this.Hide();
                f3.ShowDialog();
                this.Show();
            }
            else if (menuStrip1.Items[3].Selected)
                this.Close();
        }
    }
}
