using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkusUserStorys
{
    public partial class Wireframes : Form
    {
        public Wireframes()
        {
            InitializeComponent();
        }

        private void btnUserDesktop_Click(object sender, EventArgs e)
        {
            UserDesktop userDesktop = new UserDesktop();
            userDesktop.ShowDialog();
        }

        private void btnUserMobile_Click(object sender, EventArgs e)
        {
            UserMobile userMobile = new UserMobile();
            userMobile.ShowDialog();
        }

        private void btnAdminDesktop_Click(object sender, EventArgs e)
        {
            AdminDesktop adminDesktop = new AdminDesktop();
            adminDesktop.ShowDialog();
        }
    }
}
