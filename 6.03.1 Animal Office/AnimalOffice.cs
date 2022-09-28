using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace _6._03._1_Animal_Office
{
    public partial class AnimalOffice : Form
    {


        public Pet newPet;
        List<Pet> Pets = new List<Pet>();
        int AddToRow = 2;



        public AnimalOffice()
        {
            InitializeComponent();
        }

        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Worksheet excelSheet;

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            AddPet addPet = new AddPet(this);
            addPet.Show();
        }

        #region ConvertPetToListViewFunction
        public ListViewItem ConvertPetToLSVI(Pet pet)
        {
            string[] info = new string[] { CorrectName(pet.Name), pet.Animal, pet.Weight.ToString(), pet.Rfa, pet.DateAdmitted };
            return new ListViewItem(info);
        }
        #endregion

        #region addNewPet
        public void addNewPet(Pet pet)
        {
            Pets.Add(pet);
            listView1.Items.Add(ConvertPetToLSVI(pet));
        }
        #endregion

        #region CorrectNameString
        public string CorrectName(string Name)
        
        {
            char lastletter = Name[0];
            //Remove Excess Spaces
            while(Name.Contains("  "))
            {
                Name = Name.Remove(Name.IndexOf("  "), 1);
            }
        
            //Make all letters lower case
            char[] Letters = new char[Name.Length];
            for (int i = 0; i < Name.Length; i++){
                Letters[i] = Char.ToLower(Name[i]);
            }
            //Cap first letter of every name
            for(int i = 0; i < Name.Length; i++)
            {
                try
                {
                    if (Letters[i - 1] == ' ' && char.IsLetter(Letters[i + 1]))
                    {
                        Letters[i] = char.ToUpper(Letters[i]);
                    }
                }
                catch
                {

                }
            }
            Letters[0] = char.ToUpper(Letters[0]);
            return new string(Letters);
  
        }
        #endregion




        private void AnimalOffice_Load(object sender, EventArgs e)
        {
            #region AddFromExcelToListView
            Excel.Application xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"E:\Programming\CPII\Animal Office Animals.xlsx", 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            excelSheet = xlWorkBook.ActiveSheet;
            Excel.Range rng = (Excel.Range)excelSheet.Cells[2, 1];

            int Rows = xlWorkSheet.UsedRange.Rows.Count;

            for (int i = 2; i < Rows + 1; i++)
            {
                string[] Pet = new string[] { CorrectName(xlWorkSheet.Cells[i, 1].Value.ToString()), xlWorkSheet.Cells[i, 2].Value.ToString(), xlWorkSheet.Cells[i, 3].Value.ToString(), xlWorkSheet.Cells[i, 4].Value.ToString(), xlWorkSheet.Cells[i, 5].Value.ToString() };
                listView1.Items.Add(new ListViewItem(Pet));
                Pets.Add(new Pet(Pet[0], Pet[1], Convert.ToInt32(Pet[2]), Pet[3], Pet[4]));
            }
            #endregion
        }

        string dir = "E:\\Programming\\CPII\\Animal Office Animals.xlsx";
   

        private void button1_Click(object sender, EventArgs e)
        {
            if (xlWorkSheet == null)
            {
                MessageBox.Show("You must load in a database or excel file to overwrite to first");
                return;
            }
            int AddToRow = 1;
            foreach (Pet pet in Pets)
            {
                AddToRow++;
               xlWorkSheet.Cells[AddToRow, 1] = CorrectName(pet.Name);
               xlWorkSheet.Cells[AddToRow, 2] = pet.Animal;
               xlWorkSheet.Cells[AddToRow, 3] = pet.Weight.ToString();
               xlWorkSheet.Cells[AddToRow, 4] = pet.Rfa;
               xlWorkSheet.Cells[AddToRow, 5] = pet.DateAdmitted;
            }
            xlApp.DisplayAlerts = false;
            xlWorkBook.Close(true, dir);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
