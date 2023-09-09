using CURD_Opration_5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURD_Opration_5
{
    public partial class frm_Add : Form
    {
        int Id = 0;
        Student Stu = new Student();
        CURD_Opration_5Entities Db = new CURD_Opration_5Entities();
        public frm_Add()
        {
            InitializeComponent();
            Bind_Data();
        }
        void Bind_Data()
        {
            dgv_Student_Info.DataSource = Db.Students.ToList<Student>();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Stu.Name = tb_Name.Text.Trim();
            Stu.Gender = cmb_Gender.SelectedItem.ToString();
            Stu.Age = Convert.ToInt32(tb_Age.Text.Trim());
            Stu.Standard = Convert.ToInt32(tb_Std.Text.Trim());

            Db.Students.Add(Stu);
            int A =  Db.SaveChanges();

            if(A > 0)
            {
                MessageBox.Show("Data Inserted Successfully ");
                Bind_Data();
            }
            else
            {
                MessageBox.Show("Data Inserted Failed ");
            }
        }

        private void dgv_Student_Info_MouseClick(object sender, MouseEventArgs e)
        {
            Id = Convert.ToInt32(dgv_Student_Info.CurrentRow.Cells[0].Value);
            Stu = Db.Students.Where(x => x.Id == Id).FirstOrDefault();

            tb_Name.Text = Stu.Name;
            tb_Age.Text = Convert.ToString(Stu.Age);
            cmb_Gender.SelectedItem = Stu.Gender;
            tb_Std.Text = Convert.ToString(Stu.Standard);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Stu.Id = Id;
            Stu.Name = tb_Name.Text.Trim();
            Stu.Gender = cmb_Gender.SelectedItem.ToString();
            Stu.Age = Convert.ToInt32(tb_Age.Text.Trim());
            Stu.Standard = Convert.ToInt32(tb_Std.Text.Trim());

             Db.Entry(Stu).State = System.Data.Entity.EntityState.Modified;

            int A = Db.SaveChanges();
            if (A > 0)
            {
                MessageBox.Show("Data Inserted Successfully ");
                Bind_Data();
            }
            else
            {
                MessageBox.Show("Data Inserted Failed ");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Are You Sure to Delete Data","Alart",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(Dr == DialogResult.Yes)
            {
                Stu = Db.Students.Where(x => x.Id == Id).FirstOrDefault();
                Db.Entry(Stu).State = System.Data.Entity.EntityState.Deleted;

                int A = Db.SaveChanges();
                if (A > 0)
                {
                    MessageBox.Show("Data Deleted Successfully ");
                    Bind_Data();
                }
                else
                {
                    MessageBox.Show("Data  Deleted Failed ");
                }
            }
            else
            {
                MessageBox.Show("You Cancelled Delete Opration", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}

