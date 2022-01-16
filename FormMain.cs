using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WheelBearings
{
    public partial class FormMain : Form
    {

        private IconButton currentBtn;
        private Form currentChildForm;

        public FormMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnEnterData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTable());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            
        }
    }
}
