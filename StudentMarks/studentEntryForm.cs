using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarks
{
    public partial class studentEntryForm : Form
    {
        public studentEntryForm()
        {
            InitializeComponent();
        }

        private void studentEntryForm_Load(object sender, EventArgs e)
        {

            studentEntryForm form = new studentEntryForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;   
            form.Show();
        }
    }
}
