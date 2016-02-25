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
    public partial class UserStoryMain : Form
    {
        public UserStoryMain()
        {
            InitializeComponent();
        }

        private void picturBox_Click(object sender, EventArgs e)
        {
            picturBox.BackgroundImage = imageListUserStorys.Images[0];
        }

        private void UserStoryMain_Load(object sender, EventArgs e)
        {
            picturBox.BackgroundImage = imageListUserStorys.Images[0];
        }
    }
}
