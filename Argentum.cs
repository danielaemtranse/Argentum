using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argentum
{
    public partial class Argentum : Form
    {
        public Argentum()
        {
            InitializeComponent();
        }

        private void Argentum_Shown(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Argentum_Load(object sender, EventArgs e)
        {

        }
    }
}
