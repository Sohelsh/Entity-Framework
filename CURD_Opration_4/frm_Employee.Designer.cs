
namespace CURD_Opration_4
{
    partial class frm_Employee
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
            this.lbl_Enter_Name = new System.Windows.Forms.Label();
            this.lbl_Con_Number = new System.Windows.Forms.Label();
            this.tb_Enter_Name = new System.Windows.Forms.TextBox();
            this.tb_Con_Number = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.gb_Personal_Information = new System.Windows.Forms.GroupBox();
            this.lbl_Emp_ID = new System.Windows.Forms.Label();
            this.lbl_Job_Title = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.tb_Emp_ID = new System.Windows.Forms.TextBox();
            this.tb_Job_Title = new System.Windows.Forms.TextBox();
            this.lbl_DOJ = new System.Windows.Forms.Label();
            this.dtp_DOJ = new System.Windows.Forms.DateTimePicker();
            this.lbl_Emp_Status = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.cmb_Emp_Status = new System.Windows.Forms.ComboBox();
            this.gb_Employment_Information = new System.Windows.Forms.GroupBox();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.pnl_Head = new System.Windows.Forms.Panel();
            this.gb_Personal_Information.SuspendLayout();
            this.gb_Employment_Information.SuspendLayout();
            this.pnl_Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Enter_Name
            // 
            this.lbl_Enter_Name.AutoSize = true;
            this.lbl_Enter_Name.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Enter_Name.Location = new System.Drawing.Point(20, 50);
            this.lbl_Enter_Name.Name = "lbl_Enter_Name";
            this.lbl_Enter_Name.Size = new System.Drawing.Size(143, 20);
            this.lbl_Enter_Name.TabIndex = 11;
            this.lbl_Enter_Name.Text = "Enter Full Name :";
            // 
            // lbl_Con_Number
            // 
            this.lbl_Con_Number.AutoSize = true;
            this.lbl_Con_Number.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Con_Number.Location = new System.Drawing.Point(739, 50);
            this.lbl_Con_Number.Name = "lbl_Con_Number";
            this.lbl_Con_Number.Size = new System.Drawing.Size(144, 20);
            this.lbl_Con_Number.TabIndex = 10;
            this.lbl_Con_Number.Text = "Contact Number :";
            // 
            // tb_Enter_Name
            // 
            this.tb_Enter_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Enter_Name.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Enter_Name.Location = new System.Drawing.Point(24, 73);
            this.tb_Enter_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Enter_Name.Name = "tb_Enter_Name";
            this.tb_Enter_Name.Size = new System.Drawing.Size(277, 27);
            this.tb_Enter_Name.TabIndex = 1;
            // 
            // tb_Con_Number
            // 
            this.tb_Con_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Con_Number.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Con_Number.Location = new System.Drawing.Point(743, 73);
            this.tb_Con_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Con_Number.MaxLength = 10;
            this.tb_Con_Number.Name = "tb_Con_Number";
            this.tb_Con_Number.Size = new System.Drawing.Size(277, 32);
            this.tb_Con_Number.TabIndex = 3;
            this.tb_Con_Number.TabStop = false;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(20, 116);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(122, 20);
            this.lbl_Gender.TabIndex = 15;
            this.lbl_Gender.Text = "Select Gender :";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(397, 50);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(112, 20);
            this.lbl_DOB.TabIndex = 14;
            this.lbl_DOB.Text = "Date of Birth:";
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(24, 139);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(66, 24);
            this.rb_Male.TabIndex = 16;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(401, 73);
            this.dtp_DOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(200, 28);
            this.dtp_DOB.TabIndex = 2;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(739, 116);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(59, 20);
            this.lbl_Email.TabIndex = 18;
            this.lbl_Email.Text = "Email:";
            // 
            // tb_Email
            // 
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Email.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(743, 139);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(277, 27);
            this.tb_Email.TabIndex = 5;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(397, 116);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(74, 20);
            this.lbl_Address.TabIndex = 20;
            this.lbl_Address.Text = "Address:";
            // 
            // tb_Address
            // 
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Address.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(401, 139);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(277, 27);
            this.tb_Address.TabIndex = 4;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(131, 142);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(85, 24);
            this.rb_Female.TabIndex = 4;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // gb_Personal_Information
            // 
            this.gb_Personal_Information.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Personal_Information.BackColor = System.Drawing.SystemColors.Control;
            this.gb_Personal_Information.Controls.Add(this.rb_Female);
            this.gb_Personal_Information.Controls.Add(this.tb_Address);
            this.gb_Personal_Information.Controls.Add(this.lbl_Address);
            this.gb_Personal_Information.Controls.Add(this.tb_Email);
            this.gb_Personal_Information.Controls.Add(this.lbl_Email);
            this.gb_Personal_Information.Controls.Add(this.dtp_DOB);
            this.gb_Personal_Information.Controls.Add(this.rb_Male);
            this.gb_Personal_Information.Controls.Add(this.lbl_DOB);
            this.gb_Personal_Information.Controls.Add(this.lbl_Gender);
            this.gb_Personal_Information.Controls.Add(this.tb_Con_Number);
            this.gb_Personal_Information.Controls.Add(this.tb_Enter_Name);
            this.gb_Personal_Information.Controls.Add(this.lbl_Con_Number);
            this.gb_Personal_Information.Controls.Add(this.lbl_Enter_Name);
            this.gb_Personal_Information.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Personal_Information.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_Personal_Information.Location = new System.Drawing.Point(67, 95);
            this.gb_Personal_Information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Personal_Information.Name = "gb_Personal_Information";
            this.gb_Personal_Information.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Personal_Information.Size = new System.Drawing.Size(1103, 217);
            this.gb_Personal_Information.TabIndex = 17;
            this.gb_Personal_Information.TabStop = false;
            this.gb_Personal_Information.Text = "Personal Information";
            // 
            // lbl_Emp_ID
            // 
            this.lbl_Emp_ID.AutoSize = true;
            this.lbl_Emp_ID.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_ID.Location = new System.Drawing.Point(21, 49);
            this.lbl_Emp_ID.Name = "lbl_Emp_ID";
            this.lbl_Emp_ID.Size = new System.Drawing.Size(116, 20);
            this.lbl_Emp_ID.TabIndex = 14;
            this.lbl_Emp_ID.Text = "Employee ID :";
            // 
            // lbl_Job_Title
            // 
            this.lbl_Job_Title.AutoSize = true;
            this.lbl_Job_Title.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Job_Title.Location = new System.Drawing.Point(397, 49);
            this.lbl_Job_Title.Name = "lbl_Job_Title";
            this.lbl_Job_Title.Size = new System.Drawing.Size(81, 20);
            this.lbl_Job_Title.TabIndex = 13;
            this.lbl_Job_Title.Text = "Job Title:";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(739, 49);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(110, 20);
            this.lbl_Department.TabIndex = 12;
            this.lbl_Department.Text = "Department :";
            // 
            // tb_Emp_ID
            // 
            this.tb_Emp_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Emp_ID.Enabled = false;
            this.tb_Emp_ID.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_ID.Location = new System.Drawing.Point(25, 71);
            this.tb_Emp_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Emp_ID.Name = "tb_Emp_ID";
            this.tb_Emp_ID.Size = new System.Drawing.Size(277, 32);
            this.tb_Emp_ID.TabIndex = 6;
            this.tb_Emp_ID.Text = "             ";
            this.tb_Emp_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Job_Title
            // 
            this.tb_Job_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Job_Title.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Job_Title.Location = new System.Drawing.Point(401, 71);
            this.tb_Job_Title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Job_Title.Name = "tb_Job_Title";
            this.tb_Job_Title.Size = new System.Drawing.Size(277, 27);
            this.tb_Job_Title.TabIndex = 7;
            // 
            // lbl_DOJ
            // 
            this.lbl_DOJ.AutoSize = true;
            this.lbl_DOJ.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOJ.Location = new System.Drawing.Point(21, 124);
            this.lbl_DOJ.Name = "lbl_DOJ";
            this.lbl_DOJ.Size = new System.Drawing.Size(130, 20);
            this.lbl_DOJ.TabIndex = 17;
            this.lbl_DOJ.Text = "Date of Joining:";
            // 
            // dtp_DOJ
            // 
            this.dtp_DOJ.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOJ.Location = new System.Drawing.Point(25, 146);
            this.dtp_DOJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_DOJ.Name = "dtp_DOJ";
            this.dtp_DOJ.Size = new System.Drawing.Size(200, 28);
            this.dtp_DOJ.TabIndex = 9;
            // 
            // lbl_Emp_Status
            // 
            this.lbl_Emp_Status.AutoSize = true;
            this.lbl_Emp_Status.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Status.Location = new System.Drawing.Point(397, 124);
            this.lbl_Emp_Status.Name = "lbl_Emp_Status";
            this.lbl_Emp_Status.Size = new System.Drawing.Size(170, 20);
            this.lbl_Emp_Status.TabIndex = 19;
            this.lbl_Emp_Status.Text = "Employment_Status:";
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.ItemHeight = 20;
            this.cmb_Department.Items.AddRange(new object[] {
            "UX/UI ",
            "Research and Development",
            "Software Developers",
            "Softwere Testung",
            "Product Designer"});
            this.cmb_Department.Location = new System.Drawing.Point(743, 71);
            this.cmb_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(277, 28);
            this.cmb_Department.TabIndex = 21;
            // 
            // cmb_Emp_Status
            // 
            this.cmb_Emp_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Emp_Status.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Emp_Status.FormattingEnabled = true;
            this.cmb_Emp_Status.Items.AddRange(new object[] {
            "Full Time ",
            "Part Time",
            "Contract"});
            this.cmb_Emp_Status.Location = new System.Drawing.Point(401, 146);
            this.cmb_Emp_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Emp_Status.Name = "cmb_Emp_Status";
            this.cmb_Emp_Status.Size = new System.Drawing.Size(277, 28);
            this.cmb_Emp_Status.TabIndex = 10;
            // 
            // gb_Employment_Information
            // 
            this.gb_Employment_Information.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Employment_Information.Controls.Add(this.cmb_Emp_Status);
            this.gb_Employment_Information.Controls.Add(this.cmb_Department);
            this.gb_Employment_Information.Controls.Add(this.lbl_Emp_Status);
            this.gb_Employment_Information.Controls.Add(this.dtp_DOJ);
            this.gb_Employment_Information.Controls.Add(this.lbl_DOJ);
            this.gb_Employment_Information.Controls.Add(this.tb_Job_Title);
            this.gb_Employment_Information.Controls.Add(this.tb_Emp_ID);
            this.gb_Employment_Information.Controls.Add(this.lbl_Department);
            this.gb_Employment_Information.Controls.Add(this.lbl_Job_Title);
            this.gb_Employment_Information.Controls.Add(this.lbl_Emp_ID);
            this.gb_Employment_Information.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Employment_Information.Location = new System.Drawing.Point(56, 388);
            this.gb_Employment_Information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Employment_Information.Name = "gb_Employment_Information";
            this.gb_Employment_Information.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Employment_Information.Size = new System.Drawing.Size(1045, 223);
            this.gb_Employment_Information.TabIndex = 18;
            this.gb_Employment_Information.TabStop = false;
            this.gb_Employment_Information.Text = "Employment Information";
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Head.Location = new System.Drawing.Point(230, 0);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(327, 38);
            this.lbl_Head.TabIndex = 0;
            this.lbl_Head.Text = "Add New Employe";
            // 
            // pnl_Head
            // 
            this.pnl_Head.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Head.BackColor = System.Drawing.Color.SlateBlue;
            this.pnl_Head.Controls.Add(this.lbl_Head);
            this.pnl_Head.Location = new System.Drawing.Point(201, 1);
            this.pnl_Head.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Head.Name = "pnl_Head";
            this.pnl_Head.Size = new System.Drawing.Size(875, 55);
            this.pnl_Head.TabIndex = 19;
            // 
            // frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 606);
            this.Controls.Add(this.pnl_Head);
            this.Controls.Add(this.gb_Employment_Information);
            this.Controls.Add(this.gb_Personal_Information);
            this.Name = "frm_Employee";
            this.Text = "frm_Employee";
            this.Load += new System.EventHandler(this.frm_Employee_Load);
            this.gb_Personal_Information.ResumeLayout(false);
            this.gb_Personal_Information.PerformLayout();
            this.gb_Employment_Information.ResumeLayout(false);
            this.gb_Employment_Information.PerformLayout();
            this.pnl_Head.ResumeLayout(false);
            this.pnl_Head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Enter_Name;
        private System.Windows.Forms.Label lbl_Con_Number;
        private System.Windows.Forms.TextBox tb_Enter_Name;
        private System.Windows.Forms.TextBox tb_Con_Number;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.GroupBox gb_Personal_Information;
        private System.Windows.Forms.Label lbl_Emp_ID;
        private System.Windows.Forms.Label lbl_Job_Title;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.TextBox tb_Emp_ID;
        private System.Windows.Forms.TextBox tb_Job_Title;
        private System.Windows.Forms.Label lbl_DOJ;
        private System.Windows.Forms.DateTimePicker dtp_DOJ;
        private System.Windows.Forms.Label lbl_Emp_Status;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.ComboBox cmb_Emp_Status;
        private System.Windows.Forms.GroupBox gb_Employment_Information;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Panel pnl_Head;
    }
}