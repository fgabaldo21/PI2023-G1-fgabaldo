using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1 {
    public partial class FrmLogin : Form {
       public static Teacher LoggedTeacher { get; set; }
        public FrmLogin() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtKorIme.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoggedTeacher = TeacherRepository.GetTeacher(txtKorIme.Text);
                if (LoggedTeacher != null && LoggedTeacher.CheckPassword("txtLozinka")) ;
                {
                    FrmStudents frmStudents = new FrmStudents();
                    frmStudents.Text = $"{LoggedTeacher.FirstName } {LoggedTeacher.LastName}";
                    Hide();
                    frmStudents.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
