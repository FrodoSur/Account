namespace Account
{
    partial class FillingInForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.exit = new System.Windows.Forms.Button();
            this.completeRecording = new System.Windows.Forms.Button();
            this.hasCard = new System.Windows.Forms.CheckBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.idPurchase = new System.Windows.Forms.TextBox();
            this.idPurchaseLabel = new System.Windows.Forms.Label();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.idCustomer = new System.Windows.Forms.TextBox();
            this.idCustomerLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.purchaseDate);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.completeRecording);
            this.panel1.Controls.Add(this.hasCard);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.idPurchase);
            this.panel1.Controls.Add(this.idPurchaseLabel);
            this.panel1.Controls.Add(this.purchaseDateLabel);
            this.panel1.Controls.Add(this.idCustomer);
            this.panel1.Controls.Add(this.idCustomerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // purchaseDate
            // 
            this.purchaseDate.Location = new System.Drawing.Point(16, 94);
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.Size = new System.Drawing.Size(200, 20);
            this.purchaseDate.TabIndex = 11;
            this.purchaseDate.ValueChanged += new System.EventHandler(this.purchaseDate_ValueChanged);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.Location = new System.Drawing.Point(677, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(111, 37);
            this.exit.TabIndex = 10;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // completeRecording
            // 
            this.completeRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeRecording.Location = new System.Drawing.Point(16, 285);
            this.completeRecording.Name = "completeRecording";
            this.completeRecording.Size = new System.Drawing.Size(161, 35);
            this.completeRecording.TabIndex = 9;
            this.completeRecording.Text = "Завершить";
            this.completeRecording.UseVisualStyleBackColor = true;
            this.completeRecording.Click += new System.EventHandler(this.completeRecording_Click);
            // 
            // hasCard
            // 
            this.hasCard.AutoSize = true;
            this.hasCard.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hasCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hasCard.ForeColor = System.Drawing.SystemColors.Control;
            this.hasCard.Location = new System.Drawing.Point(12, 228);
            this.hasCard.Name = "hasCard";
            this.hasCard.Size = new System.Drawing.Size(356, 28);
            this.hasCard.TabIndex = 8;
            this.hasCard.Text = "Есть карта постоянного покупателя";
            this.hasCard.UseVisualStyleBackColor = true;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(16, 198);
            this.amount.Multiline = true;
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(126, 24);
            this.amount.TabIndex = 7;
            this.amount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.amountLabel.Location = new System.Drawing.Point(12, 171);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(117, 24);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Количество";
            // 
            // idPurchase
            // 
            this.idPurchase.Location = new System.Drawing.Point(16, 144);
            this.idPurchase.Multiline = true;
            this.idPurchase.Name = "idPurchase";
            this.idPurchase.Size = new System.Drawing.Size(126, 24);
            this.idPurchase.TabIndex = 5;
            // 
            // idPurchaseLabel
            // 
            this.idPurchaseLabel.AutoSize = true;
            this.idPurchaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idPurchaseLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.idPurchaseLabel.Location = new System.Drawing.Point(12, 117);
            this.idPurchaseLabel.Name = "idPurchaseLabel";
            this.idPurchaseLabel.Size = new System.Drawing.Size(95, 24);
            this.idPurchaseLabel.TabIndex = 4;
            this.idPurchaseLabel.Text = "ID товара";
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseDateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.purchaseDateLabel.Location = new System.Drawing.Point(12, 63);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(130, 24);
            this.purchaseDateLabel.TabIndex = 2;
            this.purchaseDateLabel.Text = "Дата покупки";
            // 
            // idCustomer
            // 
            this.idCustomer.Location = new System.Drawing.Point(16, 36);
            this.idCustomer.Multiline = true;
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.Size = new System.Drawing.Size(126, 24);
            this.idCustomer.TabIndex = 1;
            this.idCustomer.TextChanged += new System.EventHandler(this.idCustomer_TextChanged);
            // 
            // idCustomerLabel
            // 
            this.idCustomerLabel.AutoSize = true;
            this.idCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCustomerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.idCustomerLabel.Location = new System.Drawing.Point(12, 9);
            this.idCustomerLabel.Name = "idCustomerLabel";
            this.idCustomerLabel.Size = new System.Drawing.Size(134, 24);
            this.idCustomerLabel.TabIndex = 0;
            this.idCustomerLabel.Text = "ID покупателя";
            // 
            // FillingInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FillingInForm";
            this.Text = "FillingInForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button completeRecording;
        private System.Windows.Forms.CheckBox hasCard;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox idPurchase;
        private System.Windows.Forms.Label idPurchaseLabel;
        private System.Windows.Forms.Label purchaseDateLabel;
        private System.Windows.Forms.TextBox idCustomer;
        private System.Windows.Forms.Label idCustomerLabel;
        private System.Windows.Forms.DateTimePicker purchaseDate;
    }
}