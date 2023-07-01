
namespace CURD_Opration_1
{
    partial class frm_Student
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
            this.lbl_Head = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Inseart = new System.Windows.Forms.Button();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.tb_Class = new System.Windows.Forms.TextBox();
            this.btn_UPDATE = new System.Windows.Forms.Button();
            this.btn_DELETE = new System.Windows.Forms.Button();
            this.btn_RESERT = new System.Windows.Forms.Button();
            this.dgv_Info = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.Location = new System.Drawing.Point(404, 9);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(286, 48);
            this.lbl_Head.TabIndex = 0;
            this.lbl_Head.Text = "Student Details";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(596, 127);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(361, 35);
            this.tb_Name.TabIndex = 1;
            // 
            // btn_Inseart
            // 
            this.btn_Inseart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Inseart.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inseart.Location = new System.Drawing.Point(196, 424);
            this.btn_Inseart.Name = "btn_Inseart";
            this.btn_Inseart.Size = new System.Drawing.Size(121, 54);
            this.btn_Inseart.TabIndex = 5;
            this.btn_Inseart.Text = "INSERT";
            this.btn_Inseart.UseVisualStyleBackColor = false;
            this.btn_Inseart.Click += new System.EventHandler(this.btn_Inseart_Click);
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_Gender.Location = new System.Drawing.Point(596, 183);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(361, 36);
            this.cmb_Gender.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Name.Location = new System.Drawing.Point(228, 128);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(98, 34);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name:";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Gender.Location = new System.Drawing.Point(228, 185);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(115, 34);
            this.lbl_Gender.TabIndex = 0;
            this.lbl_Gender.Text = "Gender:";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Age.Location = new System.Drawing.Point(228, 239);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(72, 34);
            this.lbl_Age.TabIndex = 0;
            this.lbl_Age.Text = "Age:";
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Class.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Class.Location = new System.Drawing.Point(228, 288);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(89, 34);
            this.lbl_Class.TabIndex = 0;
            this.lbl_Class.Text = "Class:";
            // 
            // tb_Age
            // 
            this.tb_Age.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Age.Location = new System.Drawing.Point(596, 238);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(361, 35);
            this.tb_Age.TabIndex = 3;
            // 
            // tb_Class
            // 
            this.tb_Class.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Class.Location = new System.Drawing.Point(596, 299);
            this.tb_Class.Name = "tb_Class";
            this.tb_Class.Size = new System.Drawing.Size(361, 35);
            this.tb_Class.TabIndex = 4;
            // 
            // btn_UPDATE
            // 
            this.btn_UPDATE.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_UPDATE.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UPDATE.Location = new System.Drawing.Point(389, 424);
            this.btn_UPDATE.Name = "btn_UPDATE";
            this.btn_UPDATE.Size = new System.Drawing.Size(121, 54);
            this.btn_UPDATE.TabIndex = 6;
            this.btn_UPDATE.Text = "UPDATE";
            this.btn_UPDATE.UseVisualStyleBackColor = false;
            this.btn_UPDATE.Click += new System.EventHandler(this.btn_UPDATE_Click);
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_DELETE.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DELETE.Location = new System.Drawing.Point(603, 424);
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Size = new System.Drawing.Size(121, 54);
            this.btn_DELETE.TabIndex = 7;
            this.btn_DELETE.Text = "DELETE";
            this.btn_DELETE.UseVisualStyleBackColor = false;
            this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
            // 
            // btn_RESERT
            // 
            this.btn_RESERT.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_RESERT.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RESERT.Location = new System.Drawing.Point(796, 424);
            this.btn_RESERT.Name = "btn_RESERT";
            this.btn_RESERT.Size = new System.Drawing.Size(121, 54);
            this.btn_RESERT.TabIndex = 8;
            this.btn_RESERT.Text = "RESERT";
            this.btn_RESERT.UseVisualStyleBackColor = false;
            this.btn_RESERT.Click += new System.EventHandler(this.btn_RESERT_Click);
            // 
            // dgv_Info
            // 
            this.dgv_Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Info.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Info.Location = new System.Drawing.Point(11, 507);
            this.dgv_Info.Name = "dgv_Info";
            this.dgv_Info.RowHeadersWidth = 51;
            this.dgv_Info.RowTemplate.Height = 24;
            this.dgv_Info.Size = new System.Drawing.Size(1115, 295);
            this.dgv_Info.TabIndex = 9;
            this.dgv_Info.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Info_MouseDoubleClick);
            // 
            // frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1138, 814);
            this.Controls.Add(this.dgv_Info);
            this.Controls.Add(this.cmb_Gender);
            this.Controls.Add(this.btn_RESERT);
            this.Controls.Add(this.btn_DELETE);
            this.Controls.Add(this.btn_UPDATE);
            this.Controls.Add(this.btn_Inseart);
            this.Controls.Add(this.tb_Class);
            this.Controls.Add(this.tb_Age);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Class);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Inseart;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.TextBox tb_Class;
        private System.Windows.Forms.Button btn_UPDATE;
        private System.Windows.Forms.Button btn_DELETE;
        private System.Windows.Forms.Button btn_RESERT;
        private System.Windows.Forms.DataGridView dgv_Info;
    }
}

