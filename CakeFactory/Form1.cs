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
         public partial class txttemp : Form
   {
             string cid;
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QPJ0806\\SQLEXPRESS;Initial Catalog=CakeShop;Integrated Security=True");
        
        public txttemp()
        {
            InitializeComponent();
        }

        private void txtcidlogin_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void lblsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmsignup frmsignup  = new frmsignup();
            frmsignup.Show();

        }

        private void lblorderlist_Click(object sender, EventArgs e)
        {
            frmorderlist frmorderlist = new frmorderlist();
            string pw = txtpw.Text;
            if (pw == "CAKEF")
            {
                frmorderlist.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpw.Clear();
            
        }

        private void operationClick(object sender, EventArgs e)
        {
            frmsignup frmsignup = new frmsignup();
            frmsignup.Show();
            this.Hide();
            
        }
        private void lblbill_Click(object sender, EventArgs e)
        {
            string pw = txtpw.Text;
            if (pw == "CAKEF")
            {
                frmtoken frmtoken = new frmtoken();
                frmtoken.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtpw.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string pw = txtpw.Text;
            if (pw == "CAKEF")
            {
                frmtoken frmtoken = new frmtoken();
                frmtoken.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtpw.Clear();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try { 
            Dbconnection obj = new Dbconnection();
            obj.Conn.ConnectionString = obj.Sqlds;
            obj.DSet.Reset();

            string SelectData = "SELECT * FROM customer WHERE customerID='" + txtcidlogl.Text + "'";
            obj.Sqlda = new System.Data.SqlClient.SqlDataAdapter(SelectData,obj.Conn);
            obj.Sqlda.Fill(obj.DSet,"details");
            if (obj.DSet.Tables["details"].Rows[0][1].ToString() !=null)
            {
                order order = new order();
                order.Show();
                this.Hide();
                cid = obj.DSet.Tables["details"].Rows[0][1].ToString();
                
            }
            else if (obj.DSet.Tables["details"].Rows[0][8].ToString() != null)
            {
                MessageBox.Show("Please Check Your CUSTOER ID or You are not Registered");
            }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check Your CUSTOER ID or You are not Registered");
            }            
        }

            

        private void txtordernumber_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            order order = new order();
            order.Show();
            this.Hide();
        }
    }
}
