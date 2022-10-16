namespace WindowsFormsApp1
{
    partial class SeeInvoicesForm
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
            this.invoicesGridView = new System.Windows.Forms.DataGridView();
            this.addInvoiceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesGridView
            // 
            this.invoicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesGridView.Location = new System.Drawing.Point(12, 90);
            this.invoicesGridView.Name = "invoicesGridView";
            this.invoicesGridView.RowHeadersWidth = 51;
            this.invoicesGridView.RowTemplate.Height = 24;
            this.invoicesGridView.Size = new System.Drawing.Size(1150, 348);
            this.invoicesGridView.TabIndex = 0;
            // 
            // addInvoiceButton
            // 
            this.addInvoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvoiceButton.Location = new System.Drawing.Point(12, 12);
            this.addInvoiceButton.Name = "addInvoiceButton";
            this.addInvoiceButton.Size = new System.Drawing.Size(148, 72);
            this.addInvoiceButton.TabIndex = 1;
            this.addInvoiceButton.Text = "Add invoice";
            this.addInvoiceButton.UseVisualStyleBackColor = true;
            this.addInvoiceButton.Click += new System.EventHandler(this.addInvoiceButton_Click);
            // 
            // SeeInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 450);
            this.Controls.Add(this.addInvoiceButton);
            this.Controls.Add(this.invoicesGridView);
            this.Name = "SeeInvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeeInvoicesForm";
            ((System.ComponentModel.ISupportInitialize)(this.invoicesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView invoicesGridView;
        private System.Windows.Forms.Button addInvoiceButton;
    }
}