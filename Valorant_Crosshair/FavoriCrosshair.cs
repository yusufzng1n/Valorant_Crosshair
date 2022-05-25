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
    public partial class FavoriCrosshair : UserControl
    {
        public FavoriCrosshair()
        {
            InitializeComponent();
        }

        private void f6_Click(object sender, EventArgs e)
        {
            var fav6 = "0;s;1;P;o;0.446;d;1;0t;4;0l;1;0o;0;0a;1;0f;0;1b;0;S;s;0;o;0.523";
            Clipboard.SetText(fav6);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void f7_Click(object sender, EventArgs e)
        {
            var fav7 = "0;p;0;s;1;P;o;1;d;1;z;3;0b;0;1b;0;A;c;5;o;0;d;1;0t;1;0l;1;0o;0;0a;1;0f;0;1b;0;S;c;3;s;0.774;o;1";
            Clipboard.SetText(fav7);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void f8_Click(object sender, EventArgs e)
        {
            var fav8 = "0;p;0;c;1;s;1;P;c;5;h;0;m;1;0t;1;0l;4;0o;1;0a;1;0f;0;1t;3;1o;2;1a;1;1m;0;1f;0;A;h;0;d;1;0t;1;0l;1;0o;0;0a;1;0f;0;1b;0;S;s;0.664";
            Clipboard.SetText(fav8);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void f9_Click(object sender, EventArgs e)
        {
            var fav9 = "0;s;1;P;h;0;0t;4;0l;1;0o;2;0a;1;0f;0;1b;0";
            Clipboard.SetText(fav9);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void f10_Click(object sender, EventArgs e)
        {
            var fav10 = "0;s;1;P;h;0;0t;10;0l;1;0o;1;0a;1;0f;0;1b;0";
            Clipboard.SetText(fav10);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void f1_Click(object sender, EventArgs e)
        {
            var cartı1 = "0;p;0;s;1;P;h;0;0l;4;0o;2;0a;1;0f;0;1b;0;A;h;0;d;1;f;0;s;0;0t;1;0l;1;0o;0;0a;1;0f;0;1b;0;S;c;2;s;0.664;o;0.805";
            Clipboard.SetText(cartı1);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void f2_Click(object sender, EventArgs e)
        {
            var cartı2 = "0;p;0;s;1;P;h;0;0l;4;0o;0;0a;1;0f;0;1b;0;A;h;0;d;1;f;0;s;0;0t;1;0l;1;0o;0;0a;1;0f;0;1b;0;S;c;3;s;0.689";
            Clipboard.SetText(cartı2);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void f3_Click(object sender, EventArgs e)
        {
            var cartı3 = "0;p;0;c;1;s;1;P;c;5;h;0;m;1;0t;1;0l;4;0o;1;0a;1;0f;0;1t;3;1o;2;1a;1;1m;0;1f;0;A;h;0;d;1;0t;1;0l;1;0o;0;0a;1;0f;0;1b;0;S;s;0.664";
            Clipboard.SetText(cartı3);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void f_Click(object sender, EventArgs e)
        {
            var cartı4 = "0;p;0;s;1;P;o;1;0t;1;0l;4;0o;0;0a;1;0f;0;1b;0;A;h;0;d;1;0l;1;0o;1;0a;1;0f;0;1b;0;S;c;2;s;0.664;o;1";
            Clipboard.SetText(cartı4);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void f5_Click(object sender, EventArgs e)
        {
            var cartı5 = "0;p;0;s;1;P;o;1;0l;5;0o;4;0a;0.103;0f;0;1b;0;A;h;0;d;1;0t;1;0l;1;0o;0;0a;1;0f;0;1b;0;S;c;2;s;0.664;o;0.805";
            Clipboard.SetText(cartı5);
            MessageBox.Show("Nişangahınız Kopyalandı. ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
