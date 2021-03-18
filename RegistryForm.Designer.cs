namespace Account
{
    partial class RegistryForm
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
            this.Connect = new System.Windows.Forms.Button();
            this.serverIns = new System.Windows.Forms.TextBox();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.portNumberLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.dataBaseLabel = new System.Windows.Forms.Label();
            this.portIns = new System.Windows.Forms.TextBox();
            this.userNameIns = new System.Windows.Forms.TextBox();
            this.passwordIns = new System.Windows.Forms.TextBox();
            this.dataBaseIns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(16, 296);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(144, 47);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Подключиться к базе данных";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // serverIns
            // 
            this.serverIns.Location = new System.Drawing.Point(16, 40);
            this.serverIns.Multiline = true;
            this.serverIns.Name = "serverIns";
            this.serverIns.Size = new System.Drawing.Size(126, 24);
            this.serverIns.TabIndex = 13;
            this.serverIns.Text = "localHost";
            this.serverIns.TextChanged += new System.EventHandler(this.serverIns_TextChanged);
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.serverNameLabel.Location = new System.Drawing.Point(12, 13);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(126, 24);
            this.serverNameLabel.TabIndex = 12;
            this.serverNameLabel.Text = "Имя сервера";
            // 
            // portNumberLabel
            // 
            this.portNumberLabel.AutoSize = true;
            this.portNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.portNumberLabel.Location = new System.Drawing.Point(12, 67);
            this.portNumberLabel.Name = "portNumberLabel";
            this.portNumberLabel.Size = new System.Drawing.Size(127, 24);
            this.portNumberLabel.TabIndex = 14;
            this.portNumberLabel.Text = "Номер порта";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.userNameLabel.Location = new System.Drawing.Point(12, 121);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(177, 24);
            this.userNameLabel.TabIndex = 16;
            this.userNameLabel.Text = "Имя пользователя";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.Location = new System.Drawing.Point(12, 175);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 24);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Пароль";
            // 
            // dataBaseLabel
            // 
            this.dataBaseLabel.AutoSize = true;
            this.dataBaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBaseLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dataBaseLabel.Location = new System.Drawing.Point(12, 229);
            this.dataBaseLabel.Name = "dataBaseLabel";
            this.dataBaseLabel.Size = new System.Drawing.Size(167, 24);
            this.dataBaseLabel.TabIndex = 20;
            this.dataBaseLabel.Text = "Имя базы данных";
            // 
            // portIns
            // 
            this.portIns.Location = new System.Drawing.Point(16, 94);
            this.portIns.Multiline = true;
            this.portIns.Name = "portIns";
            this.portIns.Size = new System.Drawing.Size(126, 24);
            this.portIns.TabIndex = 21;
            this.portIns.Text = "3306";
            // 
            // userNameIns
            // 
            this.userNameIns.Location = new System.Drawing.Point(16, 148);
            this.userNameIns.Multiline = true;
            this.userNameIns.Name = "userNameIns";
            this.userNameIns.Size = new System.Drawing.Size(126, 24);
            this.userNameIns.TabIndex = 22;
            this.userNameIns.Text = "root";
            // 
            // passwordIns
            // 
            this.passwordIns.Location = new System.Drawing.Point(16, 202);
            this.passwordIns.Multiline = true;
            this.passwordIns.Name = "passwordIns";
            this.passwordIns.Size = new System.Drawing.Size(126, 24);
            this.passwordIns.TabIndex = 23;
            this.passwordIns.Text = "root";
            this.passwordIns.TextChanged += new System.EventHandler(this.passwordIns_TextChanged);
            // 
            // dataBaseIns
            // 
            this.dataBaseIns.Location = new System.Drawing.Point(16, 256);
            this.dataBaseIns.Multiline = true;
            this.dataBaseIns.Name = "dataBaseIns";
            this.dataBaseIns.Size = new System.Drawing.Size(126, 24);
            this.dataBaseIns.TabIndex = 24;
            this.dataBaseIns.Text = "account";
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1096, 541);
            this.Controls.Add(this.dataBaseIns);
            this.Controls.Add(this.passwordIns);
            this.Controls.Add(this.userNameIns);
            this.Controls.Add(this.portIns);
            this.Controls.Add(this.dataBaseLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.portNumberLabel);
            this.Controls.Add(this.serverIns);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.Connect);
            this.Name = "RegistryForm";
            this.Text = "RegistryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox serverIns;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label portNumberLabel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox dataBase;
        private System.Windows.Forms.Label dataBaseLabel;
        private System.Windows.Forms.TextBox portIns;
        private System.Windows.Forms.TextBox userNameIns;
        private System.Windows.Forms.TextBox passwordIns;
        private System.Windows.Forms.TextBox dataBaseIns;
    }
}