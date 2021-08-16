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

namespace CakeFactory
{
    public partial class frmtoken : Form

    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QPJ0806\\SQLEXPRESS;Initial Catalog=CakeShop;Integrated Security=True");

        double amttot, amtadv, amtnet,amtcash;

        public frmtoken()

        {
            InitializeComponent();
          
        }

        private void frmbill_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'cakeShopDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cakeShopDataSet1.customer);
            // TODO: This line of code loads data into the 'cakeShopDataSet1.olist' table. You can move, or remove it, as needed.
            this.olistTableAdapter.Fill(this.cakeShopDataSet1.olist);

        }

        private void txtordernumber_TextChanged(object sender, EventArgs e)
        {
          /*  Dbconnection obj = new Dbconnection();
            obj.Conn.ConnectionString = obj.Sqlds;
            obj.Conn.Open();

            string InsertData = "insert into customer values('" + txtcusID.Text + "','" + txtnic.Text + "','" + txtname.Text + "','" + txtcontactnumber.Text + "')";
            obj.Cmd.Connection = obj.Conn;
            obj.Cmd.CommandText = InsertData;
            obj.Cmd.ExecuteNonQuery();
            MessageBox.Show("save succeed!");*/
        }

        private void lbllog_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {

            try
            {
                Dbconnection obj = new Dbconnection();
                obj.Conn.ConnectionString = obj.Sqlds;
                obj.Conn.Open();

                string InsertData = "insert into olist values('" + txtadvanced.Text + "','" + txtcash.Text + "','" + txtnet.Text + "','" + txtbalance.Text + "')";
                obj.Cmd.Connection = obj.Conn;
                obj.Cmd.CommandText = InsertData;
                obj.Cmd.ExecuteNonQuery();
                MessageBox.Show("save succeed!");
            }
            catch(Exception)
            {
                MessageBox.Show("Error While Saving!");
            }
            finally
            {
                
            }
        }

        private void dtpbill_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtbalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnet_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }
        private void txttotal_Load(object sender, EventArgs e )
        {                     
            amttot = Convert.ToDouble(txttotal.Text);
            amtadv = Convert.ToDouble(txtadvanced.Text);
            amtnet = Convert.ToDouble(txtnet.Text);
            amtnet = amttot - amtadv;
        }
    }
}
      