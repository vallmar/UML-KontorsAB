using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkusUserStorys
{
    public partial class UMLEML : Form
    {
        List<PictureBox> pb = new List<PictureBox>();
        public UMLEML()
        {
            InitializeComponent();
            pb.Add(pb3);
            pb.Add(pb4);
            pb.Add(pb5);
            pb.Add(pb9);
            pb.Add(pb12);
            pb.Add(pb8);
            pb.Add(pb13);
            pb.Add(pb14);
            pb.Add(pb2);
            pb.Add(pb1);
            pb.Add(pb7);
            pb.Add(pb11);
            pb.Add(pb6);
            pb.Add(pb10);
            pb.Add(pb15);
            pb16.Hide();
            foreach (var p in pb)
            {
                p.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pb16.Hide();
            pb16.Refresh();
            foreach (var p in pb)
            {
                
                p.Show();
                p.Refresh();
                Thread.Sleep(400);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var p in pb)
            {
                p.Hide();
            }
            pb16.Show();
        }

        //private void UMLEML_Load(object sender, EventArgs e)
        //{
        //    foreach (var p in pb)
        //    {
        //        p.Show();
        //        Thread.Sleep(200);
        //    }

        //}
    }
}
