namespace WinFormsApp2
{
    partial class SpWithMulParmeters
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
            txtEmpName = new TextBox();
            lblEmpName = new Label();
            btnInsert = new Button();
            lblEmpId = new Label();
            lblEmpDesig = new Label();
            lblEmpDOJ = new Label();
            lblEmpSal = new Label();
            lblEmpdept = new Label();
            txtEmpId = new TextBox();
            txtDesig = new TextBox();
            txtEmpDOJ = new TextBox();
            txtEmpSal = new TextBox();
            txtEmpDept = new TextBox();
            btnUpdate = new Button();
            btnClear = new Button();
            btndelete = new Button();
            SuspendLayout();
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(283, 84);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(125, 27);
            txtEmpName.TabIndex = 0;
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.Location = new Point(91, 84);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(119, 20);
            lblEmpName.TabIndex = 1;
            lblEmpName.Text = "Employee Name";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(146, 365);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(91, 128);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(92, 20);
            lblEmpId.TabIndex = 3;
            lblEmpId.Text = "Employee Id";
            // 
            // lblEmpDesig
            // 
            lblEmpDesig.AutoSize = true;
            lblEmpDesig.Location = new Point(91, 169);
            lblEmpDesig.Name = "lblEmpDesig";
            lblEmpDesig.Size = new Size(159, 20);
            lblEmpDesig.TabIndex = 4;
            lblEmpDesig.Text = "Employee Designation";
            // 
            // lblEmpDOJ
            // 
            lblEmpDOJ.AutoSize = true;
            lblEmpDOJ.Location = new Point(91, 210);
            lblEmpDOJ.Name = "lblEmpDOJ";
            lblEmpDOJ.Size = new Size(106, 20);
            lblEmpDOJ.TabIndex = 5;
            lblEmpDOJ.Text = "Employee DOJ";
            // 
            // lblEmpSal
            // 
            lblEmpSal.AutoSize = true;
            lblEmpSal.Location = new Point(91, 255);
            lblEmpSal.Name = "lblEmpSal";
            lblEmpSal.Size = new Size(119, 20);
            lblEmpSal.TabIndex = 6;
            lblEmpSal.Text = "Employee Salary";
            // 
            // lblEmpdept
            // 
            lblEmpdept.AutoSize = true;
            lblEmpdept.Location = new Point(91, 305);
            lblEmpdept.Name = "lblEmpdept";
            lblEmpdept.Size = new Size(112, 20);
            lblEmpdept.TabIndex = 7;
            lblEmpdept.Text = "Employee Dept";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(283, 128);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(125, 27);
            txtEmpId.TabIndex = 8;
            // 
            // txtDesig
            // 
            txtDesig.Location = new Point(283, 169);
            txtDesig.Name = "txtDesig";
            txtDesig.Size = new Size(125, 27);
            txtDesig.TabIndex = 9;
            // 
            // txtEmpDOJ
            // 
            txtEmpDOJ.Location = new Point(283, 210);
            txtEmpDOJ.Name = "txtEmpDOJ";
            txtEmpDOJ.Size = new Size(125, 27);
            txtEmpDOJ.TabIndex = 10;
            // 
            // txtEmpSal
            // 
            txtEmpSal.Location = new Point(283, 256);
            txtEmpSal.Name = "txtEmpSal";
            txtEmpSal.Size = new Size(125, 27);
            txtEmpSal.TabIndex = 11;
            // 
            // txtEmpDept
            // 
            txtEmpDept.Location = new Point(283, 305);
            txtEmpDept.Name = "txtEmpDept";
            txtEmpDept.Size = new Size(125, 27);
            txtEmpDept.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(267, 365);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(267, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(146, 409);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 15;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // SpWithMulParmeters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(btndelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(txtEmpDept);
            Controls.Add(txtEmpSal);
            Controls.Add(txtEmpDOJ);
            Controls.Add(txtDesig);
            Controls.Add(txtEmpId);
            Controls.Add(lblEmpdept);
            Controls.Add(lblEmpSal);
            Controls.Add(lblEmpDOJ);
            Controls.Add(lblEmpDesig);
            Controls.Add(lblEmpId);
            Controls.Add(btnInsert);
            Controls.Add(lblEmpName);
            Controls.Add(txtEmpName);
            Name = "SpWithMulParmeters";
            Text = "SpWithMulParameters";
           // Load += SpWithMulParmeters_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmpName;
        private Label lblEmpName;
        private Button btnInsert;
        private Label lblEmpId;
        private Label lblEmpDesig;
        private Label lblEmpDOJ;
        private Label lblEmpSal;
        private Label lblEmpdept;
        private TextBox txtEmpId;
        private TextBox txtDesig;
        private TextBox txtEmpDOJ;
        private TextBox txtEmpSal;
        private TextBox txtEmpDept;
        private Button btnUpdate;
        private Button btnClear;
        private Button btndelete;
    }
}