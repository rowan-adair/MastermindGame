using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MastermindProgrammingChallenge
{
    public partial class StartMastermind : Form
    {
        public StartMastermind()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            MasterMindMainForm nextForm = new MasterMindMainForm(name);
            nextForm.Show();
            Hide();
        }
    }
}
