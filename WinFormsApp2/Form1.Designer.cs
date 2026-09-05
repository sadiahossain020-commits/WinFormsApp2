namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAddCustomer = new Label();
            label1 = new Label();
            pnlMain = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            lblPhone = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            lblUsername = new Label();
            lblEmail = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblAdress = new Label();
            lblPassword = new Label();
            maskedTextBox5 = new MaskedTextBox();
            maskedTextBox6 = new MaskedTextBox();
            lblSave = new Label();
            lblCancel = new Label();
            pnlMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddCustomer
            // 
            lblAddCustomer.AutoSize = true;
            lblAddCustomer.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAddCustomer.ForeColor = Color.MidnightBlue;
            lblAddCustomer.Location = new Point(3, 0);
            lblAddCustomer.Name = "lblAddCustomer";
            lblAddCustomer.Size = new Size(214, 38);
            lblAddCustomer.TabIndex = 0;
            lblAddCustomer.Text = "Add Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 74);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lblAddCustomer);
            pnlMain.Controls.Add(tableLayoutPanel1);
            pnlMain.Controls.Add(tableLayoutPanel2);
            pnlMain.Controls.Add(tableLayoutPanel3);
            pnlMain.Dock = DockStyle.Top;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 396);
            pnlMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(lblPhone, 1, 0);
            tableLayoutPanel1.Controls.Add(maskedTextBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(maskedTextBox2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(797, 88);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 34);
            label2.TabIndex = 0;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.DarkSlateBlue;
            lblPhone.Location = new Point(401, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 34);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone";
            lblPhone.Click += lblPhone_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(3, 37);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(224, 31);
            maskedTextBox1.TabIndex = 2;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(401, 37);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(255, 31);
            maskedTextBox2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(maskedTextBox3, 0, 1);
            tableLayoutPanel2.Controls.Add(maskedTextBox4, 1, 1);
            tableLayoutPanel2.Controls.Add(lblUsername, 1, 0);
            tableLayoutPanel2.Controls.Add(lblEmail, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 135);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(797, 108);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(3, 57);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(255, 31);
            maskedTextBox3.TabIndex = 8;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(401, 57);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(255, 31);
            maskedTextBox4.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DarkSlateBlue;
            lblUsername.Location = new Point(401, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(155, 38);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "UserName";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.DarkSlateBlue;
            lblEmail.Location = new Point(3, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(93, 38);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblAdress, 0, 0);
            tableLayoutPanel3.Controls.Add(lblPassword, 1, 0);
            tableLayoutPanel3.Controls.Add(maskedTextBox5, 0, 1);
            tableLayoutPanel3.Controls.Add(maskedTextBox6, 1, 1);
            tableLayoutPanel3.Location = new Point(3, 249);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 56.25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 43.75F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(797, 101);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAdress.ForeColor = Color.DarkSlateBlue;
            lblAdress.Location = new Point(3, 0);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(104, 38);
            lblAdress.TabIndex = 6;
            lblAdress.Text = "Adress";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.DarkSlateBlue;
            lblPassword.Location = new Point(401, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(142, 38);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(3, 48);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(255, 31);
            maskedTextBox5.TabIndex = 8;
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(401, 48);
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(255, 31);
            maskedTextBox6.TabIndex = 9;
            // 
            // lblSave
            // 
            lblSave.AutoSize = true;
            lblSave.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSave.ForeColor = Color.IndianRed;
            lblSave.Location = new Point(0, 370);
            lblSave.Name = "lblSave";
            lblSave.Size = new Size(94, 45);
            lblSave.TabIndex = 10;
            lblSave.Text = "Save";
            // 
            // lblCancel
            // 
            lblCancel.AutoSize = true;
            lblCancel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCancel.ForeColor = Color.DarkGreen;
            lblCancel.Location = new Point(140, 383);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(90, 32);
            lblCancel.TabIndex = 11;
            lblCancel.Text = "Cancel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSave);
            Controls.Add(lblCancel);
            Controls.Add(pnlMain);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Add Customer";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddCustomer;
        private Label label1;
        private FlowLayoutPanel pnlMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private MaskedTextBox maskedTextBox2;
        private Label lblPhone;
        private MaskedTextBox maskedTextBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblUsername;
        private Label lblEmail;
        private MaskedTextBox maskedTextBox4;
        private TableLayoutPanel tableLayoutPanel3;
        private MaskedTextBox maskedTextBox6;
        private MaskedTextBox maskedTextBox5;
        private Label lblPassword;
        private Label lblAdress;
        private MaskedTextBox maskedTextBox3;
        private Label lblSave;
        private Label lblCancel;
    }
}
