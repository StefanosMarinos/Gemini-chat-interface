using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace telikiergasia2
{
    public partial class statsform : Form
    {
        private stats statistics;

        public statsform()
        {
            InitializeComponent();

            stats statsManager = new stats();

            string first = statsManager.GetFirstQuestion();
            string last = statsManager.GetLastQuestion();
            string longest = statsManager.GetLongestQuestion();

            label1.Text = "Πρωτη Ερώτηση: " + first;
            label3.Text = "Τελευταία Ερώτηση: " + last;
            label2.Text = "Μεγαλύτερη Ερώτηση: " + longest;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
