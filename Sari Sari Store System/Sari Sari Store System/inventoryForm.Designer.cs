
namespace Sari_Sari_Store_System
{
    partial class inventoryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryForm));
            this.inventorydbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new Sari_Sari_Store_System.inventoryDataSet();
            this.inventorydbTableAdapter = new Sari_Sari_Store_System.inventoryDataSetTableAdapters.inventorydbTableAdapter();
            this.addPage = new System.Windows.Forms.TabPage();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.amtPerPiece = new System.Windows.Forms.TextBox();
            this.pieces = new System.Windows.Forms.TextBox();
            this.expenses = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.editPage = new System.Windows.Forms.TabPage();
            this.loadData = new System.Windows.Forms.LinkLabel();
            this.editCode = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.editSales = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.oldCode = new System.Windows.Forms.TextBox();
            this.editAmtPerPiece = new System.Windows.Forms.TextBox();
            this.editPieces = new System.Windows.Forms.TextBox();
            this.editExpenses = new System.Windows.Forms.TextBox();
            this.editAmount = new System.Windows.Forms.TextBox();
            this.editName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.editUnit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtPerPieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIncomeLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.delCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            this.addPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.editPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventorydbBindingSource
            // 
            this.inventorydbBindingSource.DataMember = "inventorydb";
            this.inventorydbBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "inventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventorydbTableAdapter
            // 
            this.inventorydbTableAdapter.ClearBeforeFill = true;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.itemCode);
            this.addPage.Controls.Add(this.amtPerPiece);
            this.addPage.Controls.Add(this.pieces);
            this.addPage.Controls.Add(this.expenses);
            this.addPage.Controls.Add(this.amount);
            this.addPage.Controls.Add(this.itemName);
            this.addPage.Controls.Add(this.label7);
            this.addPage.Controls.Add(this.label1);
            this.addPage.Controls.Add(this.label6);
            this.addPage.Controls.Add(this.label5);
            this.addPage.Controls.Add(this.unitBox);
            this.addPage.Controls.Add(this.label3);
            this.addPage.Controls.Add(this.label4);
            this.addPage.Controls.Add(this.label2);
            this.addPage.Controls.Add(this.addItem);
            this.addPage.Location = new System.Drawing.Point(4, 25);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(967, 272);
            this.addPage.TabIndex = 0;
            this.addPage.Text = "ADD";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // itemCode
            // 
            this.itemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCode.Location = new System.Drawing.Point(151, 22);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(289, 27);
            this.itemCode.TabIndex = 18;
            // 
            // amtPerPiece
            // 
            this.amtPerPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtPerPiece.Location = new System.Drawing.Point(640, 65);
            this.amtPerPiece.Name = "amtPerPiece";
            this.amtPerPiece.Size = new System.Drawing.Size(289, 27);
            this.amtPerPiece.TabIndex = 16;
            // 
            // pieces
            // 
            this.pieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieces.Location = new System.Drawing.Point(151, 153);
            this.pieces.Name = "pieces";
            this.pieces.Size = new System.Drawing.Size(289, 27);
            this.pieces.TabIndex = 14;
            // 
            // expenses
            // 
            this.expenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses.Location = new System.Drawing.Point(640, 109);
            this.expenses.Name = "expenses";
            this.expenses.Size = new System.Drawing.Size(289, 27);
            this.expenses.TabIndex = 12;
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(640, 22);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(289, 27);
            this.amount.TabIndex = 9;
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(151, 64);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(289, 27);
            this.itemName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Item Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Amount per piece:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "No. of Pieces:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Expenses:";
            // 
            // unitBox
            // 
            this.unitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitBox.FormattingEnabled = true;
            this.unitBox.Items.AddRange(new object[] {
            "Box",
            "Individual Pieces"});
            this.unitBox.Location = new System.Drawing.Point(151, 108);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(289, 30);
            this.unitBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Name: ";
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(37, 215);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(892, 38);
            this.addItem.TabIndex = 1;
            this.addItem.Text = "ADD ITEM";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addPage);
            this.tabControl1.Controls.Add(this.editPage);
            this.tabControl1.Location = new System.Drawing.Point(16, 418);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // editPage
            // 
            this.editPage.Controls.Add(this.loadData);
            this.editPage.Controls.Add(this.editCode);
            this.editPage.Controls.Add(this.label19);
            this.editPage.Controls.Add(this.label18);
            this.editPage.Controls.Add(this.editSales);
            this.editPage.Controls.Add(this.label17);
            this.editPage.Controls.Add(this.oldCode);
            this.editPage.Controls.Add(this.editAmtPerPiece);
            this.editPage.Controls.Add(this.editPieces);
            this.editPage.Controls.Add(this.editExpenses);
            this.editPage.Controls.Add(this.editAmount);
            this.editPage.Controls.Add(this.editName);
            this.editPage.Controls.Add(this.label9);
            this.editPage.Controls.Add(this.label10);
            this.editPage.Controls.Add(this.label11);
            this.editPage.Controls.Add(this.label12);
            this.editPage.Controls.Add(this.editUnit);
            this.editPage.Controls.Add(this.label13);
            this.editPage.Controls.Add(this.label14);
            this.editPage.Controls.Add(this.label15);
            this.editPage.Controls.Add(this.editBtn);
            this.editPage.Location = new System.Drawing.Point(4, 25);
            this.editPage.Name = "editPage";
            this.editPage.Padding = new System.Windows.Forms.Padding(3);
            this.editPage.Size = new System.Drawing.Size(967, 272);
            this.editPage.TabIndex = 1;
            this.editPage.Text = "EDIT";
            this.editPage.UseVisualStyleBackColor = true;
            // 
            // loadData
            // 
            this.loadData.AutoSize = true;
            this.loadData.Location = new System.Drawing.Point(164, 44);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(46, 17);
            this.loadData.TabIndex = 39;
            this.loadData.TabStop = true;
            this.loadData.Text = "LOAD";
            this.loadData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loadData_LinkClicked);
            // 
            // editCode
            // 
            this.editCode.Enabled = false;
            this.editCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCode.Location = new System.Drawing.Point(362, 13);
            this.editCode.Name = "editCode";
            this.editCode.Size = new System.Drawing.Size(91, 27);
            this.editCode.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(242, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 18);
            this.label19.TabIndex = 37;
            this.label19.Text = "New Item Code:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 242);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "*not editable";
            // 
            // editSales
            // 
            this.editSales.Enabled = false;
            this.editSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSales.Location = new System.Drawing.Point(640, 153);
            this.editSales.Name = "editSales";
            this.editSales.Size = new System.Drawing.Size(289, 27);
            this.editSales.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(576, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 18);
            this.label17.TabIndex = 34;
            this.label17.Text = "Sales:";
            // 
            // oldCode
            // 
            this.oldCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldCode.Location = new System.Drawing.Point(127, 13);
            this.oldCode.Name = "oldCode";
            this.oldCode.Size = new System.Drawing.Size(83, 27);
            this.oldCode.TabIndex = 33;
            // 
            // editAmtPerPiece
            // 
            this.editAmtPerPiece.Enabled = false;
            this.editAmtPerPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAmtPerPiece.Location = new System.Drawing.Point(640, 65);
            this.editAmtPerPiece.Name = "editAmtPerPiece";
            this.editAmtPerPiece.Size = new System.Drawing.Size(289, 27);
            this.editAmtPerPiece.TabIndex = 31;
            // 
            // editPieces
            // 
            this.editPieces.Enabled = false;
            this.editPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPieces.Location = new System.Drawing.Point(151, 153);
            this.editPieces.Name = "editPieces";
            this.editPieces.Size = new System.Drawing.Size(289, 27);
            this.editPieces.TabIndex = 29;
            // 
            // editExpenses
            // 
            this.editExpenses.Enabled = false;
            this.editExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editExpenses.Location = new System.Drawing.Point(640, 109);
            this.editExpenses.Name = "editExpenses";
            this.editExpenses.Size = new System.Drawing.Size(289, 27);
            this.editExpenses.TabIndex = 27;
            // 
            // editAmount
            // 
            this.editAmount.Enabled = false;
            this.editAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAmount.Location = new System.Drawing.Point(640, 22);
            this.editAmount.Name = "editAmount";
            this.editAmount.Size = new System.Drawing.Size(289, 27);
            this.editAmount.TabIndex = 24;
            // 
            // editName
            // 
            this.editName.Enabled = false;
            this.editName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editName.Location = new System.Drawing.Point(151, 64);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(289, 27);
            this.editName.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Old Item Code*:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(498, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Amount per piece:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "No. of Pieces:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(548, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Expenses:";
            // 
            // editUnit
            // 
            this.editUnit.Enabled = false;
            this.editUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUnit.FormattingEnabled = true;
            this.editUnit.Items.AddRange(new object[] {
            "Box",
            "Individual Pieces"});
            this.editUnit.Location = new System.Drawing.Point(151, 108);
            this.editUnit.Name = "editUnit";
            this.editUnit.Size = new System.Drawing.Size(289, 30);
            this.editUnit.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(562, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(98, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Unit:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(48, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "Item Name: ";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(37, 201);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(892, 38);
            this.editBtn.TabIndex = 19;
            this.editBtn.Text = "EDIT ITEM";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCodeDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.pcsDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.salesDataGridViewTextBoxColumn,
            this.remainingQtyDataGridViewTextBoxColumn,
            this.amtPerPieceDataGridViewTextBoxColumn,
            this.totalSalesDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.expenseDataGridViewTextBoxColumn,
            this.totalIncomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventorydbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(975, 313);
            this.dataGridView1.TabIndex = 1;
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "itemCode";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "itemCode";
            this.itemCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            this.itemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "itemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // pcsDataGridViewTextBoxColumn
            // 
            this.pcsDataGridViewTextBoxColumn.DataPropertyName = "pcs";
            this.pcsDataGridViewTextBoxColumn.HeaderText = "pcs";
            this.pcsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pcsDataGridViewTextBoxColumn.Name = "pcsDataGridViewTextBoxColumn";
            this.pcsDataGridViewTextBoxColumn.ReadOnly = true;
            this.pcsDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesDataGridViewTextBoxColumn
            // 
            this.salesDataGridViewTextBoxColumn.DataPropertyName = "sales";
            this.salesDataGridViewTextBoxColumn.HeaderText = "sales";
            this.salesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            this.salesDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesDataGridViewTextBoxColumn.Width = 125;
            // 
            // remainingQtyDataGridViewTextBoxColumn
            // 
            this.remainingQtyDataGridViewTextBoxColumn.DataPropertyName = "remainingQty";
            this.remainingQtyDataGridViewTextBoxColumn.HeaderText = "remainingQty";
            this.remainingQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remainingQtyDataGridViewTextBoxColumn.Name = "remainingQtyDataGridViewTextBoxColumn";
            this.remainingQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.remainingQtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // amtPerPieceDataGridViewTextBoxColumn
            // 
            this.amtPerPieceDataGridViewTextBoxColumn.DataPropertyName = "amtPerPiece";
            this.amtPerPieceDataGridViewTextBoxColumn.HeaderText = "amtPerPiece";
            this.amtPerPieceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amtPerPieceDataGridViewTextBoxColumn.Name = "amtPerPieceDataGridViewTextBoxColumn";
            this.amtPerPieceDataGridViewTextBoxColumn.ReadOnly = true;
            this.amtPerPieceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalSalesDataGridViewTextBoxColumn
            // 
            this.totalSalesDataGridViewTextBoxColumn.DataPropertyName = "totalSales";
            this.totalSalesDataGridViewTextBoxColumn.HeaderText = "totalSales";
            this.totalSalesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalSalesDataGridViewTextBoxColumn.Name = "totalSalesDataGridViewTextBoxColumn";
            this.totalSalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSalesDataGridViewTextBoxColumn.Width = 125;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "income";
            this.incomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.incomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // expenseDataGridViewTextBoxColumn
            // 
            this.expenseDataGridViewTextBoxColumn.DataPropertyName = "expense";
            this.expenseDataGridViewTextBoxColumn.HeaderText = "expense";
            this.expenseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenseDataGridViewTextBoxColumn.Name = "expenseDataGridViewTextBoxColumn";
            this.expenseDataGridViewTextBoxColumn.ReadOnly = true;
            this.expenseDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalIncomeDataGridViewTextBoxColumn
            // 
            this.totalIncomeDataGridViewTextBoxColumn.DataPropertyName = "totalIncome";
            this.totalIncomeDataGridViewTextBoxColumn.HeaderText = "totalIncome";
            this.totalIncomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalIncomeDataGridViewTextBoxColumn.Name = "totalIncomeDataGridViewTextBoxColumn";
            this.totalIncomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalIncomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalIncomeLbl
            // 
            this.totalIncomeLbl.AutoSize = true;
            this.totalIncomeLbl.BackColor = System.Drawing.Color.Silver;
            this.totalIncomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIncomeLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalIncomeLbl.Location = new System.Drawing.Point(199, 351);
            this.totalIncomeLbl.Name = "totalIncomeLbl";
            this.totalIncomeLbl.Size = new System.Drawing.Size(0, 24);
            this.totalIncomeLbl.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "TOTAL INCOME:";
            // 
            // delCode
            // 
            this.delCode.Location = new System.Drawing.Point(820, 375);
            this.delCode.Name = "delCode";
            this.delCode.Size = new System.Drawing.Size(171, 22);
            this.delCode.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(679, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "Delete Item Name:";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(876, 403);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(115, 34);
            this.delBtn.TabIndex = 7;
            this.delBtn.Text = "DELETE";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Location = new System.Drawing.Point(840, 729);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(147, 17);
            this.back.TabIndex = 8;
            this.back.TabStop = true;
            this.back.Text = "BACK TO MAIN PAGE";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 755);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.delCode);
            this.Controls.Add(this.totalIncomeLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "inventoryForm";
            this.Text = "Sari-Sari Store System: Inventory";
            this.Load += new System.EventHandler(this.inventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.editPage.ResumeLayout(false);
            this.editPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private inventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource inventorydbBindingSource;
        private inventoryDataSetTableAdapters.inventorydbTableAdapter inventorydbTableAdapter;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TextBox itemCode;
        private System.Windows.Forms.TextBox amtPerPiece;
        private System.Windows.Forms.TextBox pieces;
        private System.Windows.Forms.TextBox expenses;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage editPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtPerPieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label totalIncomeLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox oldCode;
        private System.Windows.Forms.TextBox editAmtPerPiece;
        private System.Windows.Forms.TextBox editPieces;
        private System.Windows.Forms.TextBox editExpenses;
        private System.Windows.Forms.TextBox editAmount;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox editUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox delCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.TextBox editSales;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox editCode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel loadData;
        private System.Windows.Forms.LinkLabel back;
    }
}