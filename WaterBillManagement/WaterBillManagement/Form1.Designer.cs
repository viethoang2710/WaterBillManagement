namespace WaterBillManagement
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumberOfPeople = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWaterMeterLastMonth = new System.Windows.Forms.TextBox();
            this.txtNameOfCustomer = new System.Windows.Forms.TextBox();
            this.txtWaterMeterThisMonth = new System.Windows.Forms.TextBox();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExportInvoice = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnASC = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDESC = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmbTypeOfCustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Water Meter Last Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Water Meter This Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type of customer";
            // 
            // lbNumberOfPeople
            // 
            this.lbNumberOfPeople.AutoSize = true;
            this.lbNumberOfPeople.Location = new System.Drawing.Point(19, 349);
            this.lbNumberOfPeople.Name = "lbNumberOfPeople";
            this.lbNumberOfPeople.Size = new System.Drawing.Size(115, 16);
            this.lbNumberOfPeople.TabIndex = 4;
            this.lbNumberOfPeople.Text = "Number of people";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search by name of customer";
            // 
            // txtWaterMeterLastMonth
            // 
            this.txtWaterMeterLastMonth.Location = new System.Drawing.Point(22, 168);
            this.txtWaterMeterLastMonth.Name = "txtWaterMeterLastMonth";
            this.txtWaterMeterLastMonth.Size = new System.Drawing.Size(100, 22);
            this.txtWaterMeterLastMonth.TabIndex = 6;
            // 
            // txtNameOfCustomer
            // 
            this.txtNameOfCustomer.Location = new System.Drawing.Point(22, 100);
            this.txtNameOfCustomer.Name = "txtNameOfCustomer";
            this.txtNameOfCustomer.Size = new System.Drawing.Size(100, 22);
            this.txtNameOfCustomer.TabIndex = 7;
            // 
            // txtWaterMeterThisMonth
            // 
            this.txtWaterMeterThisMonth.Location = new System.Drawing.Point(22, 234);
            this.txtWaterMeterThisMonth.Name = "txtWaterMeterThisMonth";
            this.txtWaterMeterThisMonth.Size = new System.Drawing.Size(100, 22);
            this.txtWaterMeterThisMonth.TabIndex = 8;
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Location = new System.Drawing.Point(22, 379);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfPeople.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(472, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnExportInvoice
            // 
            this.btnExportInvoice.Location = new System.Drawing.Point(647, 330);
            this.btnExportInvoice.Name = "btnExportInvoice";
            this.btnExportInvoice.Size = new System.Drawing.Size(110, 23);
            this.btnExportInvoice.TabIndex = 12;
            this.btnExportInvoice.Text = "Export Invoice";
            this.btnExportInvoice.UseVisualStyleBackColor = true;
            this.btnExportInvoice.Click += new System.EventHandler(this.btnExportInvoice_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(349, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnASC
            // 
            this.btnASC.Location = new System.Drawing.Point(273, 390);
            this.btnASC.Name = "btnASC";
            this.btnASC.Size = new System.Drawing.Size(75, 23);
            this.btnASC.TabIndex = 15;
            this.btnASC.Text = "ASC";
            this.btnASC.UseVisualStyleBackColor = true;
            this.btnASC.Click += new System.EventHandler(this.btnASC_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDESC
            // 
            this.btnDESC.Location = new System.Drawing.Point(434, 390);
            this.btnDESC.Name = "btnDESC";
            this.btnDESC.Size = new System.Drawing.Size(75, 23);
            this.btnDESC.TabIndex = 18;
            this.btnDESC.Text = "DESC";
            this.btnDESC.UseVisualStyleBackColor = true;
            this.btnDESC.Click += new System.EventHandler(this.btnDESC_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(195, 70);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(562, 226);
            this.dgv.TabIndex = 19;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellClick);
            // 
            // cmbTypeOfCustomer
            // 
            this.cmbTypeOfCustomer.FormattingEnabled = true;
            this.cmbTypeOfCustomer.Location = new System.Drawing.Point(22, 304);
            this.cmbTypeOfCustomer.Name = "cmbTypeOfCustomer";
            this.cmbTypeOfCustomer.Size = new System.Drawing.Size(121, 24);
            this.cmbTypeOfCustomer.TabIndex = 20;
            this.cmbTypeOfCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbTypeOfCustomer_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTypeOfCustomer);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnDESC);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnASC);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExportInvoice);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.txtWaterMeterThisMonth);
            this.Controls.Add(this.txtNameOfCustomer);
            this.Controls.Add(this.txtWaterMeterLastMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbNumberOfPeople);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNumberOfPeople;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWaterMeterLastMonth;
        private System.Windows.Forms.TextBox txtNameOfCustomer;
        private System.Windows.Forms.TextBox txtWaterMeterThisMonth;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExportInvoice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnASC;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDESC;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbTypeOfCustomer;
    }
}

