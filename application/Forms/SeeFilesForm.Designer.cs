namespace WindowsFormsApp1
{
    partial class SeeFilesForm
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
            this.addFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filesGridView
            // 
            this.filesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesGridView.Location = new System.Drawing.Point(12, 95);
            this.filesGridView.Name = "filesGridView";
            this.filesGridView.RowHeadersWidth = 51;
            this.filesGridView.RowTemplate.Height = 24;
            this.filesGridView.Size = new System.Drawing.Size(611, 330);
            this.filesGridView.TabIndex = 0;
            // 
            // addFileButton
            // 
            this.addFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFileButton.Location = new System.Drawing.Point(21, 12);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(126, 77);
            this.addFileButton.TabIndex = 1;
            this.addFileButton.Text = "Add File";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // SeeFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.filesGridView);
            this.Name = "SeeFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeeFilesForm";
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView filesGridView;
        private System.Windows.Forms.Button addFileButton;
    }
}