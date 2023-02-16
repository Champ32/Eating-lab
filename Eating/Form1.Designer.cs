namespace Eating
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMainCourse1 = new System.Windows.Forms.GroupBox();
            this.radioSalad = new System.Windows.Forms.RadioButton();
            this.radioPizza = new System.Windows.Forms.RadioButton();
            this.radioHamburger = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOption3 = new System.Windows.Forms.CheckBox();
            this.chkOption2 = new System.Windows.Forms.CheckBox();
            this.chkOption1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpMainCourse1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainCourse1
            // 
            this.grpMainCourse1.Controls.Add(this.radioSalad);
            this.grpMainCourse1.Controls.Add(this.radioPizza);
            this.grpMainCourse1.Controls.Add(this.radioHamburger);
            this.grpMainCourse1.Location = new System.Drawing.Point(111, 44);
            this.grpMainCourse1.Name = "grpMainCourse1";
            this.grpMainCourse1.Size = new System.Drawing.Size(245, 200);
            this.grpMainCourse1.TabIndex = 0;
            this.grpMainCourse1.TabStop = false;
            this.grpMainCourse1.Text = "Main Course";
            // 
            // radioSalad
            // 
            this.radioSalad.AutoSize = true;
            this.radioSalad.Location = new System.Drawing.Point(12, 127);
            this.radioSalad.Name = "radioSalad";
            this.radioSalad.Size = new System.Drawing.Size(102, 36);
            this.radioSalad.TabIndex = 2;
            this.radioSalad.Text = "Salad";
            this.radioSalad.UseVisualStyleBackColor = true;
            this.radioSalad.CheckedChanged += new System.EventHandler(this.radioSalad_CheckedChanged);
            // 
            // radioPizza
            // 
            this.radioPizza.AutoSize = true;
            this.radioPizza.Location = new System.Drawing.Point(13, 85);
            this.radioPizza.Name = "radioPizza";
            this.radioPizza.Size = new System.Drawing.Size(98, 36);
            this.radioPizza.TabIndex = 1;
            this.radioPizza.Text = "Pizza";
            this.radioPizza.UseVisualStyleBackColor = true;
            this.radioPizza.CheckedChanged += new System.EventHandler(this.radioPizza_CheckedChanged);
            // 
            // radioHamburger
            // 
            this.radioHamburger.AutoSize = true;
            this.radioHamburger.Checked = true;
            this.radioHamburger.Location = new System.Drawing.Point(13, 50);
            this.radioHamburger.Name = "radioHamburger";
            this.radioHamburger.Size = new System.Drawing.Size(173, 36);
            this.radioHamburger.TabIndex = 0;
            this.radioHamburger.TabStop = true;
            this.radioHamburger.Text = "Hamburger ";
            this.radioHamburger.UseVisualStyleBackColor = true;
            this.radioHamburger.CheckedChanged += new System.EventHandler(this.radioHamburger_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOption3);
            this.groupBox1.Controls.Add(this.chkOption2);
            this.groupBox1.Controls.Add(this.chkOption1);
            this.groupBox1.Location = new System.Drawing.Point(403, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add-on items ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkOption3
            // 
            this.chkOption3.AutoSize = true;
            this.chkOption3.Location = new System.Drawing.Point(3, 155);
            this.chkOption3.Name = "chkOption3";
            this.chkOption3.Size = new System.Drawing.Size(159, 36);
            this.chkOption3.TabIndex = 2;
            this.chkOption3.Text = "checkBox3";
            this.chkOption3.UseVisualStyleBackColor = true;
            this.chkOption3.CheckedChanged += new System.EventHandler(this.chkOption3_CheckedChanged);
            // 
            // chkOption2
            // 
            this.chkOption2.AutoSize = true;
            this.chkOption2.Location = new System.Drawing.Point(6, 103);
            this.chkOption2.Name = "chkOption2";
            this.chkOption2.Size = new System.Drawing.Size(159, 36);
            this.chkOption2.TabIndex = 1;
            this.chkOption2.Text = "checkBox2";
            this.chkOption2.UseVisualStyleBackColor = true;
            this.chkOption2.CheckedChanged += new System.EventHandler(this.chkOption2_CheckedChanged);
            // 
            // chkOption1
            // 
            this.chkOption1.AutoSize = true;
            this.chkOption1.Location = new System.Drawing.Point(6, 49);
            this.chkOption1.Name = "chkOption1";
            this.chkOption1.Size = new System.Drawing.Size(159, 36);
            this.chkOption1.TabIndex = 0;
            this.chkOption1.Text = "checkBox1";
            this.chkOption1.UseVisualStyleBackColor = true;
            this.chkOption1.CheckedChanged += new System.EventHandler(this.chkOption1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOrderTotal);
            this.groupBox2.Controls.Add(this.txtSalesTax);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(50, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(144, 141);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(200, 39);
            this.txtOrderTotal.TabIndex = 5;
            this.txtOrderTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(144, 93);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.Size = new System.Drawing.Size(200, 39);
            this.txtSalesTax.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(144, 44);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(200, 39);
            this.txtSubtotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(498, 290);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(150, 46);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(498, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(498, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 46);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Robert Champion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 784);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpMainCourse1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMainCourse1.ResumeLayout(false);
            this.grpMainCourse1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpMainCourse1;
        private RadioButton radioSalad;
        private RadioButton radioPizza;
        private RadioButton radioHamburger;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtOrderTotal;
        private TextBox txtSalesTax;
        private TextBox txtSubtotal;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkOption3;
        private CheckBox chkOption2;
        private CheckBox chkOption1;
        private Button btnPlaceOrder;
        private Button btnExit;
        private Button btnClear;
        private Label label4;
    }
}