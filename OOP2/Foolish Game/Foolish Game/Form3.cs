using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foolish_Game
{
    public partial class cleverPage : Form
    {
        public cleverPage()
        {
            InitializeComponent();
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            var homePage = (homePage)Tag; // homepage == controls
            homePage.Show();
            Close();

        }
    }
}
