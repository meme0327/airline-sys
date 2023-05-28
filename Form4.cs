using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }
         private void button1_Click(object sender, EventArgs e)

        { 
            DataTable dt = bl.login.tologin(int.Parse(textid.Text), textname.Text, textpass.Text);
            if (dt.Rows.Count > 0)
            {
                
                MessageBox.Show(" login Successful , Welcome  " );
                Program.staff_name = dt.Rows[0]["first_name"].ToString() + " " + dt.Rows[0]["last_name"].ToString();


                Program.isLogin = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Login Failed,please Enter Info again ", "Fail");
                Program.isLogin = false;
            }




         }
        //  
        //       MessageBox.Show("   login Successful  ");
    }

}


   




