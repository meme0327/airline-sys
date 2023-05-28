using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sparkling_Skies
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form6 form = new Form6();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book form = new Book();
            form.Show();
        }
    }
}
