using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act4
{
    public partial class Form1 : Form
    {
        //form1 constructor
        public Form1()
        {
            InitializeComponent();
        }

        /*List declarations that take a struct as a DataType*/
        List<PlanStruct> mealPlansList = new List<PlanStruct>();
        List<PlanStruct> dormsList = new List<PlanStruct>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //passing mealplan.txt to readfile to read the info from file
            String FN1 = "mealplans.txt";
            String[] mealplan = new String[3]; //string array to hold the number of lines in the file
            readFile(FN1, mealplan, mealPlansList);
           

            //passing dorm.txt to readFile to read the info from file
            string FN2 = "dorms.txt";
            string[] dorm = new string[4]; //string array to hold the number of lines in the file
            readFile(FN2, dorm, dormsList);
            
            /*place the contents of the lists into the combobox*/
            foreach(PlanStruct p in mealPlansList)
            {
                //cbMeal.Items.Add(p.code + "-" + p.description + "-" + p.cost); 
                cbMeal.Items.Add(p);
            }
           cbMeal.SelectedIndex = 0;// set default index

            foreach(PlanStruct p in dormsList)
            {
                //cbDorm.Items.Add(p.code + "-" + p.description + "-" + p.cost);
                cbDorm.Items.Add(p);
            }
           cbDorm.SelectedIndex = 0;// set default index

        }

        //struct declaration that holds variables that represents attributes of this program
        public struct PlanStruct
        {
            public string code;
            public string description;
            public decimal cost;

            //struct constructor
            public PlanStruct(string code, string description, decimal cost)
            {
                this.code = code;
                this.description = description;
                this.cost = cost;
            }

            public override string ToString()
            {
                return this.code + "--" + this.description;
            }
        }

        //read text files and copy the content to the employee list
        public void readFile(String file, String[] array, List<PlanStruct> list)
        {
            StreamReader fileIn;
            fileIn = File.OpenText(file);

            string lineIn; //holds each line from the Employees.txt

            if (File.Exists(file))
            {
                //splitter array 
                String[] splitter = new String[3];

                while (!fileIn.EndOfStream)
                {
                    PlanStruct plan = new PlanStruct(); // object of the struct 
                    
                    lineIn = fileIn.ReadLine();
                    splitter = lineIn.Split(','); // split the line at the , character

                    //pass each element to the list 
                    plan.code = splitter[0];
                    plan.description = splitter[1];
                    plan.cost = Convert.ToDecimal(splitter[2]);
                    list.Add(plan);
                }
            }

            //if file doesnt exist, show an error message
            else
            {
                MessageBox.Show("Not able to open file!");
            }
            fileIn.Close(); // close file
        }

        //exit button
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Shows the costs of two selected items from the ComboBox and total
        private void bCost_Click(object sender, EventArgs e)
        {
            //gets the of the selected item 
            PlanStruct selectedMeal = (PlanStruct) cbMeal.SelectedItem; 
            PlanStruct selectedDorm = (PlanStruct) cbDorm.SelectedItem;

            //construct strings to print on form2
            String mealPrint = "Meal Plan: $" + selectedMeal.cost + " per semester!";
            String DormPrint = "Dormitory: $" + selectedDorm.cost + " per semester!";
            String totalPrint = "Total: $" + (selectedMeal.cost + selectedDorm.cost);

            //show the dialog
            PlanTotal form2 = new PlanTotal(mealPrint, DormPrint, totalPrint);   
            form2.ShowDialog();
        }




        
    }
}
