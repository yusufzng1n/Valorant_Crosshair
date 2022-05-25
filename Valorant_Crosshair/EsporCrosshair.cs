using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valorant_Crosshair
{
    public partial class EsporCrosshair : UserControl
    {
        public EsporCrosshair()
        {
            InitializeComponent();
        }

        private void e1_Click(object sender, EventArgs e)
        {
            var e1 = "0;P;c;1;h;0;0t;1;0l;2;0o;1;0a;1;0f;0;1b;0";
            Clipboard.SetText(e1);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void e2_Click(object sender, EventArgs e)
        {
            var e2 = "0;s;1;P;c;1;o;1;d;1;z;4;0t;1;0l;1;0o;1;0a;1;0f;0;1b;0";
            Clipboard.SetText(e2);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void e3_Click(object sender, EventArgs e)
        {
            var e3 = "0;s;1;P;o;1;d;1;f;0;s;0;0t;0;0l;1;0o;0;0a;1;0f;0;1t;0;1l;1;1o;0;1a;1;1m;0;1f;0;S;o;1";
            Clipboard.SetText(e3);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void e4_Click(object sender, EventArgs e)
        {
            var e4 = "0;s;1;P;c;5;h;0;m;1;0l;4;0o;2;0a;1;0f;0;1b;0;S;c;4;o;1";
            Clipboard.SetText(e4);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void e5_Click(object sender, EventArgs e)
        {
            var e5 = "0;P;h;0;0l;5;0o;0;0a;1;0f;0;1b;0";
            Clipboard.SetText(e5);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void e6_Click(object sender, EventArgs e)
        {
            var e6 = "0;s;1;P;c;3;o;0.909;0t;1;0l;3;0o;2;0a;1;0f;0;1t;0;1l;0;1o;1;1a;1;1m;0;1f;0";
            Clipboard.SetText(e6);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void e7_Click(object sender, EventArgs e)
        {
            var e7 = "0;P;c;1;h;0;0t;1;0l;2;0o;1;0a;1;0f;0;1b;0";//mito valoda boş
            Clipboard.SetText(e7);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void e8_Click(object sender, EventArgs e)
        {
            var e8 = "0;P;c;4;o;1;d;1;z;3;0b;0;1b;0";
            Clipboard.SetText(e8);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void e9_Click(object sender, EventArgs e)
        {
            var e9 = "0;P;o;1;0t;1;0l;2;0a;1;0f;0;1b;0";
            Clipboard.SetText(e9);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void e10_Click(object sender, EventArgs e)
        {
            var e10 = "0;P;c;1;h;0;0t;1;0l;5;0o;2;0a;1;0f;0;1b;0";
            Clipboard.SetText(e10);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
