namespace WindowsFormsApp1
{
    partial class CoffeeShop
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lboxRestaurants = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txbOrder = new System.Windows.Forms.TextBox();
            this.btnShowList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(333, 265);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(103, 57);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lboxRestaurants
            // 
            this.lboxRestaurants.FormattingEnabled = true;
            this.lboxRestaurants.Location = new System.Drawing.Point(12, 12);
            this.lboxRestaurants.Name = "lboxRestaurants";
            this.lboxRestaurants.Size = new System.Drawing.Size(215, 186);
            this.lboxRestaurants.TabIndex = 1;
            this.lboxRestaurants.SelectedValueChanged += new System.EventHandler(this.lboxRestaurants_SelectedValueChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(495, 265);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 57);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Customer";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(12, 265);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(103, 57);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Add Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txbOrder
            // 
            this.txbOrder.Location = new System.Drawing.Point(286, 12);
            this.txbOrder.Multiline = true;
            this.txbOrder.Name = "txbOrder";
            this.txbOrder.ReadOnly = true;
            this.txbOrder.Size = new System.Drawing.Size(304, 186);
            this.txbOrder.TabIndex = 4;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(174, 265);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(100, 57);
            this.btnShowList.TabIndex = 5;
            this.btnShowList.Text = "Customer With Not Delivered Orders";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "End Date";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(84, 223);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(143, 20);
            this.dtpStart.TabIndex = 10;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(333, 227);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(144, 20);
            this.dtpEnd.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(495, 223);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 354);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.txbOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lboxRestaurants);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "CoffeeShop";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ListBox lboxRestaurants;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txbOrder;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnSearch;
    }
}

