namespace Week4_CoffeeSales
{
    partial class BillingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemAmountTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.taxCheckBox = new System.Windows.Forms.CheckBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.icedCappuccinoRadioButton = new System.Windows.Forms.RadioButton();
            this.icedLatteRadioButton = new System.Windows.Forms.RadioButton();
            this.latteRadioButton = new System.Windows.Forms.RadioButton();
            this.espressoRadioButton = new System.Windows.Forms.RadioButton();
            this.cappuccinoRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Luis Acevedo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemAmountTextBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.calculateButton);
            this.groupBox1.Controls.Add(this.taxCheckBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // itemAmountTextBox
            // 
            this.itemAmountTextBox.Location = new System.Drawing.Point(99, 147);
            this.itemAmountTextBox.Name = "itemAmountTextBox";
            this.itemAmountTextBox.ReadOnly = true;
            this.itemAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemAmountTextBox.TabIndex = 7;
            this.itemAmountTextBox.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(124, 94);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 40);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear for Next Item";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(20, 94);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 40);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "&Calculate Selection";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // taxCheckBox
            // 
            this.taxCheckBox.AutoSize = true;
            this.taxCheckBox.Location = new System.Drawing.Point(20, 62);
            this.taxCheckBox.Name = "taxCheckBox";
            this.taxCheckBox.Size = new System.Drawing.Size(72, 17);
            this.taxCheckBox.TabIndex = 3;
            this.taxCheckBox.Text = "Ta&keout?";
            this.taxCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(76, 25);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Item Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Quantity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.icedCappuccinoRadioButton);
            this.groupBox2.Controls.Add(this.icedLatteRadioButton);
            this.groupBox2.Controls.Add(this.latteRadioButton);
            this.groupBox2.Controls.Add(this.espressoRadioButton);
            this.groupBox2.Controls.Add(this.cappuccinoRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(218, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coffee Selections";
            // 
            // icedCappuccinoRadioButton
            // 
            this.icedCappuccinoRadioButton.AutoSize = true;
            this.icedCappuccinoRadioButton.Location = new System.Drawing.Point(19, 112);
            this.icedCappuccinoRadioButton.Name = "icedCappuccinoRadioButton";
            this.icedCappuccinoRadioButton.Size = new System.Drawing.Size(106, 17);
            this.icedCappuccinoRadioButton.TabIndex = 4;
            this.icedCappuccinoRadioButton.Text = "Iced Ca&ppuccino";
            this.icedCappuccinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // icedLatteRadioButton
            // 
            this.icedLatteRadioButton.AutoSize = true;
            this.icedLatteRadioButton.Location = new System.Drawing.Point(19, 88);
            this.icedLatteRadioButton.Name = "icedLatteRadioButton";
            this.icedLatteRadioButton.Size = new System.Drawing.Size(73, 17);
            this.icedLatteRadioButton.TabIndex = 3;
            this.icedLatteRadioButton.Text = "&Iced Latte";
            this.icedLatteRadioButton.UseVisualStyleBackColor = true;
            // 
            // latteRadioButton
            // 
            this.latteRadioButton.AutoSize = true;
            this.latteRadioButton.Location = new System.Drawing.Point(19, 64);
            this.latteRadioButton.Name = "latteRadioButton";
            this.latteRadioButton.Size = new System.Drawing.Size(49, 17);
            this.latteRadioButton.TabIndex = 2;
            this.latteRadioButton.Text = "La&tte";
            this.latteRadioButton.UseVisualStyleBackColor = true;
            // 
            // espressoRadioButton
            // 
            this.espressoRadioButton.AutoSize = true;
            this.espressoRadioButton.Location = new System.Drawing.Point(19, 40);
            this.espressoRadioButton.Name = "espressoRadioButton";
            this.espressoRadioButton.Size = new System.Drawing.Size(68, 17);
            this.espressoRadioButton.TabIndex = 1;
            this.espressoRadioButton.Text = "Espress&o";
            this.espressoRadioButton.UseVisualStyleBackColor = true;
            // 
            // cappuccinoRadioButton
            // 
            this.cappuccinoRadioButton.AutoSize = true;
            this.cappuccinoRadioButton.Location = new System.Drawing.Point(19, 16);
            this.cappuccinoRadioButton.Name = "cappuccinoRadioButton";
            this.cappuccinoRadioButton.Size = new System.Drawing.Size(82, 17);
            this.cappuccinoRadioButton.TabIndex = 0;
            this.cappuccinoRadioButton.Text = "C&appuccino";
            this.cappuccinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalTextBox);
            this.groupBox3.Controls.Add(this.taxTextBox);
            this.groupBox3.Controls.Add(this.subTotalTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(16, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 125);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount Due";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(124, 83);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(123, 20);
            this.totalTextBox.TabIndex = 5;
            this.totalTextBox.TabStop = false;
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(124, 53);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.ReadOnly = true;
            this.taxTextBox.Size = new System.Drawing.Size(123, 20);
            this.taxTextBox.TabIndex = 4;
            this.taxTextBox.TabStop = false;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(124, 23);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(123, 20);
            this.subTotalTextBox.TabIndex = 3;
            this.subTotalTextBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Due";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tax ( if takeout)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subtotal";
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(50, 400);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(75, 23);
            this.newOrderButton.TabIndex = 1;
            this.newOrderButton.Text = "&New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(198, 400);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(75, 23);
            this.summaryButton.TabIndex = 2;
            this.summaryButton.Text = "&Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(346, 400);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // BillingForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(477, 472);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R for Reading and Refreshment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox itemAmountTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.CheckBox taxCheckBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton icedCappuccinoRadioButton;
        private System.Windows.Forms.RadioButton icedLatteRadioButton;
        private System.Windows.Forms.RadioButton latteRadioButton;
        private System.Windows.Forms.RadioButton espressoRadioButton;
        private System.Windows.Forms.RadioButton cappuccinoRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button exitButton;
    }
}

