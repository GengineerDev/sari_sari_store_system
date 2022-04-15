
namespace Sari_Sari_Store_System
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.numPieces = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewInventory = new System.Windows.Forms.LinkLabel();
            this.changePass = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.numPieces);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.itemBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD NEW PURCHASE";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(228, 141);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(143, 48);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // numPieces
            // 
            this.numPieces.Location = new System.Drawing.Point(190, 98);
            this.numPieces.Name = "numPieces";
            this.numPieces.Size = new System.Drawing.Size(181, 30);
            this.numPieces.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "NO. OF PIECES: ";
            // 
            // itemBox
            // 
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Location = new System.Drawing.Point(92, 34);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(279, 33);
            this.itemBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ITEM: ";
            // 
            // viewInventory
            // 
            this.viewInventory.AutoSize = true;
            this.viewInventory.Location = new System.Drawing.Point(305, 218);
            this.viewInventory.Name = "viewInventory";
            this.viewInventory.Size = new System.Drawing.Size(99, 17);
            this.viewInventory.TabIndex = 1;
            this.viewInventory.TabStop = true;
            this.viewInventory.Text = "View Inventory";
            this.viewInventory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewInventory_LinkClicked);
            // 
            // changePass
            // 
            this.changePass.AutoSize = true;
            this.changePass.Location = new System.Drawing.Point(177, 218);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(122, 17);
            this.changePass.TabIndex = 2;
            this.changePass.TabStop = true;
            this.changePass.Text = "Change Password";
            this.changePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changePass_LinkClicked);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 244);
            this.Controls.Add(this.changePass);
            this.Controls.Add(this.viewInventory);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Sari-Sari Store System";
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox numPieces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel viewInventory;
        private System.Windows.Forms.LinkLabel changePass;
    }
}