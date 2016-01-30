namespace SondosGlasses
{
    partial class AddGlass
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
            this.butSave = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.textCost = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.combType = new System.Windows.Forms.ComboBox();
            this.combModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSave
            // 
            this.butSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.butSave.Location = new System.Drawing.Point(50, 223);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(84, 38);
            this.butSave.TabIndex = 10;
            this.butSave.Text = "حفظ";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.butCancel.Location = new System.Drawing.Point(151, 223);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(84, 38);
            this.butCancel.TabIndex = 11;
            this.butCancel.Text = "إلاغاء";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // textCost
            // 
            this.textCost.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textCost.Location = new System.Drawing.Point(12, 111);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(134, 30);
            this.textCost.TabIndex = 5;
            // 
            // textPrice
            // 
            this.textPrice.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textPrice.Location = new System.Drawing.Point(12, 147);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(134, 30);
            this.textPrice.TabIndex = 7;
            // 
            // textQuantity
            // 
            this.textQuantity.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textQuantity.Location = new System.Drawing.Point(12, 183);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(134, 30);
            this.textQuantity.TabIndex = 9;
            // 
            // combType
            // 
            this.combType.Font = new System.Drawing.Font("Tahoma", 14F);
            this.combType.FormattingEnabled = true;
            this.combType.Items.AddRange(new object[] {
            "شمس ",
            "نظر ",
            "حفظ"});
            this.combType.Location = new System.Drawing.Point(12, 37);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(134, 31);
            this.combType.TabIndex = 1;
            // 
            // combModel
            // 
            this.combModel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.combModel.FormattingEnabled = true;
            this.combModel.Location = new System.Drawing.Point(12, 74);
            this.combModel.Name = "combModel";
            this.combModel.Size = new System.Drawing.Size(134, 31);
            this.combModel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(204, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "النوع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(204, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "الموديل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(204, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "التكلفة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(204, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "السعر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.Location = new System.Drawing.Point(204, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "الكمية";
            // 
            // AddGlass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combModel);
            this.Controls.Add(this.combType);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSave);
            this.Name = "AddGlass";
            this.Text = "AddGlass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.ComboBox combModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}