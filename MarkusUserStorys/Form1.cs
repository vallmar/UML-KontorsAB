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
        int selecteIndexImage;
        public UserStoryMain()
        {
            InitializeComponent();
        }

        private void UserStoryMain_Load(object sender, EventArgs e)
        {
            picturBox.BackgroundImage = Image.FromFile(@"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\UML KontorsAB\MarkusUserStorys\ADMINUSER.png");
            selecteIndexImage = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            picturBox.BackgroundImage = Image.FromFile(@"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\UML KontorsAB\MarkusUserStorys\ADMINUSER.png");
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            picturBox.BackgroundImage = Image.FromFile(@"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\UML KontorsAB\MarkusUserStorys\USERUSERSTORY.png");
        }
    }
}
