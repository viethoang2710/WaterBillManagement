using System;
using System.Data;
using System.Windows.Forms;

namespace WaterBillManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        string[] names = new string[100];
        int[] types = new int[100];
        double[] lastMonths = new double[100];
        double[] thisMonths = new double[100];
        int[] numberPeople = new int[100];
        double[] usages = new double[100];
        double[] totalCosts = new double[100];

        int n = 0;
        int index = -1;

        // Initialize ComboBox with customer types
        private void InitializeComboBox()
        {
            cmbTypeOfCustomer.Items.AddRange(new object[] { "0 - Household", 
                "1 - Administrative", "2 - Production", "3 - Business" });
        }

        // Display data in DataGridView
        private void Display()
        {
            dgv.DataSource = null;
            var bills = new DataTable();
            bills.Columns.Add("Name");
            bills.Columns.Add("Last Month");
            bills.Columns.Add("This Month");
            bills.Columns.Add("Usage");
            bills.Columns.Add("Total Cost");

            for (int i = 0; i < n; i++)
            {
                bills.Rows.Add(names[i], lastMonths[i], thisMonths[i], usages[i], totalCosts[i]);
            }

            dgv.DataSource = bills;
            dgv.Refresh();
        }

        // Clear input fields
        private void ClearData()
        {
            txtNameOfCustomer.Text = "";
            txtWaterMeterLastMonth.Text = "";
            txtWaterMeterThisMonth.Text = "";
            txtNumberOfPeople.Text = "";
            cmbTypeOfCustomer.SelectedIndex = -1;
            Display();
        }

        private void cmbTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbTypeOfCustomer.SelectedIndex;
            lbNumberOfPeople.Visible = selectedIndex == 0; 
            txtNumberOfPeople.Visible = selectedIndex == 0;
        }

        // Calculate water price
        private double GetPriceUnit(int customerType, double usageTotal)
        {
            double priceUnit = 0;
            if (customerType == 0) // Household
            {
                int numPeople = int.Parse(txtNumberOfPeople.Text);
                double avg = usageTotal / numPeople;
                if (avg <= 10) priceUnit = 5973;
                else if (avg <= 20) priceUnit = 7052;
                else if (avg <= 30) priceUnit = 8699;
                else priceUnit = 15929;
            }
            else if (customerType == 1) // Administrative
            {
                priceUnit = 9955;
            }
            else if (customerType == 2) // Production
            {
                priceUnit = 11615;
            }
            else if (customerType == 3) // Business
            {
                priceUnit = 22068;
            }
            return priceUnit;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameOfCustomer.Text) ||
        string.IsNullOrEmpty(txtWaterMeterLastMonth.Text) ||
        string.IsNullOrEmpty(txtWaterMeterThisMonth.Text) ||
        cmbTypeOfCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required information.", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerName = txtNameOfCustomer.Text;
            double lastMonth = double.Parse(txtWaterMeterLastMonth.Text);
            double thisMonth = double.Parse(txtWaterMeterThisMonth.Text);

            if (thisMonth < lastMonth)
            {
                MessageBox.Show("This month's reading must be greater " +
                    "than or equal to last month's reading.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int customerType = cmbTypeOfCustomer.SelectedIndex;
            double usageTotal = thisMonth - lastMonth;
            double priceUnit = GetPriceUnit(customerType, usageTotal);
            double totalBill = usageTotal * priceUnit * 1.1; // Calculate total bill including 10% tax

            names[n] = customerName;
            types[n] = customerType;
            lastMonths[n] = lastMonth;
            thisMonths[n] = thisMonth;
            numberPeople[n] = (customerType == 0) ? int.Parse(txtNumberOfPeople.Text) : 0;
            usages[n] = usageTotal;
            totalCosts[n] = totalBill;
            n++;

            Display();
            MessageBox.Show("Added successfully.");
            ClearData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index == -1 || index >= n)
            {
                MessageBox.Show("Please select a row to edit.", "Notification", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            string customerName = txtNameOfCustomer.Text;
            double lastMonth = double.Parse(txtWaterMeterLastMonth.Text);
            double thisMonth = double.Parse(txtWaterMeterThisMonth.Text);
            int customerType = cmbTypeOfCustomer.SelectedIndex;
            double usageTotal = thisMonth - lastMonth;
            double priceUnit = GetPriceUnit(customerType, usageTotal);
            double totalBill = usageTotal * priceUnit * 1.1;

            names[index] = customerName;
            types[index] = customerType;
            lastMonths[index] = lastMonth;
            thisMonths[index] = thisMonth;
            numberPeople[index] = (customerType == 0) ? int.Parse(txtNumberOfPeople.Text) : 0;
            usages[index] = usageTotal;
            totalCosts[index] = totalBill;

            Display();
            MessageBox.Show("Updated successfully.");
            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index == -1 || index >= n)
            {
                MessageBox.Show("Please select a row to delete.", "Notification", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = index; i < n - 1; i++)
                {
                    names[i] = names[i + 1];
                    types[i] = types[i + 1];
                    lastMonths[i] = lastMonths[i + 1];
                    thisMonths[i] = thisMonths[i + 1];
                    numberPeople[i] = numberPeople[i + 1];
                    usages[i] = usages[i + 1];
                    totalCosts[i] = totalCosts[i + 1];
                }
                n--;
                Display();
                MessageBox.Show("Deleted successfully.");
                ClearData();
            }
        }

        private void dgvBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < n)
            {
                index = e.RowIndex;
                txtNameOfCustomer.Text = names[index];
                txtWaterMeterLastMonth.Text = lastMonths[index].ToString();
                txtWaterMeterThisMonth.Text = thisMonths[index].ToString();
                cmbTypeOfCustomer.SelectedIndex = types[index];

                if (types[index] == 0)
                {
                    txtNumberOfPeople.Text = numberPeople[index].ToString();
                    lbNumberOfPeople.Visible = true;
                    txtNumberOfPeople.Visible = true;
                }
                else
                {
                    lbNumberOfPeople.Visible = false;
                    txtNumberOfPeople.Visible = false;
                }
            }
        }

        private void Swap(int i, int j)
        {
            (names[i], names[j]) = (names[j], names[i]);
            (types[i], types[j]) = (types[j], types[i]);
            (lastMonths[i], lastMonths[j]) = (lastMonths[j], lastMonths[i]);
            (thisMonths[i], thisMonths[j]) = (thisMonths[j], thisMonths[i]);
            (numberPeople[i], numberPeople[j]) = (numberPeople[j], numberPeople[i]);
            (usages[i], usages[j]) = (usages[j], usages[i]);
            (totalCosts[i], totalCosts[j]) = (totalCosts[j], totalCosts[i]);
        }

        // Sort customers by totalCosts in ascending order
        private void btnASC_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (totalCosts[j] > totalCosts[j + 1])
                    {
                        Swap(j, j + 1);
                    }
                }
            }
            Display();
        }

        // Sort customers by totalCosts in descending order
        private void btnDESC_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (totalCosts[j] < totalCosts[j + 1])
                    {
                        Swap(j, j + 1);
                    }
                }
            }
            Display();
        }

        // Display the invoice
        private void btnExportInvoice_Click(object sender, EventArgs e)
        {
            string customerName = txtNameOfCustomer.Text;
            double WaterMeterLastMonth = double.Parse(txtWaterMeterLastMonth.Text);
            double WaterMeterThisMonth = double.Parse(txtWaterMeterThisMonth.Text);
            int customerType = cmbTypeOfCustomer.SelectedIndex;
            double usageTotal = WaterMeterThisMonth - WaterMeterLastMonth;
            double priceUnit = GetPriceUnit(customerType, usageTotal);
            double totalBill = usageTotal * priceUnit * 1.1;

            string output = $"Invoice for {customerName}\n" +
                            $"Last Month's Reading: {WaterMeterLastMonth}\n" +
                            $"This Month's Reading: {WaterMeterThisMonth}\n" +
                            $"Usage: {usageTotal} m3\n" +
                            $"Price Per Unit: {priceUnit} VND\n" +
                            $"Total Amount: {totalBill} VND\n";
            MessageBox.Show(output, "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            var filteredBills = new DataTable();
            filteredBills.Columns.Add("Name");
            filteredBills.Columns.Add("Last Month");
            filteredBills.Columns.Add("This Month");
            filteredBills.Columns.Add("Usage");
            filteredBills.Columns.Add("Total Cost");

            for (int i = 0; i < n; i++)
            {
                if (names[i].ToLower().Contains(searchText))
                {
                    filteredBills.Rows.Add(names[i], lastMonths[i], 
                        thisMonths[i], usages[i], totalCosts[i]);
                }
            }

            dgv.DataSource = filteredBills;
            dgv.Refresh();
        }
    }
}



