namespace WindowsFormsApp1.Forms
{
    partial class DetailsFilesFormUser
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
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filesGridView
            // 
            this.filesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesGridView.Location = new System.Drawing.Point(2, 28);
            this.filesGridView.Name = "filesGridView";
            this.filesGridView.RowHeadersWidth = 51;
            this.filesGridView.RowTemplate.Height = 24;
            this.filesGridView.Size = new System.Drawing.Size(734, 400);
            this.filesGridView.TabIndex = 0;
            // 
            // DetailsFilesFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.filesGridView);
            this.Name = "DetailsFilesFormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsFilesFormUser";
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView filesGridView;
    }
}