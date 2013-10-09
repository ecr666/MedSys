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

        public Doctor_Main_Window()
        {
            // TODO: Complete member initialization
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String slot = radioButton2.Text; ;
            if (radioButton1.Checked)
            {
                slot = radioButton1.Text;
            }
            PrescriptionGrid.Rows.Add(txtName.Text, cmbForm.Text, boxInTime.Text, slot, comboBox2.Text, comboBox5.Text, comboBox1.Text);
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {

        }
    }
}
