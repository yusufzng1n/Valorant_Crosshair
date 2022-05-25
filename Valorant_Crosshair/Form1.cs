using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Valorant_Crosshair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    return;
            }
            base.WndProc(ref m);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            favoriCrosshair1.Visible = true;
            esporCrosshair1.Visible = false;
            eglenceCrosshair1.Visible = false;
            help1.Visible = false;
        }
      
        private void guna2Button3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            favoriCrosshair1.Visible = true;
            esporCrosshair1.Visible = false;
            eglenceCrosshair1.Visible = false;
           help1.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            favoriCrosshair1.Visible = false;
            esporCrosshair1.Visible = true;
            eglenceCrosshair1.Visible = false;
           help1.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            favoriCrosshair1.Visible = false;
            esporCrosshair1.Visible = false;
            eglenceCrosshair1.Visible = true;
           help1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            favoriCrosshair1.Visible = false;
            esporCrosshair1.Visible = false;
            eglenceCrosshair1.Visible = true;
           help1.Visible = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

          
        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
    }
}
