using System.Runtime.CompilerServices;

namespace TaxCalculation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox taxMultiplier;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label labelAmountPrompt;
        private System.Windows.Forms.Label labelTypePrompt;
        private System.Windows.Forms.Label labelTotalPrompt;
        private System.Windows.Forms.Label labelTaxPrompt;
        private System.Windows.Forms.Label labelTotalValue;
        private System.Windows.Forms.Label labelTaxValue;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            taxMultiplier = new ComboBox();
            calculateBtn = new Button();
            labelAmountPrompt = new Label();
            labelTypePrompt = new Label();
            labelTotalPrompt = new Label();
            labelTaxPrompt = new Label();
            labelTotalValue = new Label();
            labelTaxValue = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 0;
            // 
            // taxMultiplier
            // 
            taxMultiplier.DropDownStyle = ComboBoxStyle.DropDownList;
            taxMultiplier.FormattingEnabled = true;
            taxMultiplier.Location = new Point(220, 85);
            taxMultiplier.Name = "taxMultiplier";
            taxMultiplier.Size = new Size(209, 23);
            taxMultiplier.TabIndex = 1;
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(454, 211);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(100, 27);
            calculateBtn.TabIndex = 2;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // labelAmountPrompt
            // 
            labelAmountPrompt.AutoSize = true;
            labelAmountPrompt.Location = new Point(40, 43);
            labelAmountPrompt.Name = "labelAmountPrompt";
            labelAmountPrompt.Size = new Size(88, 15);
            labelAmountPrompt.TabIndex = 3;
            labelAmountPrompt.Text = "Value of goods:";
            // 
            // labelTypePrompt
            // 
            labelTypePrompt.AutoSize = true;
            labelTypePrompt.Location = new Point(40, 88);
            labelTypePrompt.Name = "labelTypePrompt";
            labelTypePrompt.Size = new Size(78, 15);
            labelTypePrompt.TabIndex = 4;
            labelTypePrompt.Text = "Tax Category:";
            // 
            // labelTotalPrompt
            // 
            labelTotalPrompt.AutoSize = true;
            labelTotalPrompt.Location = new Point(40, 176);
            labelTotalPrompt.Name = "labelTotalPrompt";
            labelTotalPrompt.Size = new Size(64, 15);
            labelTotalPrompt.TabIndex = 5;
            labelTotalPrompt.Text = "Total value";
            // 
            // labelTaxPrompt
            // 
            labelTaxPrompt.AutoSize = true;
            labelTaxPrompt.Location = new Point(40, 151);
            labelTaxPrompt.Name = "labelTaxPrompt";
            labelTaxPrompt.Size = new Size(92, 15);
            labelTaxPrompt.TabIndex = 6;
            labelTaxPrompt.Text = "Value added tax:";
            // 
            // labelTotalValue
            // 
            labelTotalValue.AutoSize = true;
            labelTotalValue.Location = new Point(220, 176);
            labelTotalValue.Name = "labelTotalValue";
            labelTotalValue.Size = new Size(28, 15);
            labelTotalValue.TabIndex = 7;
            labelTotalValue.Text = "0.00";
            // 
            // labelTaxValue
            // 
            labelTaxValue.AutoSize = true;
            labelTaxValue.Location = new Point(220, 151);
            labelTaxValue.Name = "labelTaxValue";
            labelTaxValue.Size = new Size(28, 15);
            labelTaxValue.TabIndex = 8;
            labelTaxValue.Text = "0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 309);
            Controls.Add(labelTaxValue);
            Controls.Add(labelTotalValue);
            Controls.Add(labelTaxPrompt);
            Controls.Add(labelTotalPrompt);
            Controls.Add(labelTypePrompt);
            Controls.Add(labelAmountPrompt);
            Controls.Add(calculateBtn);
            Controls.Add(taxMultiplier);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Value added tax";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
