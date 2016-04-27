using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using c_labs.common;
namespace c_labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            id.Text = Convert.ToString(1);


            select.DataSource = Builder.selectBuilder();
        }


        private void readButton_Click(object sender, EventArgs e)
        {

        }
    }
}
