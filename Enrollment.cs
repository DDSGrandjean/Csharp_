using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEnrollmentParallel
{
    class Enrollment
    {
        private string[] classArray;
        private int[] currentArray;
        private int[] maxArray;
        private int[] openSeats;

        string cls;
        int open;
        bool found = true;

        public Enrollment(){}
        public string[] ClassArray
        {
            get { return classArray; }
            set { classArray = value; }
        }
        public int[] CurrentArray { set { currentArray = value; } }
        public int[] MaxArray { set { maxArray = value; } }
        public string CLS
        {
            set { cls = value.ToUpper(); }
            get
            {
                OpenSeats();
                if (found)
                    return "Number of seats\t" + open;
                else
                    return "Class not found";
            }
        }  
        private void OpenSeats()
        {
            int position;
            position = Array.IndexOf(ClassArray, cls);
            if (position != -1)
                open = maxArray[position] - currentArray[position];
            else
                found = false;
        }  
        private void CalculateSeats()
        {
            openSeats = new int[maxArray.Length];
            for(int i = 0; i < maxArray.Length; i++)
            {
                openSeats[i] = maxArray[i] - currentArray[i];
            }
        }
        public string Classes()
        {
            string str = string.Empty;

            CalculateSeats();
            for (int i = 0; i < classArray.Length; i++)
                str += classArray[i] + "\t" + currentArray[i] + "\t\t" + maxArray[i] + "\t\t" + openSeats[i] + "\n";
            return str;        
        }
    }
}
