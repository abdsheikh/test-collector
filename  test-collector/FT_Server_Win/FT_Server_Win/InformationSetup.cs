using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FT_Server_Win
{
    public partial class InformationSetup : Form
    {
        public delegate void setClassInformation(string subject, DateTime date, int sumOfStudent);
        public setClassInformation setValueFunction;

        public InformationSetup()
        {
            InitializeComponent();
        }

        public InformationSetup(setClassInformation setValue)
        {
            InitializeComponent();
            setValueFunction = setValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text;
            DateTime date = dateTimeDate.Value;
            int studentSum = (int)numericUpDownStudentCount.Value;
            setValueFunction(subject, date, studentSum);
        }

        
    }
}
