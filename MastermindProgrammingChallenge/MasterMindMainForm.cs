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
    public partial class MasterMindMainForm : Form
    {
        private string name;

        public MasterMindMainForm(string name)
        {
            this.name = name;
            InitializeComponent();
            changeLabelsOnLoad();
        }

        private void changeLabelsOnLoad()
        {
            lblPlayer.Text += name;
        }
        
        
    }
}
