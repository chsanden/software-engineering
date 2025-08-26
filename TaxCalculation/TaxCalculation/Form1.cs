







using System;

using System.Windows.Forms;



namespace TaxCalculation
{
    public partial class Form1 : Form
    {
        private sealed class ComboItem
        {
            public string Text { get; }
            public VatGroup Value { get; }
            public ComboItem(string text, VatGroup value)
            {
                Text = text;
                Value = value;
            }
            public override string ToString() => Text;
        }

        public Form1()
        {
            InitializeComponent();
            SetupUi();
        }

        private void SetupUi()
        {
            taxMultiplier.DropDownStyle = ComboBoxStyle.DropDownList;
            taxMultiplier.Items.Clear();
            taxMultiplier.Items.AddRange(new object[]
            {
                new ComboItem("Other (25%)", VatGroup.Other),
                new ComboItem("Foodstuffs (15%)", VatGroup.Foodstuffs),
                new ComboItem("Passenger Transport (12%)", VatGroup.PassengerTransport),
                new ComboItem("Accommodation (12%)", VatGroup.Accommodation),
                new ComboItem("Entertainment Tickets (12%)", VatGroup.EntertainmentTickets),
                new ComboItem("Activity Centre Admission (12%)", VatGroup.ActivityCentreAdmission)
            });
            taxMultiplier.SelectedIndex = 0;

            this.AcceptButton = calculateBtn;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox1.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }
            if (taxMultiplier.SelectedItem is not ComboItem sel)
            {
                MessageBox.Show("Please select a valid tax group.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var group = sel.Value;
            var item = TaxObject.FromBase(amount, group);
            labelTaxValue.Text = item.ValueAddedTax.ToString("N2");
            labelTotalValue.Text = item.TotalWithTax.ToString("N2");

        }
    }
}