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

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection=new SqlConnection(@"Data Source=FUCKERYAGO;Initial Catalog=OilTrackingAutomation;Integrated Security=True");

        private void OilTypelbl_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAll();
        }

        private void ListAll()
        {
            //Unleaded 95
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from oilTable where oilType='V/Max Unleaded 95'", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblUnleaded95.Text = dr[3].ToString();
                unleaded95.Value = int.Parse(dr[4].ToString());
                lblUnleaded95liter.Text = dr[4].ToString();
            }

            connection.Close();

            //V/MaxEuroDiesel
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select * from oilTable where oilType='V/MaxEuroDiesel'", connection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                lblMaxEuroDiesel.Text = dr2[3].ToString();
                maxEuroDiesel.Value = int.Parse(dr2[4].ToString());
                lblMaxEuroDieselLiter.Text = dr2[4].ToString();
            }

            connection.Close();

            //V/ProEuroDiesel
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select * from oilTable where oilType='V/ProEuroDiesel'", connection);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                lblProEuroDiesel.Text = dr3[3].ToString();
                proEuroDiesel.Value = int.Parse(dr3[4].ToString());
                lblProEuroDieselLiter.Text = dr3[4].ToString();
            }

            connection.Close();

            //AutoGas
            connection.Open();
            SqlCommand command4 = new SqlCommand("Select * from oilTable where oilType='PO/Autogas'", connection);
            SqlDataReader dr4 = command4.ExecuteReader();
            while (dr4.Read())
            {
                lblAutoGas.Text = dr4[3].ToString();
                autoGas.Value = int.Parse(dr4[4].ToString());
                lblAutogasLiter.Text = dr4[4].ToString();
            }

            connection.Close();
            

            connection.Open();
            SqlCommand command5=new SqlCommand("Select * from caseTable",connection);
            SqlDataReader dr5 = command5.ExecuteReader();
            while (dr5.Read())
            {
                lblCase.Text = dr5[0].ToString();
            }
            connection.Close();
        }

        private void lblMaxEuroDiesel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double unleaded95, liter, amount;
            unleaded95 = Convert.ToDouble(lblUnleaded95.Text);
            liter = Convert.ToDouble(numericUpDown1.Value);
            amount = unleaded95 * liter;
            txtUnleaded95Amount.Text = amount.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double maxeurodiesel, liter, amount;
            maxeurodiesel = Convert.ToDouble(lblMaxEuroDiesel.Text);
            liter = Convert.ToDouble(numericUpDown2.Value);
            amount = maxeurodiesel * liter;
            txtMaxEuroDieselAmount.Text = amount.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double proeurodiesel, liter, amount;
            proeurodiesel = Convert.ToDouble(lblProEuroDiesel.Text);
            liter = Convert.ToDouble(numericUpDown3.Value);
            amount = proeurodiesel * liter;
            txtProEuroDieselAmount.Text = amount.ToString();

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double autogas, liter, amount;
            autogas = Convert.ToDouble(lblAutoGas.Text);
            liter = Convert.ToDouble(numericUpDown4.Value);
            amount = autogas * liter;
            txtAutoGasAmount.Text = amount.ToString();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value!=0)
            {
                connection.Open();
                SqlCommand command=
                    new SqlCommand("insert to movementsTable(plaque,oiltype,liter,price) values(@p1,@p2,@p3,@p4)",connection);
                command.Parameters.AddWithValue("@p1", txtPlaque.Text);
                command.Parameters.AddWithValue("@p2","unleaded95");
                command.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                command.Parameters.AddWithValue("@p4", decimal.Parse(txtUnleaded95Amount.Text));
                command.ExecuteNonQuery();
                connection.Close();


                connection.Open();
                SqlCommand command2=new SqlCommand("update caseTable set quantity=quantity+@p1",connection);
                command2.Parameters.AddWithValue("@p1", decimal.Parse(txtUnleaded95Amount.Text));
                command2.ExecuteNonQuery();
                connection.Close();
                
                connection.Open();
                SqlCommand command3=new SqlCommand("update oilTable set stock=stock-@p1 where oilType'unleaded95'",connection);
                command3.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                connection.Close();
                MessageBox.Show("Sale was made !");
            }
        }
    }
}
