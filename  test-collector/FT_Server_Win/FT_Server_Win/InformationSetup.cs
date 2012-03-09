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
        public delegate void setClassInformation(string subject, DateTime date, int testPeriod, int sumOfStudent, Clocker fromTime, Clocker toTime);
        public setClassInformation setValueFunction;

        public InformationSetup()
        {
            InitializeComponent();
        }

        public InformationSetup(setClassInformation setValue, string subject, DateTime date, int testPeriod, int sumOfStudent, Clocker fromTime, Clocker toTime)
        {
            InitializeComponent();
            setValueFunction = setValue;
            txtSubject.Text = subject;
            dateTimeDate.Value = date;
            numericUpDownStudentCount.Value = sumOfStudent;
            fromTimeHours.Value = fromTime.Hours;
            fromTimeMinutes.Value = fromTime.Minutes;
            toTimeHours.Value   = toTime.Hours;
            toTimeMinutes.Value = toTime.Minutes;
            numericTestPeriod.Value = testPeriod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text;
            DateTime date = dateTimeDate.Value;
            int studentSum = (int)numericUpDownStudentCount.Value;
            Clocker fromTime = new Clocker((int)fromTimeHours.Value, (int)fromTimeMinutes.Value, 0);
            Clocker toTime = new Clocker((int)toTimeHours.Value, (int)toTimeMinutes.Value, 0);

            setValueFunction(subject, date, (int)numericTestPeriod.Value, studentSum, fromTime, toTime);
        }

        private void dateTimeDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
