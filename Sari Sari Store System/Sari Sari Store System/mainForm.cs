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

namespace Sari_Sari_Store_System
{
    public partial class mainForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\Sari Sari Store System\Sari Sari Store System\inventory.mdf;Integrated Security=True");
        
        
        public mainForm()
        {
            InitializeComponent();
        }

        //calls loginForm.cs
        private projInventory f1 = new projInventory();

        public mainForm(Form callingForm)
        {
            f1 = callingForm as projInventory;
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from inventorydb";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader myReader;
            da.Fill(dt);

            
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Add an item first!");
                inventoryForm invForm = new inventoryForm();
                invForm.Show();
                this.Close();
            } else
            {
                myReader = cmd.ExecuteReader();
                
                while (myReader.Read())
                {
                    string sName = myReader.GetString(1); //gets second column, itemName
                    itemBox.Items.Add(sName);

                }
            }

            con.Close();
        }

        private void viewInventory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryForm f = new inventoryForm();
            f.Show();
            this.Close();
        }

        private void changePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //gets this method from the loginForm.cs
            this.f1.btnSubmitText = "CHANGE";
            this.f1.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int num;
            var check = int.TryParse(numPieces.Text,out num);
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from inventorydb WHERE itemName=@itemName";
                cmd.Parameters.Add(new SqlParameter("itemName", itemBox.Text));
                SqlDataReader read = cmd.ExecuteReader();
                int pcs;

                //the logic is to avoid the no. of pieces from exceeding the encoded one
                if (numPieces.Text != "")
                {
                    while (read.Read())
                    {
                        pcs = Convert.ToInt32((read["pcs"].ToString()));

                        if (num > pcs)
                        {
                            MessageBox.Show("Your sales surpassed the encoded no. of pieces.");
                            numPieces.Clear();
                            read.Close();
                            con.Close();
                        }
                        else
                        {
                            break;
                        }
                    }

                    read.Close();
                    cmd.CommandText = "UPDATE inventorydb SET sales=sales+@sales WHERE itemName=@itemName";
                    cmd.Parameters.Add(new SqlParameter("sales", numPieces.Text));
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE inventorydb SET remainingQty=pcs-sales, totalSales=amtPerPiece*sales WHERE itemName=@itemName";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE inventorydb SET income=totalSales - amount WHERE itemName=@itemName";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE inventorydb SET totalIncome = income-expense WHERE itemName=@itemName";
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Success!");
                    numPieces.Clear();
                }



            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "InvalidOperationException");
                //check if connection is open
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }          
            
            
        }
    }
}
