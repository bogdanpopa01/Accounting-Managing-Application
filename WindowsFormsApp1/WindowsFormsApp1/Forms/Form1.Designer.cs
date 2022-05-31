namespace WindowsFormsApp1
{
    partial class Form1
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
            this.goSeeFilesButton = new System.Windows.Forms.Button();
            this.seeClientsButton = new System.Windows.Forms.Button();
            this.seeInvoicesButton = new System.Windows.Forms.Button();
            this.sFilesButton = new System.Windows.Forms.Button();
            this.sClientsButton = new System.Windows.Forms.Button();
            this.sInvoicesButton = new System.Windows.Forms.Button();
            this.dFilesButton = new System.Windows.Forms.Button();
            this.dClientsButton = new System.Windows.Forms.Button();
            this.dInvoicesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goSeeFilesButton
            // 
            this.goSeeFilesButton.BackColor = System.Drawing.Color.OrangeRed;
            this.goSeeFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goSeeFilesButton.Location = new System.Drawing.Point(34, 12);
            this.goSeeFilesButton.Name = "goSeeFilesButton";
            this.goSeeFilesButton.Size = new System.Drawing.Size(199, 101);
            this.goSeeFilesButton.TabIndex = 0;
            this.goSeeFilesButton.Text = "Edit Files";
            this.goSeeFilesButton.UseVisualStyleBackColor = false;
            this.goSeeFilesButton.Click += new System.EventHandler(this.goSeeFilesButton_Click);
            // 
            // seeClientsButton
            // 
            this.seeClientsButton.BackColor = System.Drawing.Color.OrangeRed;
            this.seeClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeClientsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.seeClientsButton.Location = new System.Drawing.Point(34, 139);
            this.seeClientsButton.Name = "seeClientsButton";
            this.seeClientsButton.Size = new System.Drawing.Size(199, 106);
            this.seeClientsButton.TabIndex = 3;
            this.seeClientsButton.Text = "Edit Clients";
            this.seeClientsButton.UseVisualStyleBackColor = false;
            this.seeClientsButton.Click += new System.EventHandler(this.seeClientsButton_Click);
            // 
            // seeInvoicesButton
            // 
            this.seeInvoicesButton.BackColor = System.Drawing.Color.OrangeRed;
            this.seeInvoicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeInvoicesButton.Location = new System.Drawing.Point(34, 273);
            this.seeInvoicesButton.Name = "seeInvoicesButton";
            this.seeInvoicesButton.Size = new System.Drawing.Size(199, 99);
            this.seeInvoicesButton.TabIndex = 5;
            this.seeInvoicesButton.Text = "Edit Invoices";
            this.seeInvoicesButton.UseVisualStyleBackColor = false;
            this.seeInvoicesButton.Click += new System.EventHandler(this.seeInvoicesButton_Click);
            // 
            // sFilesButton
            // 
            this.sFilesButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sFilesButton.ForeColor = System.Drawing.Color.Black;
            this.sFilesButton.Location = new System.Drawing.Point(275, 12);
            this.sFilesButton.Name = "sFilesButton";
            this.sFilesButton.Size = new System.Drawing.Size(196, 106);
            this.sFilesButton.TabIndex = 6;
            this.sFilesButton.Text = "Serialize the files";
            this.sFilesButton.UseVisualStyleBackColor = false;
            this.sFilesButton.Click += new System.EventHandler(this.sFilesButton_Click);
            // 
            // sClientsButton
            // 
            this.sClientsButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sClientsButton.Location = new System.Drawing.Point(275, 139);
            this.sClientsButton.Name = "sClientsButton";
            this.sClientsButton.Size = new System.Drawing.Size(196, 106);
            this.sClientsButton.TabIndex = 7;
            this.sClientsButton.Text = "Serialize the clients";
            this.sClientsButton.UseVisualStyleBackColor = false;
            this.sClientsButton.Click += new System.EventHandler(this.sClientsButton_Click);
            // 
            // sInvoicesButton
            // 
            this.sInvoicesButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sInvoicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sInvoicesButton.Location = new System.Drawing.Point(275, 269);
            this.sInvoicesButton.Name = "sInvoicesButton";
            this.sInvoicesButton.Size = new System.Drawing.Size(196, 106);
            this.sInvoicesButton.TabIndex = 8;
            this.sInvoicesButton.Text = "Serialize the invoices";
            this.sInvoicesButton.UseVisualStyleBackColor = false;
            this.sInvoicesButton.Click += new System.EventHandler(this.sInvoicesButton_Click);
            // 
            // dFilesButton
            // 
            this.dFilesButton.BackColor = System.Drawing.Color.SteelBlue;
            this.dFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dFilesButton.Location = new System.Drawing.Point(518, 12);
            this.dFilesButton.Name = "dFilesButton";
            this.dFilesButton.Size = new System.Drawing.Size(196, 106);
            this.dFilesButton.TabIndex = 9;
            this.dFilesButton.Text = "Deserialize the files";
            this.dFilesButton.UseVisualStyleBackColor = false;
            this.dFilesButton.Click += new System.EventHandler(this.dFilesButton_Click);
            // 
            // dClientsButton
            // 
            this.dClientsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.dClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dClientsButton.Location = new System.Drawing.Point(518, 139);
            this.dClientsButton.Name = "dClientsButton";
            this.dClientsButton.Size = new System.Drawing.Size(196, 106);
            this.dClientsButton.TabIndex = 10;
            this.dClientsButton.Text = "Deserialize the clients";
            this.dClientsButton.UseVisualStyleBackColor = false;
            this.dClientsButton.Click += new System.EventHandler(this.dClientsButton_Click);
            // 
            // dInvoicesButton
            // 
            this.dInvoicesButton.BackColor = System.Drawing.Color.SteelBlue;
            this.dInvoicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dInvoicesButton.Location = new System.Drawing.Point(518, 273);
            this.dInvoicesButton.Name = "dInvoicesButton";
            this.dInvoicesButton.Size = new System.Drawing.Size(196, 106);
            this.dInvoicesButton.TabIndex = 11;
            this.dInvoicesButton.Text = "Deserialize the invoices";
            this.dInvoicesButton.UseVisualStyleBackColor = false;
            this.dInvoicesButton.Click += new System.EventHandler(this.dInvoicesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 398);
            this.Controls.Add(this.dInvoicesButton);
            this.Controls.Add(this.dClientsButton);
            this.Controls.Add(this.dFilesButton);
            this.Controls.Add(this.sInvoicesButton);
            this.Controls.Add(this.sClientsButton);
            this.Controls.Add(this.sFilesButton);
            this.Controls.Add(this.seeInvoicesButton);
            this.Controls.Add(this.seeClientsButton);
            this.Controls.Add(this.goSeeFilesButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goSeeFilesButton;
        private System.Windows.Forms.Button seeClientsButton;
        private System.Windows.Forms.Button seeInvoicesButton;
        private System.Windows.Forms.Button sFilesButton;
        private System.Windows.Forms.Button sClientsButton;
        private System.Windows.Forms.Button sInvoicesButton;
        private System.Windows.Forms.Button dFilesButton;
        private System.Windows.Forms.Button dClientsButton;
        private System.Windows.Forms.Button dInvoicesButton;
    }
}

