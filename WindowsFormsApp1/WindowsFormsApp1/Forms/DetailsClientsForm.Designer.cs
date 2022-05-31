namespace WindowsFormsApp1.Forms
{
    partial class DetailsClientsForm
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
            this.clientsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsGridView
            // 
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGridView.Location = new System.Drawing.Point(12, 34);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.RowHeadersWidth = 51;
            this.clientsGridView.RowTemplate.Height = 24;
            this.clientsGridView.Size = new System.Drawing.Size(735, 404);
            this.clientsGridView.TabIndex = 0;
            // 
            // DetailsClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.clientsGridView);
            this.Name = "DetailsClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsClientsForm";
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsGridView;
    }
}