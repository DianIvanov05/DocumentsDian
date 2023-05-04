using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecomeMilionareQuest1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void questionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.questionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.staniBogat11DDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staniBogat11DDataSet.Questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.staniBogat11DDataSet.Questions);

        }
    }
}
