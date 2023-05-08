using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class FrmLogin : Form {
        string username = "nastavnik";
        string password = "test";
        public FrmLogin() {
            InitializeComponent();
        }

        private void lblKorIme_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Form1_Click(object sender, EventArgs e) {

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
                if (txtKorIme.Text == username && txtLozinka.Text == password)
                {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtKorIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
