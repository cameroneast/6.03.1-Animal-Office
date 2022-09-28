using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._03._1_Animal_Office
{
    public partial class AddPet : Form
    {
        AnimalOffice main;
        public AddPet(AnimalOffice mainForm)
        {
            InitializeComponent();
            main = mainForm;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Pet newPet = new Pet(txtName.Text, txtAnimal.Text, (int)nudWeight.Value, txtReasonForAdmission.Text, txtDateAdmitted.Text);          //Transfers the pet information to the first form to be displayed.
            main.addNewPet(newPet);
            this.Close();
        }
    }
}
