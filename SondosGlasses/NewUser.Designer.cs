namespace SondosGlasses
{
    partial class NewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.CreateButt = new System.Windows.Forms.Button();
            this.CancelButt = new System.Windows.Forms.Button();
            this.Confirme = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpybecom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(203, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "إسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(203, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة المرور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(203, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "الموبيل";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Username.Location = new System.Drawing.Point(12, 23);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(185, 30);
            this.Username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Password.Location = new System.Drawing.Point(12, 53);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(185, 30);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Phone.Location = new System.Drawing.Point(12, 114);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(185, 30);
            this.Phone.TabIndex = 7;
            // 
            // CreateButt
            // 
            this.CreateButt.Font = new System.Drawing.Font("Tahoma", 14F);
            this.CreateButt.Location = new System.Drawing.Point(42, 208);
            this.CreateButt.Name = "CreateButt";
            this.CreateButt.Size = new System.Drawing.Size(103, 35);
            this.CreateButt.TabIndex = 10;
            this.CreateButt.Text = "إنشاء";
            this.CreateButt.UseVisualStyleBackColor = true;
            this.CreateButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButt
            // 
            this.CancelButt.Font = new System.Drawing.Font("Tahoma", 14F);
            this.CancelButt.Location = new System.Drawing.Point(173, 208);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(103, 35);
            this.CancelButt.TabIndex = 11;
            this.CancelButt.Text = "إلغاء";
            this.CancelButt.UseVisualStyleBackColor = true;
            this.CancelButt.Click += new System.EventHandler(this.button2_Click);
            // 
            // Confirme
            // 
            this.Confirme.AutoSize = true;
            this.Confirme.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Confirme.Location = new System.Drawing.Point(203, 86);
            this.Confirme.Name = "Confirme";
            this.Confirme.Size = new System.Drawing.Size(143, 23);
            this.Confirme.TabIndex = 4;
            this.Confirme.Text = "تأكيد كلمة المرور";
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Tahoma", 14F);
            this.confirm.Location = new System.Drawing.Point(12, 83);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(185, 30);
            this.confirm.TabIndex = 5;
            this.confirm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(203, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "النوع";
            // 
            // tpybecom
            // 
            this.tpybecom.AllowDrop = true;
            this.tpybecom.Font = new System.Drawing.Font("Tahoma", 14F);
            this.tpybecom.FormattingEnabled = true;
            this.tpybecom.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.tpybecom.Location = new System.Drawing.Point(12, 149);
            this.tpybecom.Name = "tpybecom";
            this.tpybecom.Size = new System.Drawing.Size(185, 31);
            this.tpybecom.TabIndex = 9;
            this.tpybecom.Text = "User";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 261);
            this.Controls.Add(this.tpybecom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.Confirme);
            this.Controls.Add(this.CancelButt);
            this.Controls.Add(this.CreateButt);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.Text = "إضافة موظف";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button CreateButt;
        private System.Windows.Forms.Button CancelButt;
        private System.Windows.Forms.Label Confirme;
        private System.Windows.Forms.TextBox confirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tpybecom;
    }
}