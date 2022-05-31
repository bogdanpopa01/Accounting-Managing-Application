namespace WindowsFormsApp1.Forms
{
    partial class DetailsFilesForm
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
            this.filesGridView = new System.Windows.Forms.DataGridView();
            this.addClientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filesGridView
            // 
            this.filesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesGridView.Location = new System.Drawing.Point(12, 86);
            this.filesGridView.Name = "filesGridView";
            this.filesGridView.RowHeadersWidth = 51;
            this.filesGridView.RowTemplate.Height = 24;
            this.filesGridView.Size = new System.Drawing.Size(1117, 352);
            this.filesGridView.TabIndex = 0;
            // 
            // addClientButton
            // 
            this.addClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.Location = new System.Drawing.Point(12, 12);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(128, 62);
            this.addClientButton.TabIndex = 1;
            this.addClientButton.Text = "Add client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // DetailsFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.filesGridView);
            this.Name = "DetailsFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsFilesForm";
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView filesGridView;
        private System.Windows.Forms.Button addClientButton;
    }
}