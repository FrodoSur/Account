namespace Account
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.findId = new System.Windows.Forms.Button();
            this.idInsert = new System.Windows.Forms.TextBox();
            this.addRecord = new System.Windows.Forms.Button();
            this.Records = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findId
            // 
            this.findId.Location = new System.Drawing.Point(226, 32);
            this.findId.Name = "findId";
            this.findId.Size = new System.Drawing.Size(56, 20);
            this.findId.TabIndex = 0;
            this.findId.Text = "Найти";
            this.findId.UseVisualStyleBackColor = true;
            this.findId.Click += new System.EventHandler(this.findId_Click);
            // 
            // idInsert
            // 
            this.idInsert.Location = new System.Drawing.Point(12, 32);
            this.idInsert.Name = "idInsert";
            this.idInsert.Size = new System.Drawing.Size(208, 20);
            this.idInsert.TabIndex = 1;
            this.idInsert.TextChanged += new System.EventHandler(this.idInsert_TextChanged);
            // 
            // addRecord
            // 
            this.addRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRecord.Location = new System.Drawing.Point(611, 55);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(186, 20);
            this.addRecord.TabIndex = 2;
            this.addRecord.Text = "Добавить запись";
            this.addRecord.UseVisualStyleBackColor = true;
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // Records
            // 
            this.Records.AutoSize = true;
            this.Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records.ForeColor = System.Drawing.SystemColors.Control;
            this.Records.Location = new System.Drawing.Point(12, 55);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(0, 24);
            this.Records.TabIndex = 3;
            this.Records.Click += new System.EventHandler(this.Records_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(611, 29);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(186, 20);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.addRecord);
            this.Controls.Add(this.idInsert);
            this.Controls.Add(this.findId);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findId;
        private System.Windows.Forms.TextBox idInsert;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.Label Records;
        private System.Windows.Forms.Button Exit;
    }
}

