
namespace CURD_Opration_4
{
    partial class frm_Add_Employee
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelHead = new System.Windows.Forms.Panel();
            this.panel_Head = new System.Windows.Forms.Panel();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconPictureBox_Home = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton_List = new FontAwesome.Sharp.IconButton();
            this.iconButton_Employee = new FontAwesome.Sharp.IconButton();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.iconPictureBox_Close = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_Maximum = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_Minimum = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.panel_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Minimum)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenu.Controls.Add(this.iconButton_List);
            this.panelMenu.Controls.Add(this.iconButton_Employee);
            this.panelMenu.Controls.Add(this.panelHead);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(325, 766);
            this.panelMenu.TabIndex = 0;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelHead.Controls.Add(this.pictureBox_logo);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(4);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(325, 193);
            this.panelHead.TabIndex = 1;
            // 
            // panel_Head
            // 
            this.panel_Head.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel_Head.Controls.Add(this.iconPictureBox_Minimum);
            this.panel_Head.Controls.Add(this.iconPictureBox_Maximum);
            this.panel_Head.Controls.Add(this.iconPictureBox_Close);
            this.panel_Head.Controls.Add(this.lbl_Home);
            this.panel_Head.Controls.Add(this.iconPictureBox_Home);
            this.panel_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Head.Location = new System.Drawing.Point(325, 0);
            this.panel_Head.Name = "panel_Head";
            this.panel_Head.Size = new System.Drawing.Size(1227, 100);
            this.panel_Head.TabIndex = 1;
            this.panel_Head.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Head_MouseDown);
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_Home.Location = new System.Drawing.Point(98, 37);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(54, 20);
            this.lbl_Home.TabIndex = 1;
            this.lbl_Home.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.SlateBlue;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(325, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1227, 666);
            this.panelDesktop.TabIndex = 2;
            // 
            // iconPictureBox_Home
            // 
            this.iconPictureBox_Home.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPictureBox_Home.ForeColor = System.Drawing.Color.MediumOrchid;
            this.iconPictureBox_Home.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconPictureBox_Home.IconColor = System.Drawing.Color.MediumOrchid;
            this.iconPictureBox_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_Home.IconSize = 51;
            this.iconPictureBox_Home.Location = new System.Drawing.Point(41, 28);
            this.iconPictureBox_Home.Name = "iconPictureBox_Home";
            this.iconPictureBox_Home.Size = new System.Drawing.Size(51, 53);
            this.iconPictureBox_Home.TabIndex = 0;
            this.iconPictureBox_Home.TabStop = false;
            // 
            // iconButton_List
            // 
            this.iconButton_List.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_List.FlatAppearance.BorderSize = 0;
            this.iconButton_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_List.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.iconButton_List.ForeColor = System.Drawing.Color.Black;
            this.iconButton_List.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton_List.IconColor = System.Drawing.Color.Black;
            this.iconButton_List.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_List.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_List.Location = new System.Drawing.Point(0, 284);
            this.iconButton_List.Name = "iconButton_List";
            this.iconButton_List.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.iconButton_List.Size = new System.Drawing.Size(325, 89);
            this.iconButton_List.TabIndex = 1;
            this.iconButton_List.Text = "  List";
            this.iconButton_List.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_List.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_List.UseVisualStyleBackColor = true;
            this.iconButton_List.Click += new System.EventHandler(this.iconButton_List_Click);
            // 
            // iconButton_Employee
            // 
            this.iconButton_Employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Employee.FlatAppearance.BorderSize = 0;
            this.iconButton_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Employee.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Employee.ForeColor = System.Drawing.Color.Black;
            this.iconButton_Employee.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButton_Employee.IconColor = System.Drawing.Color.Black;
            this.iconButton_Employee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Employee.Location = new System.Drawing.Point(0, 193);
            this.iconButton_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton_Employee.Name = "iconButton_Employee";
            this.iconButton_Employee.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.iconButton_Employee.Size = new System.Drawing.Size(325, 91);
            this.iconButton_Employee.TabIndex = 1;
            this.iconButton_Employee.Text = "  Employee";
            this.iconButton_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Employee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Employee.UseVisualStyleBackColor = true;
            this.iconButton_Employee.Click += new System.EventHandler(this.iconButton_Employee_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::CURD_Opration_4.Properties.Resources.Task_Managemenr_Logo;
            this.pictureBox_logo.Location = new System.Drawing.Point(41, 3);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(246, 190);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox_logo_Click);
            // 
            // iconPictureBox_Close
            // 
            this.iconPictureBox_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox_Close.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPictureBox_Close.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconPictureBox_Close.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_Close.Location = new System.Drawing.Point(1183, 12);
            this.iconPictureBox_Close.Name = "iconPictureBox_Close";
            this.iconPictureBox_Close.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_Close.TabIndex = 2;
            this.iconPictureBox_Close.TabStop = false;
            this.iconPictureBox_Close.Click += new System.EventHandler(this.iconPictureBox_Close_Click);
            // 
            // iconPictureBox_Maximum
            // 
            this.iconPictureBox_Maximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox_Maximum.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPictureBox_Maximum.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.iconPictureBox_Maximum.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_Maximum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_Maximum.Location = new System.Drawing.Point(1136, 12);
            this.iconPictureBox_Maximum.Name = "iconPictureBox_Maximum";
            this.iconPictureBox_Maximum.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_Maximum.TabIndex = 2;
            this.iconPictureBox_Maximum.TabStop = false;
            this.iconPictureBox_Maximum.Click += new System.EventHandler(this.iconPictureBox_Maximum_Click);
            // 
            // iconPictureBox_Minimum
            // 
            this.iconPictureBox_Minimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox_Minimum.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPictureBox_Minimum.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox_Minimum.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_Minimum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_Minimum.Location = new System.Drawing.Point(1086, 3);
            this.iconPictureBox_Minimum.Name = "iconPictureBox_Minimum";
            this.iconPictureBox_Minimum.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_Minimum.TabIndex = 2;
            this.iconPictureBox_Minimum.TabStop = false;
            this.iconPictureBox_Minimum.Click += new System.EventHandler(this.iconPictureBox_Minimum_Click);
            // 
            // frm_Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1552, 766);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel_Head);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Add_Employee";
            this.Text = "Add Employee";
            this.panelMenu.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panel_Head.ResumeLayout(false);
            this.panel_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Minimum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHead;
        private FontAwesome.Sharp.IconButton iconButton_Employee;
        private FontAwesome.Sharp.IconButton iconButton_List;
        private System.Windows.Forms.Panel panel_Head;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Home;
        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Minimum;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Maximum;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Close;
    }
}

