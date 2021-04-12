using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Insurance
{
    class Term
    {
        private float sa;
        private float coverOf;
        private int age;
        private bool smokingStatus;
        private float tax=10.0f;
        private float premiumAmnt = 0.0f;
        private float premiumPercent = 0.0f;

        
        public Term()
        {
            this.sa = 0.0F;
            this.age = 0;
            this.coverOf = 0.0f;
            this.smokingStatus = false;
        }
        
        public Term(float cover,int age,bool smokingStatus)
        {
            this.coverOf = cover;
            this.age = age;
            this.smokingStatus = smokingStatus;
        }
     
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public bool SmokingStatus
        {
            get
            {
                return smokingStatus;
            }
            set
            {
                smokingStatus = value;
            }
        }
        public float Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }

        }
        public float CoverOf
        {
            get
            {
                return coverOf;
            }
            set
            {
                coverOf = value;
            }
        }

        
        public float CalcPremium()
        {
            if (age >= 20 && age < 30)
                premiumPercent = 0.1f;

            if (age >= 30 && age < 40)
                premiumPercent = 0.15f;

            if (age >= 40 && age < 50)
                premiumPercent = 0.2f;

            if (age >= 50 && age <= 60)
                premiumPercent = 0.25f;


            //Console.WriteLine(premiumPercent);
            if (SmokingStatus==true)  //to get the value from getter method
            {
                premiumPercent += 0.05f;
            }

            premiumAmnt = (coverOf * premiumPercent / 100);
            premiumAmnt+=calcTax(premiumAmnt);
     
            return premiumAmnt;
        }
        public float calcTax(float premiumA)
        {
            return (premiumA * tax / 100);
        }

        public void show()
        {
            Console.WriteLine($"{ Convert.ToString(age)},{ CoverOf}, { SmokingStatus}");
        }
        
    }

}
