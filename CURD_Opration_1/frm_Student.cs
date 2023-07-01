using CURD_Opration_1.Model;
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

namespace CURD_Opration_1
{
    public partial class frm_Student : Form
    {
        int Id = 0;
        Student model = new Student();
        CURD_OneEntities db = new CURD_OneEntities();
        public frm_Student()
        {
            InitializeComponent();
            bindGridView();
        }

        void bindGridView()
        {
            dgv_Info.DataSource = db.Students.ToList<Student>();
        }

        void ResetControls()
        {
            tb_Age.Clear();
            tb_Class.Clear();
            tb_Name.Clear();
            cmb_Gender.SelectedItem = null;
        }
        private void btn_Inseart_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "" && tb_Class.Text != "" && tb_Age.Text != "")
            {
                model.Name = tb_Name.Text.Trim();
                model.Gender = cmb_Gender.SelectedItem.ToString();
                model.Age = Convert.ToInt32(tb_Age.Text.Trim());
                model.Standard = Convert.ToInt32(tb_Class.Text.Trim());
                db.Students.Add(model);
                int Cnt = db.SaveChanges();

                if (Cnt > 0)
                {
                    MessageBox.Show("Data Insert Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    bindGridView();
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }

            }
            else
            {
                MessageBox.Show("Fill All Information");
            }

           
        }

        private void btn_RESERT_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void dgv_Info_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id = Convert.ToInt32( dgv_Info.SelectedRows[0].Cells[0].Value);
            model = db.Students.Where(x => x.Id == Id).FirstOrDefault();
            tb_Name.Text = model.Name;
            tb_Class.Text = model.Standard.ToString();
            tb_Age.Text = model.Age.ToString();
            cmb_Gender.SelectedItem = model.Gender;

        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            model.Id = Id;
            model.Name = tb_Name.Text.Trim();
            model.Gender = cmb_Gender.SelectedItem.ToString();
            model.Age = Convert.ToInt32(tb_Age.Text.Trim());
            model.Standard = Convert.ToInt32(tb_Class.Text.Trim());
            db.Entry(model).State = EntityState.Modified;
            int Cnt = db.SaveChanges();

            if (Cnt > 0)
            {
                MessageBox.Show("Data Update Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                bindGridView();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Data Update Failed");
            }
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Are You sure to delet","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if( Dr == DialogResult.Yes)
            {
                model = db.Students.Where(x => x.Id == Id).FirstOrDefault();
                db.Entry(model).State = EntityState.Deleted;
                int Cnt = db.SaveChanges();

                if (Cnt > 0)
                {
                    MessageBox.Show("Data Deleted Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    bindGridView();
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Data Deleted Failed");
                }
            }
            else
            {
                MessageBox.Show("You Have Cancelled to delete", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}
