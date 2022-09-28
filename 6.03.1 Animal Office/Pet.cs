using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._03._1_Animal_Office
{
    public class Pet
    {
        private string name;
        private string animal;
        private int weight;
        private string rfa;                     //Stands for Reason for Admission
        private string dateAdmitted;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Animal
        {
            get
            {
                return animal;
            }

            set
            {
                animal = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
        public string Rfa
        {
            #region ReasonForAdmission
            get
            {
                return rfa;
            }

            set
            {
                rfa = value;
            }
            #endregion
        }
        public string DateAdmitted
        {
            get
            {
                return dateAdmitted;
            }

            set
            {
                dateAdmitted = value;
            }
        }

        public Pet(string name, string animal, int weight, string rfa, string admissionDate)
        {
            this.name = name;
            this.animal = animal;
            this.weight = weight;
            this.rfa = rfa;
            this.dateAdmitted = admissionDate;
        }
    }
}
