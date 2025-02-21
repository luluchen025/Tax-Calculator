namespace Program_3
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
            this.grpW2 = new System.Windows.Forms.GroupBox();
            this.lstW2 = new System.Windows.Forms.ListBox();
            this.btnAddW2 = new System.Windows.Forms.Button();
            this.txtW2Income = new System.Windows.Forms.TextBox();
            this.grpDeductions = new System.Windows.Forms.GroupBox();
            this.lstDeductions = new System.Windows.Forms.ListBox();
            this.btnAddDeduction = new System.Windows.Forms.Button();
            this.txtDeduction = new System.Windows.Forms.TextBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblGrossPercentageValue = new System.Windows.Forms.Label();
            this.lblTotalTaxValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAGIPercentageValue = new System.Windows.Forms.Label();
            this.lblAGIPercentageText = new System.Windows.Forms.Label();
            this.lblTotalTaxText = new System.Windows.Forms.Label();
            this.lvTaxBrackets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAGIValue = new System.Windows.Forms.Label();
            this.lblDeductionsValue = new System.Windows.Forms.Label();
            this.lblGrossValue = new System.Windows.Forms.Label();
            this.lblAGIText = new System.Windows.Forms.Label();
            this.lblDeductionsText = new System.Windows.Forms.Label();
            this.lblGrossText = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpW2.SuspendLayout();
            this.grpDeductions.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpW2
            // 
            this.grpW2.Controls.Add(this.lstW2);
            this.grpW2.Controls.Add(this.btnAddW2);
            this.grpW2.Controls.Add(this.txtW2Income);
            this.grpW2.Location = new System.Drawing.Point(28, 25);
            this.grpW2.Name = "grpW2";
            this.grpW2.Size = new System.Drawing.Size(350, 175);
            this.grpW2.TabIndex = 0;
            this.grpW2.TabStop = false;
            this.grpW2.Text = "W2 Incomes";
            // 
            // lstW2
            // 
            this.lstW2.FormattingEnabled = true;
            this.lstW2.Location = new System.Drawing.Point(10, 50);
            this.lstW2.Name = "lstW2";
            this.lstW2.Size = new System.Drawing.Size(300, 95);
            this.lstW2.TabIndex = 2;
            // 
            // btnAddW2
            // 
            this.btnAddW2.Enabled = false;
            this.btnAddW2.Location = new System.Drawing.Point(170, 20);
            this.btnAddW2.Name = "btnAddW2";
            this.btnAddW2.Size = new System.Drawing.Size(75, 23);
            this.btnAddW2.TabIndex = 1;
            this.btnAddW2.Text = "Add W2";
            this.btnAddW2.UseVisualStyleBackColor = true;
            this.btnAddW2.Click += new System.EventHandler(this.btnAddW2_Click);
            // 
            // txtW2Income
            // 
            this.txtW2Income.Location = new System.Drawing.Point(10, 20);
            this.txtW2Income.Name = "txtW2Income";
            this.txtW2Income.Size = new System.Drawing.Size(150, 20);
            this.txtW2Income.TabIndex = 0;
            // 
            // grpDeductions
            // 
            this.grpDeductions.Controls.Add(this.lstDeductions);
            this.grpDeductions.Controls.Add(this.btnAddDeduction);
            this.grpDeductions.Controls.Add(this.txtDeduction);
            this.grpDeductions.Location = new System.Drawing.Point(407, 25);
            this.grpDeductions.Name = "grpDeductions";
            this.grpDeductions.Size = new System.Drawing.Size(350, 175);
            this.grpDeductions.TabIndex = 0;
            this.grpDeductions.TabStop = false;
            this.grpDeductions.Text = "Deductions";
            // 
            // lstDeductions
            // 
            this.lstDeductions.FormattingEnabled = true;
            this.lstDeductions.Location = new System.Drawing.Point(10, 50);
            this.lstDeductions.Name = "lstDeductions";
            this.lstDeductions.Size = new System.Drawing.Size(300, 95);
            this.lstDeductions.TabIndex = 2;
            // 
            // btnAddDeduction
            // 
            this.btnAddDeduction.Location = new System.Drawing.Point(170, 20);
            this.btnAddDeduction.Name = "btnAddDeduction";
            this.btnAddDeduction.Size = new System.Drawing.Size(106, 23);
            this.btnAddDeduction.TabIndex = 1;
            this.btnAddDeduction.Text = "Add Deduction";
            this.btnAddDeduction.UseVisualStyleBackColor = true;
            this.btnAddDeduction.Click += new System.EventHandler(this.btnAddDeduction_Click);
            // 
            // txtDeduction
            // 
            this.txtDeduction.Location = new System.Drawing.Point(10, 20);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(150, 20);
            this.txtDeduction.TabIndex = 0;
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblGrossPercentageValue);
            this.grpResults.Controls.Add(this.lblTotalTaxValue);
            this.grpResults.Controls.Add(this.label1);
            this.grpResults.Controls.Add(this.lblAGIPercentageValue);
            this.grpResults.Controls.Add(this.lblAGIPercentageText);
            this.grpResults.Controls.Add(this.lblTotalTaxText);
            this.grpResults.Controls.Add(this.lvTaxBrackets);
            this.grpResults.Controls.Add(this.lblAGIValue);
            this.grpResults.Controls.Add(this.lblDeductionsValue);
            this.grpResults.Controls.Add(this.lblGrossValue);
            this.grpResults.Controls.Add(this.lblAGIText);
            this.grpResults.Controls.Add(this.lblDeductionsText);
            this.grpResults.Controls.Add(this.lblGrossText);
            this.grpResults.Location = new System.Drawing.Point(28, 283);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(729, 333);
            this.grpResults.TabIndex = 0;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Tax Calculation Results";
            // 
            // lblGrossPercentageValue
            // 
            this.lblGrossPercentageValue.AutoSize = true;
            this.lblGrossPercentageValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblGrossPercentageValue.Location = new System.Drawing.Point(123, 300);
            this.lblGrossPercentageValue.Name = "lblGrossPercentageValue";
            this.lblGrossPercentageValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGrossPercentageValue.Size = new System.Drawing.Size(34, 13);
            this.lblGrossPercentageValue.TabIndex = 12;
            this.lblGrossPercentageValue.Text = "$0.00";
            // 
            // lblTotalTaxValue
            // 
            this.lblTotalTaxValue.AutoSize = true;
            this.lblTotalTaxValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalTaxValue.Location = new System.Drawing.Point(123, 250);
            this.lblTotalTaxValue.Name = "lblTotalTaxValue";
            this.lblTotalTaxValue.Size = new System.Drawing.Size(34, 13);
            this.lblTotalTaxValue.TabIndex = 11;
            this.lblTotalTaxValue.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(20, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tax as % of Gross:";
            // 
            // lblAGIPercentageValue
            // 
            this.lblAGIPercentageValue.AutoSize = true;
            this.lblAGIPercentageValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAGIPercentageValue.Location = new System.Drawing.Point(123, 275);
            this.lblAGIPercentageValue.Name = "lblAGIPercentageValue";
            this.lblAGIPercentageValue.Size = new System.Drawing.Size(34, 13);
            this.lblAGIPercentageValue.TabIndex = 9;
            this.lblAGIPercentageValue.Text = "$0.00";
            // 
            // lblAGIPercentageText
            // 
            this.lblAGIPercentageText.AutoSize = true;
            this.lblAGIPercentageText.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAGIPercentageText.Location = new System.Drawing.Point(20, 275);
            this.lblAGIPercentageText.Name = "lblAGIPercentageText";
            this.lblAGIPercentageText.Size = new System.Drawing.Size(86, 13);
            this.lblAGIPercentageText.TabIndex = 8;
            this.lblAGIPercentageText.Text = "Tax as % of AGI:";
            // 
            // lblTotalTaxText
            // 
            this.lblTotalTaxText.AutoSize = true;
            this.lblTotalTaxText.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalTaxText.Location = new System.Drawing.Point(20, 250);
            this.lblTotalTaxText.Name = "lblTotalTaxText";
            this.lblTotalTaxText.Size = new System.Drawing.Size(97, 13);
            this.lblTotalTaxText.TabIndex = 7;
            this.lblTotalTaxText.Text = "Total Taxes Owed:";
            // 
            // lvTaxBrackets
            // 
            this.lvTaxBrackets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvTaxBrackets.GridLines = true;
            this.lvTaxBrackets.HideSelection = false;
            this.lvTaxBrackets.Location = new System.Drawing.Point(23, 101);
            this.lvTaxBrackets.Name = "lvTaxBrackets";
            this.lvTaxBrackets.Size = new System.Drawing.Size(605, 129);
            this.lvTaxBrackets.TabIndex = 6;
            this.lvTaxBrackets.UseCompatibleStateImageBehavior = false;
            this.lvTaxBrackets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tax Bracket";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount Owed";
            this.columnHeader2.Width = 300;
            // 
            // lblAGIValue
            // 
            this.lblAGIValue.AutoSize = true;
            this.lblAGIValue.Location = new System.Drawing.Point(112, 76);
            this.lblAGIValue.Name = "lblAGIValue";
            this.lblAGIValue.Size = new System.Drawing.Size(34, 13);
            this.lblAGIValue.TabIndex = 5;
            this.lblAGIValue.Text = "$0.00";
            // 
            // lblDeductionsValue
            // 
            this.lblDeductionsValue.AutoSize = true;
            this.lblDeductionsValue.Location = new System.Drawing.Point(112, 51);
            this.lblDeductionsValue.Name = "lblDeductionsValue";
            this.lblDeductionsValue.Size = new System.Drawing.Size(34, 13);
            this.lblDeductionsValue.TabIndex = 4;
            this.lblDeductionsValue.Text = "$0.00";
            // 
            // lblGrossValue
            // 
            this.lblGrossValue.AutoSize = true;
            this.lblGrossValue.Location = new System.Drawing.Point(112, 26);
            this.lblGrossValue.Name = "lblGrossValue";
            this.lblGrossValue.Size = new System.Drawing.Size(34, 13);
            this.lblGrossValue.TabIndex = 3;
            this.lblGrossValue.Text = "$0.00";
            // 
            // lblAGIText
            // 
            this.lblAGIText.AutoSize = true;
            this.lblAGIText.Location = new System.Drawing.Point(23, 76);
            this.lblAGIText.Name = "lblAGIText";
            this.lblAGIText.Size = new System.Drawing.Size(28, 13);
            this.lblAGIText.TabIndex = 2;
            this.lblAGIText.Text = "AGI:";
            // 
            // lblDeductionsText
            // 
            this.lblDeductionsText.AutoSize = true;
            this.lblDeductionsText.Location = new System.Drawing.Point(23, 51);
            this.lblDeductionsText.Name = "lblDeductionsText";
            this.lblDeductionsText.Size = new System.Drawing.Size(64, 13);
            this.lblDeductionsText.TabIndex = 1;
            this.lblDeductionsText.Text = "Deductions:";
            // 
            // lblGrossText
            // 
            this.lblGrossText.AutoSize = true;
            this.lblGrossText.Location = new System.Drawing.Point(23, 26);
            this.lblGrossText.Name = "lblGrossText";
            this.lblGrossText.Size = new System.Drawing.Size(75, 13);
            this.lblGrossText.TabIndex = 0;
            this.lblGrossText.Text = "Gross Income:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalculate.Location = new System.Drawing.Point(265, 235);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Taxes";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(446, 234);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 645);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpDeductions);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpW2);
            this.Name = "Form1";
            this.Text = "Tax Calculator";
            this.grpW2.ResumeLayout(false);
            this.grpW2.PerformLayout();
            this.grpDeductions.ResumeLayout(false);
            this.grpDeductions.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpW2;
        private System.Windows.Forms.GroupBox grpDeductions;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.TextBox txtW2Income;
        private System.Windows.Forms.ListBox lstW2;
        private System.Windows.Forms.Button btnAddW2;
        private System.Windows.Forms.TextBox txtDeduction;
        private System.Windows.Forms.ListBox lstDeductions;
        private System.Windows.Forms.Button btnAddDeduction;
        private System.Windows.Forms.Label lblAGIValue;
        private System.Windows.Forms.Label lblDeductionsValue;
        private System.Windows.Forms.Label lblGrossValue;
        private System.Windows.Forms.Label lblAGIText;
        private System.Windows.Forms.Label lblDeductionsText;
        private System.Windows.Forms.Label lblGrossText;
        private System.Windows.Forms.ListView lvTaxBrackets;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblTotalTaxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAGIPercentageValue;
        private System.Windows.Forms.Label lblAGIPercentageText;
        private System.Windows.Forms.Label lblGrossPercentageValue;
        private System.Windows.Forms.Label lblTotalTaxValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;

    }
}

