using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class AddSymptomToDisease
    {
        public string DiseaseName { get; set; }
        public string Sym_name { get; set; }
        public string Discription { get; set; }

    }
    class Sym_To_Dis_Repo
    {
        private  Array[] Sym = null;
        private int Size = 0;
        public Sym_To_Dis_Repo(int size)
        {
             
            Size = size;
            Sym = new Array[Size];
        }
        public void AddDisease(AddSymptomToDisease astd)
        {
            for (int i = 0; i < Size; i++)
            {
                if (Sym[i] == null)
                {
                    Sym[i] = new AddSymptomToDisease { DiseaseName = astd.DiseaseName, Sym_name = astd.Sym_name, Discription = astd.Discription };
                    
                }
            }
        }
        public void AddSymptom(AddSymptomToDisease astd)
        {
            for (int i = 0; i < Size; i++)
            {
                if (Sym[i] == null)
                {
                    Sym[i] = new AddSymptomToDisease { DiseaseName = astd.DiseaseName, Sym_name = astd.Sym_name, Discription = astd.Discription };

                }
            }
        }

    }
    class UIPage
    {
        public const string Menu ="~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~MEDICAL RESEARCH SOFTWARE~~~~~~~~~~~~~~~~~~~\n" +
            "To Add Disease to the System------------------------->PRESS 1\n" +
            "To Add Sympton to the Disease------------------>PRESS 2\n" +
            "To get Check Patient details--------------->PRESS 3\n" +
            "PS: PRESS ANY OTHER KEY TO EXIT.....................................";
        static Sym_To_Dis_Repo Repo;
        public static void pat()
        {
            
            int size =  Utilities.GetNumber("Enter the size");

            Repo = new Sym_To_Dis_Repo(size);
            Console.WriteLine(Repo);

            bool returnValue = true;

            do
            {
                string choice = Utilities.GetValue(Menu);

                returnValue = SwitchFunction(choice);

            } while (returnValue);

            Console.WriteLine("Thank you for using the application");
        }

        public static bool SwitchFunction(string choice)
        {
            switch (choice)
            {
                case "1":
                    //AddSymptom();
                    break;
                default:
                    return false;
            }
            return true;
        }

    }
    class Patient
    {
        string Name;
        string Sym_Name;

        public string PatientName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string SymptomName
        {
            get { return Sym_Name; }
            set { Sym_Name = value; }
        }
    }
    class MedicalResearchApp
    {
        static void patientData()
        {
            Patient patient = new Patient { PatientName = "Rajesh", SymptomName = "Fever" };
            Console.WriteLine("The Patientname is " + patient.PatientName);
            Console.WriteLine("The symptom is " + patient.SymptomName);
        }
        public void AddSymptomToDiseaseCreation()
        {
            AddSymptomToDisease astd = new AddSymptomToDisease { DiseaseName = "Maleria", Sym_name = "Fever", Discription = "Temperature Above 102 F" };
            Console.WriteLine("The Disease is " + astd.DiseaseName);
            Console.WriteLine("The symptom is " + astd.Sym_name);
            Console.WriteLine("The disease discription "+ astd.Discription );
        }
        static void Main(string[] args)
        {
            patientData();
            UIPage.pat();
            //AddSymptomToDiseaseCreation();
        }
    }
}
