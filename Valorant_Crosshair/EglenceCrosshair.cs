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
    public partial class EglenceCrosshair : UserControl
    {
        public EglenceCrosshair()
        {
            InitializeComponent();
        }

        private void g1_Click(object sender, EventArgs e)
        {
            var e1 = "0;s;1;P;o;1;0t;8;0l;2;0o;4;0a;1;0f;0;1o;5;1a;1;1m;0;1f;0";
            Clipboard.SetText(e1);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void g2_Click(object sender, EventArgs e)
        {
            var e2 = "0;s;1;P;c;5;h;0;0t;1;0l;4;0o;1;0a;1;0f;0;1t;5;1l;1;1o;2;1a;1;1m;0;1f;0";
            Clipboard.SetText(e2);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void g3_Click(object sender, EventArgs e)
        {
            var e3 = "0;s;1;P;c;5;h;0;0t;1;0l;3;0a;1;0f;0;1t;3;1o;1;1a;1;1m;0;1f;0";
            Clipboard.SetText(e3);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void g4_Click(object sender, EventArgs e)
        {
            var e4 = "0;s;1;P;c;5;h;0;0t;8;0l;1;0o;4;0a;1;0f;0;1t;10;1l;1;1o;1;1a;1;1m;0;1f;0";
            Clipboard.SetText(e4);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void g5_Click(object sender, EventArgs e)
        {
            var e5 = "0;s;1;P;c;5;h;0;0t;7;0l;1;0a;1;0f;0;1t;3;1l;1;1o;1;1a;1;1m;0;1f;0";
            Clipboard.SetText(e5);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void g6_Click(object sender, EventArgs e)
        {
            var e6 = "0;s;1;P;c;5;h;0;0t;5;0l;1;0o;5;0a;1;0f;0;1t;1;1l;3;1o;2;1a;1;1m;0;1f;0";
            Clipboard.SetText(e6);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void g7_Click(object sender, EventArgs e)
        {
            var e7 = "0;s;1;P;c;5;h;0;0t;4;0l;2;0o;1;0a;1;0f;0;1b;0";
            Clipboard.SetText(e7);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void g8_Click(object sender, EventArgs e)
        {
            var e8 = "0;s;1;P;c;5;h;0;0l;2;0o;1;0a;1;0f;0;1t;10;1o;2;1a;1;1m;0;1f;0";
            Clipboard.SetText(e8);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void g9_Click(object sender, EventArgs e)
        {
            var e9 = "0;s;1;P;c;5;h;0;0t;9;0l;1;0o;0;0a;1;0f;0;1t;1;1o;3;1a;1;1m;0;1f;0";
            Clipboard.SetText(e9);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void g10_Click(object sender, EventArgs e)
        {
            var e10 = "0;s;1;P;c;5;h;0;d;1;0l;3;0o;2;0a;1;0f;0;1t;6;1l;1;1o;3;1a;1;1m;0;1f;0";
            Clipboard.SetText(e10);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
