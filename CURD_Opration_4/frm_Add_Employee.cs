using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CURD_Opration_4
{
    public partial class frm_Add_Employee : Form
    {
        private IconButton currentbtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frm_Add_Employee()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,100);
            panelMenu.Controls.Add(leftBorderBtn);

            // form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249,118,176);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37, 35, 81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentbtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // icon current child form

                iconPictureBox_Home.IconChar = currentbtn.IconChar;
                iconPictureBox_Home.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if(currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(31, 30, 60);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void iconButton_Employee_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_Employee());
             ActivateButton(sender, RGBColors.color2);
            dropDownMenu2.Show(iconButton_Employee, iconButton_Employee.Width,0);
            
        }

        private void iconButton_List_Click(object sender, EventArgs e)
        { 
            
            ActivateButton(sender, RGBColors.color2);
            dropDownMenu3.Show(iconButton_List,iconButton_List.Width,0);
        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPictureBox_Home.IconChar = IconChar.Home; ;
            iconPictureBox_Home.IconColor = Color.MediumOrchid; 
            lbl_Home.Text = "Home";
        }

        // Drag Form
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);
        private void panel_Head_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void iconPictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox_Maximum_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconPictureBox_Minimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void frm_Add_Employee_Load(object sender, EventArgs e)
        {
            dropDownMenu1.IsMainMenu = true;
            dropDownMenu2.IsMainMenu = true;
            dropDownMenu3.IsMainMenu = true;
            dropDownMenu4.IsMainMenu = true;
            //  dropDownMenu3.ISMainMenu = true;
            dropDownMenu3.PrimaryColor = Color.OrangeRed;
            dropDownMenu1.PrimaryColor = Color.Purple;
            dropDownMenu1.MenuItemHeight = 50;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Employee());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dropDownMenu1.Show(iconButton1,iconButton1.Width, 0);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            dropDownMenu4.Show(iconButton2,iconButton2.Width,0);
        }
    }
}
