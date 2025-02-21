using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {

        private List<decimal> w2Incomes = new List<decimal>();
        private List<decimal> deductions = new List<decimal>();
        private const decimal StandardDeduction = 14600m;

        // Tax brackets
        private readonly List<TaxBracket> taxBrackets = new List<TaxBracket>
        {
            new TaxBracket(0, 11600, 0.10m),
            new TaxBracket(11601, 47150, 0.12m),
            new TaxBracket(47151, 100525, 0.22m),
            new TaxBracket(100526, 191950, 0.24m),
            new TaxBracket(191951, 243725, 0.32m),
            new TaxBracket(243726, 609350, 0.35m),
            new TaxBracket(609351, decimal.MaxValue, 0.37m)
        };

        public Form1()
        {
            InitializeComponent();
            btnReset.Click += btnReset_Click;
            SetupInputValidation();
            ResetResults();
        }

        private void btnAddW2_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtW2Income.Text, out decimal income) && income > 0)
            {
                w2Incomes.Add(income);
                lstW2.Items.Add(income.ToString("C"));
                txtW2Income.Clear();
            }
            txtDeduction.Focus();
        }

        private void btnAddDeduction_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDeduction.Text, out decimal deduction) && deduction >= 0)
            {
                deductions.Add(deduction);
                lstDeductions.Items.Add(deduction.ToString("C"));
                txtDeduction.Clear();
            }
            txtDeduction.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal grossIncome = w2Incomes.Sum();
                decimal totalDeductions = CalculateTotalDeductions();
                decimal agi = Math.Max(grossIncome - totalDeductions, 0);

                var taxResult = CalculateTax(agi);

                UpdateResultsDisplay(grossIncome, totalDeductions, agi, taxResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating taxes: {ex.Message}", "Calculation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear all input data
            w2Incomes.Clear();
            deductions.Clear();

            // Clear list boxes
            lstW2.Items.Clear();
            lstDeductions.Items.Clear();

            // Reset input fields
            txtW2Income.Clear();
            txtDeduction.Clear();

            // Reset results display
            ResetResults();

            // Set focus back to the first input field
            txtW2Income.Focus();
        }
        private void ResetResults()
        {
            lblGrossValue.Text = "$0.00";
            lblDeductionsValue.Text = "$0.00";
            lblAGIValue.Text = "$0.00";
            lblTotalTaxValue.Text = "$0.00";
            lblAGIPercentageValue.Text = "N/A";
            lblGrossPercentageValue.Text = "0.00%";
            lvTaxBrackets.Items.Clear();
        }

        private decimal CalculateTotalDeductions()
        {
            decimal itemizedDeductions = deductions.Sum();
            return Math.Max(itemizedDeductions, StandardDeduction);
        }

        private TaxCalculationResult CalculateTax(decimal taxableIncome)
        {
            var result = new TaxCalculationResult();
            decimal remainingIncome = taxableIncome;
            decimal previousUpper = 0;

            foreach (var bracket in taxBrackets.OrderBy(b => b.UpperBound))
            {
                if (remainingIncome <= 0) break;

                decimal bracketRange = bracket.UpperBound - previousUpper;
                decimal taxableInBracket = Math.Min(remainingIncome, bracketRange);

                decimal taxInBracket = taxableInBracket * bracket.Rate;
                result.BracketTaxes.Add((bracket.Rate, taxInBracket));
                result.TotalTax += taxInBracket;

                previousUpper = bracket.UpperBound;
                remainingIncome -= taxableInBracket;
            }

            return result;
        }

        private void UpdateResultsDisplay(decimal gross, decimal deductions, decimal agi,
                                         TaxCalculationResult taxResult)
        {
            // Basic information
            lblGrossValue.Text = gross.ToString("C");
            lblDeductionsValue.Text = deductions.ToString("C");
            lblAGIValue.Text = agi.ToString("C");

            // Tax bracket breakdown
            lvTaxBrackets.Items.Clear();
            foreach (var (rate, amount) in taxResult.BracketTaxes)
            {
                var item = new ListViewItem(rate.ToString("P0"));
                item.SubItems.Add(amount.ToString("C"));
                lvTaxBrackets.Items.Add(item);
            }

            // Totals and percentages
            lblTotalTaxValue.Text = taxResult.TotalTax.ToString("C");
            lblAGIPercentageValue.Text = agi > 0 ?
                $"{taxResult.TotalTax / agi * 100m:F2}%" : "N/A";
            lblGrossPercentageValue.Text = $"{taxResult.TotalTax / gross * 100m:F2}%";
        }

        private void SetupInputValidation()
        {
            txtW2Income.KeyPress += NumericInputHandler;
            txtDeduction.KeyPress += NumericInputHandler;

            txtW2Income.TextChanged += (s, e) =>
                btnAddW2.Enabled = decimal.TryParse(txtW2Income.Text, out decimal val) && val > 0;

            txtDeduction.TextChanged += (s, e) =>
                btnAddDeduction.Enabled = decimal.TryParse(txtDeduction.Text, out decimal val) && val >= 0;
        }

        private void NumericInputHandler(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // Only allow one decimal point
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
                e.Handled = true;
        }

    }

    public class TaxBracket
    {
        public decimal LowerBound { get; }
        public decimal UpperBound { get; }
        public decimal Rate { get; }

        public TaxBracket(decimal lower, decimal upper, decimal rate)
        {
            LowerBound = lower;
            UpperBound = upper;
            Rate = rate;
        }

    }
    public class TaxCalculationResult
    {
        public decimal TotalTax { get; set; }
        public List<(decimal Rate, decimal Amount)> BracketTaxes { get; } = new List<(decimal, decimal)>();

    }
}
