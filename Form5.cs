using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Sparkling_Skies
{
    public partial class Book : Form
    {
       
        public Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Done");
            bl.book.tobook(comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox5.Text, int.Parse(textBox1.Text));
        }

    }
}
