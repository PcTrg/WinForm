using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Midterm_Paint.Properties;

namespace WinForm_Midterm_Paint
{
    public partial class Form1 : Form
    {
        private bool isCollapsed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                //button1.Image = Resources.Collapse_Arrow_20px;
                panel1.Height = panel1.MaximumSize.Height;

                isCollapsed = false;
            }
            else
            {
                //button1.Image = Resources.Expand_Arrow_20px;
                panel1.Height = panel1.MinimumSize.Height;

                isCollapsed = true;
            }
        }
    }
}
