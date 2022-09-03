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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void homePage_Load(object sender, EventArgs e)
        {
                
        }

        private void foolPath_Click(object sender, EventArgs e)
        {

            foolPage fp = new foolPage();
            fp.Tag = this;
            fp.Show(this);
            Hide();
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {   
            if(keyData == Keys.Tab)
            {
                cleverPage cp = new cleverPage();
                cp.Tag = this;
                cp.Show(this);
                Hide();

            }else if(keyData == Keys.Escape)
            {
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

         private void homePage_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void cleverPath_Click(object sender, EventArgs e)
        {

        } 

        private void cleverPath_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void cleverPath_MouseEnter(object sender, EventArgs e)
        {
            Random x = new Random();
            Point pt = new Point(
                    int.Parse(x.Next(300).ToString()),
                    int.Parse(x.Next(300).ToString())
                );
            cleverPath.Location = pt;
        }
    }
}
