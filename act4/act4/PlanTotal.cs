using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act4
{
    public partial class PlanTotal : Form
    {
        //constructor that initializes the labels, with the values passed in from another form
        public PlanTotal(string l1, string l2, string l3)
        {
            InitializeComponent();
            this.label1.Text = l1;
            this.label2.Text = l2;
            this.label3.Text = l3;
        }


        //closes the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanTotal_Load(object sender, EventArgs e)
        {

        }


    }
}
