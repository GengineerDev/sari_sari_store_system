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
    public partial class inventoryForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\Sari Sari Store System\Sari Sari Store System\inventory.mdf;Integrated Security=True");
        public inventoryForm()
        {
            InitializeComponent();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            
            if (itemCode.Text == "" || itemName.Text == "" || unitBox.Text == "" || pieces.Text == "" || amount.Text == "" | amtPerPiece.Text == "" || expenses.Text == "")
            {
                MessageBox.Show("Do not leave any field blank.");
            } else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into inventorydb (itemCode, itemName,unit,pcs,amount,amtPerPiece,expense,remainingQty) values (@itemCode,@itemName,@unit,@pcs,@amount,@amtPerPiece,@expense,@remainingQty)";
                    cmd.Parameters.Add(new SqlParameter("itemCode", itemCode.Text));
                    cmd.Parameters.Add(new SqlParameter("itemName", itemName.Text));
                    cmd.Parameters.Add(new SqlParameter("unit", unitBox.Text));
                    cmd.Parameters.Add(new SqlParameter("pcs", pieces.Text));
                    cmd.Parameters.Add(new SqlParameter("amount", amount.Text));
                    cmd.Parameters.Add(new SqlParameter("amtPerPiece", amtPerPiece.Text));
                    cmd.Parameters.Add(new SqlParameter("expense", expenses.Text));
                    cmd.Parameters.Add(new SqlParameter("remainingQty", pieces.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(), ex.Message);
                }

                itemName.Clear();
                unitBox.Text = "Box";
                pieces.Clear();
                amount.Clear();
                amtPerPiece.Clear();
                expenses.Clear();

                //refresh data in the datagridview of "View Data" tab
                refreshData();
                dataGridView1.Update();
                dataGridView1.Refresh();
            }        
            
            
        }

        private void inventoryForm_Load(object sender, EventArgs e)
        {
            refreshData();
            // TODO: This line of code loads data into the 'inventoryDataSet.inventorydb' table. You can move, or remove it, as needed.
            this.inventorydbTableAdapter.Fill(this.inventoryDataSet.inventorydb);
            


        }

        private void refreshData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from inventorydb";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                double totalIncome = 0;
                for (int r = 0; r < dataGridView1.Rows.Count; r++)
                {
                    totalIncome += Convert.ToDouble(dataGridView1.Rows[r].Cells[11].Value);
                }

                totalIncomeLbl.Text = "Php " + totalIncome.ToString();
            } 
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //check if connection is open
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                
            }
            
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (oldCode.Text == "" || editCode.Text == "" || editUnit.Text == "" || editPieces.Text == "" || editAmount.Text == "" || editAmtPerPiece.Text == "" || editExpenses.Text == "")
            {
                MessageBox.Show("Do not leave any field blank.");
            } else
            {
                try
                {
                    int num;
                    var check = int.TryParse(editSales.Text, out num);
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from inventorydb WHERE itemCode=@itemCode";
                        cmd.Parameters.Add(new SqlParameter("itemCode", oldCode.Text));
                        SqlDataReader read = cmd.ExecuteReader();
                        int pcs;

                        //the logic is to avoid the no. of pieces from exceeding the encoded one
                        if (editSales.Text != "")
                        {
                            while (read.Read())
                            {
                                pcs = Convert.ToInt32((read["pcs"].ToString()));

                                if (num > pcs)
                                {
                                    MessageBox.Show("Your sales surpassed the encoded no. of pieces.");
                                    editSales.Clear();
                                    //read.Close();
                                    con.Close();
                                }
                                else
                                {
                                    break;
                                }
                            }

                            read.Close();
                            cmd.CommandText = "UPDATE inventorydb SET itemCode=@newCode, sales=@sales, itemName=@itemName, unit=@unit, pcs=@pcs, amtPerPiece=@amtPerPiece, expense=@expense WHERE itemCode=@itemCode";
                            cmd.Parameters.Add(new SqlParameter("newCode", editCode.Text));
                            cmd.Parameters.Add(new SqlParameter("sales", editSales.Text));
                            cmd.Parameters.Add(new SqlParameter("itemName", editName.Text));
                            cmd.Parameters.Add(new SqlParameter("unit", editUnit.Text));
                            cmd.Parameters.Add(new SqlParameter("pcs", editPieces.Text));
                            cmd.Parameters.Add(new SqlParameter("amtPerPiece", editAmtPerPiece.Text));
                            cmd.Parameters.Add(new SqlParameter("expense", editExpenses.Text));

                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "UPDATE inventorydb SET remainingQty=pcs-sales, totalSales=amtPerPiece*sales WHERE itemCode=@itemCode";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "UPDATE inventorydb SET income=totalSales - amount WHERE itemCode=@itemCode";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "UPDATE inventorydb SET totalIncome = income-expense WHERE itemCode=@itemCode";
                            cmd.ExecuteNonQuery();

                            con.Close();
                            MessageBox.Show("Success!");
                            refreshData();
                            editSales.Clear();
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
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            
        }

        private void loadData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (oldCode.Text == "")
            {
                MessageBox.Show("Nothing to load.");
            } else
            {
                
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from inventorydb WHERE itemCode=@itemCode";
                    cmd.Parameters.Add(new SqlParameter("itemCode", oldCode.Text));
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        editCode.Enabled = true;
                        editCode.Text = read["itemCode"].ToString();

                        editName.Enabled = true;
                        editName.Text = read["itemName"].ToString();

                        editUnit.Enabled = true;
                        editUnit.Text = read["unit"].ToString();

                        editPieces.Enabled = true;
                        editPieces.Text = read["pcs"].ToString();

                        editAmount.Enabled = true;
                        editAmount.Text = read["amount"].ToString();

                        editSales.Enabled = true;
                        editSales.Text = read["sales"].ToString();

                        editAmtPerPiece.Enabled = true;
                        editAmtPerPiece.Text = read["amtPerPiece"].ToString();

                        editExpenses.Enabled = true;
                        editExpenses.Text = read["expense"].ToString();
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (delCode.Text == "")
            {
                MessageBox.Show("Nothing to delete.");
            } else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from inventorydb WHERE itemCode=@itemCode";
                cmd.Parameters.Add(new SqlParameter("itemCode", delCode.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                con.Close();
                refreshData();
            }
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm f = new mainForm();
            f.Show();
            this.Close();
        }
    }
}
