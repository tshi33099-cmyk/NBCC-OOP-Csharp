using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
// Date: 2026-01-15
// Name: TiantianShi
// Description: This lab creating a pet class and using a form to manage
// Pet data and demostrates oop conceopts 

namespace Shi_lab1_Petapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Decleare a variable to hold the pet object, but not create yet
            Pet mypet;
            //check if the Text property of the name textbox is empty
            if (txtPetName.Text == "") 
            {
                //No name entered, use the default constructor
                mypet = new Pet();
             
                int currentAge = (int)nudAge.Value;
                //from 0
                mypet.Age = currentAge + 1;
            }
            
            else
            {
                //entered name so we need get data from form
                //create a temporary string variable to store the selected pet type
                string selectedType = "";
                if (rdoBird.Checked == true)
                {
                    selectedType = "Bird";
                }
                //if a radiobutton was checked the type string to it's text
                else if (rdoCat.Checked == true)
                {
                    selectedType = "Cat";
                }
                else
                {
                    selectedType = "Dog";
                }

                //Instantiate the object using the parameterized constructor
                //pass the things from the from output to class
                mypet = new Pet(txtPetName.Text, (int)nudAge.Value, selectedType);
            }
            //call the Displaypet method to get the formmated string 
            //add the string to the Items collection of the listBox
            lstOutput.Items.Add(mypet.DisplayPet());
        }
        //method to reset all form controls to their initial default state.
        private void ResetForm()
        {

            txtPetName.Text = "";
            nudAge.Value = 3;
            rdoCat.Checked = true;
            lstOutput.Items.Clear();
            txtPetName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
//2026-01-17
