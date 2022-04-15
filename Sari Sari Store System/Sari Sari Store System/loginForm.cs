using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sari_Sari_Store_System
{
    public partial class projInventory : Form
    {
        public projInventory()
        {
            InitializeComponent();
        }

        public string btnSubmitText
        {
            // passing the button text to inventoryForm
            get { return btnSubmit.Text; }
            set { btnSubmit.Text = value; }
        }

        private void projInventory_Load(object sender, EventArgs e)
        {
            if (!File.Exists("loginCredentials.txt"))
            {
                FileStream f = File.Create("loginCredentials.txt");
                f.Close();
            }

            if (new FileInfo("loginCredentials.txt").Length == 0)
            {
                MessageBox.Show("You did not have an account yet.");
                btnSubmit.Text = "REGISTER";
                
            } 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "REGISTER")
            {
                StreamWriter sw = new StreamWriter("loginCredentials.txt");
                sw.WriteLine(username.Text);
                sw.WriteLine(pass.Text);
                sw.Close();
                MessageBox.Show("Success! Try to login.");
                username.Clear();
                pass.Clear();
                btnSubmit.Text = "LOGIN";
            } else if (btnSubmit.Text == "CHANGE"){            
                string[] changePass = File.ReadAllLines("loginCredentials.txt");
                if (username.Text != changePass[0])
                {
                    MessageBox.Show("Program cannot find the username.");
                    username.Clear();
                    pass.Clear();
                } else
                {
                    changePass[1] = pass.Text;
                    File.WriteAllLines("loginCredentials.txt", changePass);
                    MessageBox.Show("Success! Try to login.");
                    username.Clear();
                    pass.Clear();
                    btnSubmit.Text = "LOGIN";
                }
                
            }
            //if button text is LOGIN
            else 
            {
                string[] login = File.ReadAllLines("loginCredentials.txt");
                if (username.Text == login[0] & pass.Text == login[1])
                {
                    mainForm frm2 = new mainForm();
                    frm2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect login credentials!");
                    username.Text = "";
                    pass.Text = "";
                }

            }
        } 
    }
}
