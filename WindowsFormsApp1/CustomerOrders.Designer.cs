namespace WindowsFormsApp1
{
    partial class CustomerOrders
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
            this.lboxCustomer = new System.Windows.Forms.ListBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxCustomer
            // 
            this.lboxCustomer.FormattingEnabled = true;
            this.lboxCustomer.Location = new System.Drawing.Point(37, 13);
            this.lboxCustomer.Name = "lboxCustomer";
            this.lboxCustomer.Size = new System.Drawing.Size(214, 303);
            this.lboxCustomer.TabIndex = 0;
            this.lboxCustomer.SelectedIndexChanged += new System.EventHandler(this.lboxCustomer_SelectedIndexChanged);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(281, 12);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(354, 304);
            this.txtOrder.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(550, 343);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(117, 51);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // CustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 416);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.lboxCustomer);
            this.Name = "CustomerOrders";
            this.Text = "CustomerOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxCustomer;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button btnOk;
    }
}