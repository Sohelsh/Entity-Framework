
namespace CURD_Opration_5
{
    partial class frm_Add
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
            this.dgv_Student_Info = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.lbl_Std = new System.Windows.Forms.Label();
            this.tb_Std = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Student_Info
            // 
            this.dgv_Student_Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_Info.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Student_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_Info.Location = new System.Drawing.Point(88, 497);
            this.dgv_Student_Info.Name = "dgv_Student_Info";
            this.dgv_Student_Info.RowHeadersWidth = 51;
            this.dgv_Student_Info.RowTemplate.Height = 24;
            this.dgv_Student_Info.Size = new System.Drawing.Size(1070, 309);
            this.dgv_Student_Info.TabIndex = 19;
            this.dgv_Student_Info.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Student_Info_MouseClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Delete.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(909, 428);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(118, 50);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Update.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(713, 428);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(118, 50);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Insert.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.Location = new System.Drawing.Point(475, 428);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(118, 50);
            this.btn_Insert.TabIndex = 16;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Reset.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(226, 428);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(118, 50);
            this.btn_Reset.TabIndex = 17;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_Gender.Location = new System.Drawing.Point(674, 244);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(363, 39);
            this.cmb_Gender.TabIndex = 18;
            // 
            // tb_Age
            // 
            this.tb_Age.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Age.Location = new System.Drawing.Point(674, 155);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(363, 39);
            this.tb_Age.TabIndex = 12;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(674, 76);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(363, 39);
            this.tb_Name.TabIndex = 7;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(229, 150);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(64, 36);
            this.lbl_Age.TabIndex = 8;
            this.lbl_Age.Text = "Age";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(229, 239);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(109, 36);
            this.lbl_Gender.TabIndex = 9;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(229, 81);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(90, 36);
            this.lbl_Name.TabIndex = 11;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.Location = new System.Drawing.Point(518, -3);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(236, 45);
            this.lbl_Head.TabIndex = 6;
            this.lbl_Head.Text = "Add Employee";
            // 
            // lbl_Std
            // 
            this.lbl_Std.AutoSize = true;
            this.lbl_Std.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Std.Location = new System.Drawing.Point(229, 304);
            this.lbl_Std.Name = "lbl_Std";
            this.lbl_Std.Size = new System.Drawing.Size(133, 36);
            this.lbl_Std.TabIndex = 10;
            this.lbl_Std.Text = "Standard";
            // 
            // tb_Std
            // 
            this.tb_Std.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Std.Location = new System.Drawing.Point(674, 304);
            this.tb_Std.Name = "tb_Std";
            this.tb_Std.Size = new System.Drawing.Size(363, 39);
            this.tb_Std.TabIndex = 13;
            // 
            // frm_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 818);
            this.Controls.Add(this.dgv_Student_Info);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.cmb_Gender);
            this.Controls.Add(this.tb_Std);
            this.Controls.Add(this.tb_Age);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_Std);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Head);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Student_Info;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Label lbl_Std;
        private System.Windows.Forms.TextBox tb_Std;
    }
}

