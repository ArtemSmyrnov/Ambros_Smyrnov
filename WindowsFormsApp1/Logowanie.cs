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

namespace WindowsFormsApp1
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }
        static string connectionString = @"Data Source=DESKTOP-TPMMV6Q;Initial Catalog=Projekt1;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       
      
        private void button1_Click(object sender, EventArgs e) //log in
        {
            
            int password = 1111;   //password
            if (textBox1.Text != "")
            {
                int haslo = Convert.ToInt32(textBox1.Text);


                if (password == haslo)
                {

                    MessageBox.Show("Zalogowany");
                    _2kartka newForm = new _2kartka();
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nie dobre haslo");
                }
            }
            else
            {
                MessageBox.Show("Nie dobre haslo");
            }
        }
    }
}
