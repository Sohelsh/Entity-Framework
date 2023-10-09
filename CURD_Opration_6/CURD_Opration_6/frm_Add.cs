using CURD_Opration_6.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURD_Opration_6
{
    public partial class frm_Add : Form
    {
        SchoolEntities Db = new SchoolEntities();
        Student Stu = new Student();

        int N_Id = 0;
        public frm_Add()
        {
            InitializeComponent();
            Data_Show();
        }

        int Auto_Incr()
        {
            int Cnt = Db.Students.Count();
            if (Cnt > 0)
            {
                int Max = Db.Students.Max(p => p.Id);
                Cnt = (Max+ 1);
            }
            else
            {
                Cnt = (Cnt + 101);
            }
            return Cnt;

        }

        void Reset()
        {
            tb_Id.Text = Convert.ToString(Auto_Incr());
            tb_Age.Clear();
            tb_Name.Clear();
            tb_Std.Clear();
            cmb_Gender.SelectedIndex = -1;
        }
        void Data_Show()
        {
            dataGridView.DataSource = Db.Students.ToList<Student>();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Stu.Name = tb_Name.Text;
            Stu.Age = Convert.ToInt32(tb_Age.Text);
            Stu.Standard = Convert.ToInt32( tb_Std.Text);
            Stu.Gender = cmb_Gender.SelectedItem.ToString();

            Db.Students.Add(Stu);

            int Ans = Db.SaveChanges();

            if(Ans > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
                Data_Show();
                Reset();
            }
            else
            {
                MessageBox.Show("Data Inserted Failed");
            }
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            N_Id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

            Stu = Db.Students.Where(x => x.Id == N_Id).FirstOrDefault();

            tb_Id.Text = Convert.ToString (Stu.Id);
            tb_Name.Text = Stu.Name;
            tb_Age.Text = Convert.ToString(Stu.Age);
            tb_Std.Text = Convert.ToString(Stu.Standard);
            cmb_Gender.SelectedItem = Stu.Gender;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Stu.Name = tb_Name.Text;
            Stu.Age = Convert.ToInt32(tb_Age.Text);
            Stu.Standard = Convert.ToInt32(tb_Std.Text);
            Stu.Gender = cmb_Gender.SelectedItem.ToString();

            Db.Entry(Stu).State = System.Data.Entity.EntityState.Modified;

            int Ans = Db.SaveChanges();

            if (Ans > 0)
            {
                MessageBox.Show("Data Updated Successfully");
                Data_Show();
            }
            else
            {
                MessageBox.Show("Data Updated Failed");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Are You Sure","",MessageBoxButtons.YesNo);

            if(Dr == DialogResult.Yes)
            {
                Stu = Db.Students.Where(x => x.Id == N_Id).FirstOrDefault();
                Db.Entry(Stu).State = System.Data.Entity.EntityState.Deleted;

                int Ans = Db.SaveChanges();

                if (Ans > 0)
                {
                    MessageBox.Show("Data Deleted Successfully");
                    Data_Show();
                }
                else
                {
                    MessageBox.Show("Data Deleted Failed");
                }
            }
            else
            {
                MessageBox.Show("Your Delete Opration Cancel");
            }
        }

        private void frm_Add_Load(object sender, EventArgs e)
        {
            Reset();
           
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
