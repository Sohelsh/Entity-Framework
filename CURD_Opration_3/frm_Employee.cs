using CURD_Opration_3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURD_Opration_3
{
    public partial class frm_Employee : Form
    {
        Employee Eobj = new Employee();
        CURD_ThreeEntities dbobj = new CURD_ThreeEntities();

        int N_Id;
        public frm_Employee()
        {
            InitializeComponent();
            Show_Data();
        }

        void Show_Data()
        {
            dataGridView.DataSource = dbobj.Employees.ToList<Employee>();
        }

        void Reset_Data()
        {
            tb_Name.Clear();
            tb_City.Clear();
            tb_Age.Clear();
            cmb_Gender.SelectedItem = null;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Eobj.Name = tb_Name.Text.Trim();
            Eobj.Gender = cmb_Gender.SelectedItem.ToString();
            Eobj.City = tb_City.Text.Trim();
            Eobj.Age = Convert.ToInt32(tb_Age.Text.Trim());

            dbobj.Employees.Add(Eobj);

            int Ans = dbobj.SaveChanges();

            if(Ans > 0)
            {
                MessageBox.Show("Data Insert Successfully","",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                Show_Data();
                Reset_Data();
            }
            else
            {
                MessageBox.Show("Data Insertion Failed", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset_Data();
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            N_Id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            Eobj = dbobj.Employees.Where(x => x.id == N_Id ).FirstOrDefault();

            tb_Name.Text = Eobj.Name.ToString();
            tb_City.Text = Eobj.City.ToString();
            tb_Age.Text = Eobj.Age.ToString();
            cmb_Gender.SelectedItem = Eobj.Gender;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           // Eobj.id = N_Id;
            Eobj.Name = tb_Name.Text.Trim();
            Eobj.Gender = cmb_Gender.SelectedItem.ToString();
            Eobj.City = tb_City.Text.Trim();
            Eobj.Age = Convert.ToInt32(tb_Age.Text.Trim());

            dbobj.Entry(Eobj).State = System.Data.Entity.EntityState.Modified;

            int Ans = dbobj.SaveChanges();

            if (Ans > 0)
            {
                MessageBox.Show("Data Update Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Show_Data();
                Reset_Data();
            }
            else
            {
                MessageBox.Show("Data Updation Failed", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure to Delete Data", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes)
            {
                Eobj = dbobj.Employees.Where(x => x.id == N_Id).FirstOrDefault();
                dbobj.Entry(Eobj).State = System.Data.Entity.EntityState.Deleted;

                int Ans = dbobj.SaveChanges();

                if (Ans > 0)
                {
                    MessageBox.Show("Data Deleted Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Show_Data();
                    Reset_Data();
                }
                else
                {
                    MessageBox.Show("Data Delete Opration Failed", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Cancelled Delete Opration", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_City_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Age_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Gender_Click(object sender, EventArgs e)
        {

        }

        private void lbl_City_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Head_Click(object sender, EventArgs e)
        {

        }
    }
}
