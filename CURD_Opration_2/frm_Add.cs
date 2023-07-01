using CURD_Opration_2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURD_Opration_2
{
    public partial class frm_Add : Form
    {
        student sobj = new student();
        CRUD_TwoEntities Dbobj = new CRUD_TwoEntities();
        int N_Id = 0;
        public frm_Add()
        {
            InitializeComponent();
        }

        void Show_Data()
        {
            dataGridView.DataSource = Dbobj.students.ToList<student>();
        }

        private void frm_Add_Load(object sender, EventArgs e)
        {
            Show_Data();
        }

        void Clear_Controls()
        {
            tb_Name.Clear();
            tb_Age.Clear();
            tb_Class.Clear();
            cmb_Gender.SelectedItem = null;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            sobj.name = tb_Name.Text.Trim();
            sobj.gender = cmb_Gender.SelectedItem.ToString();
            sobj.standard = Convert.ToInt32(tb_Class.Text.Trim());
            sobj.age = Convert.ToInt32(tb_Age.Text.Trim());
            Dbobj.students.Add(sobj);
            int Ans = Dbobj.SaveChanges();

            if(Ans > 0)
            {
                MessageBox.Show("Data Insert Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Show_Data();
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Data Insertion Failed", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            N_Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            sobj = Dbobj.students.Where(x => x.id == N_Id).FirstOrDefault();
            tb_Name.Text = sobj.name;
            cmb_Gender.SelectedItem = sobj.gender;
            tb_Age.Text = sobj.age.ToString();
            tb_Class.Text = sobj.standard.ToString();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            sobj.id = N_Id;
            sobj.name = tb_Name.Text.Trim();
            sobj.gender = cmb_Gender.SelectedItem.ToString();
            sobj.standard = Convert.ToInt32(tb_Class.Text.Trim());
            sobj.age = Convert.ToInt32(tb_Age.Text.Trim());
            Dbobj.Entry(sobj).State = System.Data.Entity.EntityState.Modified;

            int Ans = Dbobj.SaveChanges();

            if (Ans > 0)
            {
                MessageBox.Show("Data Update Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Show_Data();
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Data Updation Failed", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure to delete data","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes)
            {
                sobj = Dbobj.students.Where(x => x.id == N_Id).FirstOrDefault();
                Dbobj.Entry(sobj).State = EntityState.Deleted;

                int Ans = Dbobj.SaveChanges();

                if (Ans > 0)
                {
                    MessageBox.Show("Data Deleted Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Show_Data();
                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("Data Deleted Failed", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You have cancelled the deleted opration", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
