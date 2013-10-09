using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_Sys.GUIs
{
    public partial class Doctor_Main_Window : Form
    {
        AppointmentsHandler apm = new AppointmentsHandler();

        public Doctor_Main_Window(string docID)
        {
            InitializeComponent();
            LogLabel.Text = docID;
            AppointmentGrid.DataSource= apm.refreshDB().Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
