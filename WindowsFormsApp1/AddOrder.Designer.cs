namespace WindowsFormsApp1
{
    partial class AddOrder
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTea = new System.Windows.Forms.RadioButton();
            this.rbtnCoffee = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnSandwichEggSalad = new System.Windows.Forms.RadioButton();
            this.rbtnSandwichRoastBeef = new System.Windows.Forms.RadioButton();
            this.rbtnSandwichBacon = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numSweetner = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numSugar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numMilk = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numCheese = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numTomato = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numLettuce = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numMayo = new System.Windows.Forms.NumericUpDown();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSweetner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMilk)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTomato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLettuce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMayo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(375, 464);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(266, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnItem
            // 
            this.btnItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnItem.Location = new System.Drawing.Point(9, 464);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(75, 23);
            this.btnItem.TabIndex = 2;
            this.btnItem.Text = "Add Item";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTea);
            this.groupBox1.Controls.Add(this.rbtnCoffee);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(199, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drinks";
            // 
            // rbtnTea
            // 
            this.rbtnTea.AutoSize = true;
            this.rbtnTea.Location = new System.Drawing.Point(4, 44);
            this.rbtnTea.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnTea.Name = "rbtnTea";
            this.rbtnTea.Size = new System.Drawing.Size(44, 17);
            this.rbtnTea.TabIndex = 0;
            this.rbtnTea.TabStop = true;
            this.rbtnTea.Text = "Tea";
            this.rbtnTea.UseVisualStyleBackColor = true;
            // 
            // rbtnCoffee
            // 
            this.rbtnCoffee.AutoSize = true;
            this.rbtnCoffee.Location = new System.Drawing.Point(4, 25);
            this.rbtnCoffee.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnCoffee.Name = "rbtnCoffee";
            this.rbtnCoffee.Size = new System.Drawing.Size(113, 17);
            this.rbtnCoffee.TabIndex = 0;
            this.rbtnCoffee.TabStop = true;
            this.rbtnCoffee.Text = "Dark Roast Coffee";
            this.rbtnCoffee.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnSandwichEggSalad);
            this.groupBox2.Controls.Add(this.rbtnSandwichRoastBeef);
            this.groupBox2.Controls.Add(this.rbtnSandwichBacon);
            this.groupBox2.Location = new System.Drawing.Point(244, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(205, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sandwiches";
            // 
            // rbtnSandwichEggSalad
            // 
            this.rbtnSandwichEggSalad.AutoSize = true;
            this.rbtnSandwichEggSalad.Location = new System.Drawing.Point(22, 65);
            this.rbtnSandwichEggSalad.Name = "rbtnSandwichEggSalad";
            this.rbtnSandwichEggSalad.Size = new System.Drawing.Size(149, 17);
            this.rbtnSandwichEggSalad.TabIndex = 2;
            this.rbtnSandwichEggSalad.TabStop = true;
            this.rbtnSandwichEggSalad.Text = "Sandwich With Egg Salad";
            this.rbtnSandwichEggSalad.UseVisualStyleBackColor = true;
            // 
            // rbtnSandwichRoastBeef
            // 
            this.rbtnSandwichRoastBeef.AutoSize = true;
            this.rbtnSandwichRoastBeef.Location = new System.Drawing.Point(22, 44);
            this.rbtnSandwichRoastBeef.Name = "rbtnSandwichRoastBeef";
            this.rbtnSandwichRoastBeef.Size = new System.Drawing.Size(165, 17);
            this.rbtnSandwichRoastBeef.TabIndex = 1;
            this.rbtnSandwichRoastBeef.TabStop = true;
            this.rbtnSandwichRoastBeef.Text = "Sandwich With Roasted Beef";
            this.rbtnSandwichRoastBeef.UseVisualStyleBackColor = true;
            // 
            // rbtnSandwichBacon
            // 
            this.rbtnSandwichBacon.AutoSize = true;
            this.rbtnSandwichBacon.Location = new System.Drawing.Point(22, 25);
            this.rbtnSandwichBacon.Name = "rbtnSandwichBacon";
            this.rbtnSandwichBacon.Size = new System.Drawing.Size(131, 17);
            this.rbtnSandwichBacon.TabIndex = 0;
            this.rbtnSandwichBacon.TabStop = true;
            this.rbtnSandwichBacon.Text = "Sandwich With Bacon";
            this.rbtnSandwichBacon.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numSweetner);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numSugar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numMilk);
            this.groupBox3.Location = new System.Drawing.Point(9, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(199, 107);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sweetner";
            // 
            // numSweetner
            // 
            this.numSweetner.Location = new System.Drawing.Point(126, 77);
            this.numSweetner.Name = "numSweetner";
            this.numSweetner.Size = new System.Drawing.Size(56, 20);
            this.numSweetner.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sugar";
            // 
            // numSugar
            // 
            this.numSugar.Location = new System.Drawing.Point(126, 50);
            this.numSugar.Name = "numSugar";
            this.numSugar.Size = new System.Drawing.Size(56, 20);
            this.numSugar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Milk";
            // 
            // numMilk
            // 
            this.numMilk.Location = new System.Drawing.Point(126, 27);
            this.numMilk.Name = "numMilk";
            this.numMilk.Size = new System.Drawing.Size(56, 20);
            this.numMilk.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numMayo);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.numCheese);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.numTomato);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.numLettuce);
            this.groupBox4.Location = new System.Drawing.Point(244, 121);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(199, 128);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Additions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cheese";
            // 
            // numCheese
            // 
            this.numCheese.Location = new System.Drawing.Point(131, 61);
            this.numCheese.Name = "numCheese";
            this.numCheese.Size = new System.Drawing.Size(56, 20);
            this.numCheese.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tomato";
            // 
            // numTomato
            // 
            this.numTomato.Location = new System.Drawing.Point(131, 34);
            this.numTomato.Name = "numTomato";
            this.numTomato.Size = new System.Drawing.Size(56, 20);
            this.numTomato.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lettuce";
            // 
            // numLettuce
            // 
            this.numLettuce.Location = new System.Drawing.Point(131, 11);
            this.numLettuce.Name = "numLettuce";
            this.numLettuce.Size = new System.Drawing.Size(56, 20);
            this.numLettuce.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mayo";
            // 
            // numMayo
            // 
            this.numMayo.Location = new System.Drawing.Point(131, 88);
            this.numMayo.Name = "numMayo";
            this.numMayo.Size = new System.Drawing.Size(56, 20);
            this.numMayo.TabIndex = 15;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(18, 254);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(425, 191);
            this.txtOrder.TabIndex = 6;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 499);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSweetner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMilk)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTomato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLettuce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMayo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnTea;
        private System.Windows.Forms.RadioButton rbtnCoffee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnSandwichEggSalad;
        private System.Windows.Forms.RadioButton rbtnSandwichRoastBeef;
        private System.Windows.Forms.RadioButton rbtnSandwichBacon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numMilk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSweetner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCheese;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTomato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numLettuce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numMayo;
        private System.Windows.Forms.TextBox txtOrder;
    }
}