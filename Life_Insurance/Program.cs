using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Insurance
{
    class Program
    {
        static int Terms()
        {
            
            Console.WriteLine("Select the desired option for Term Plan-");
            Console.WriteLine("1. Calculate Premuim \n2. Modify Amount \n3. Check Entered Details \n4. Go Back");

            int i = int.Parse(Console.ReadLine());

            return i;
        }
        static void sucess()
        {
            Console.WriteLine("Sucess !!!");
        }
        //Checks the validity if Cover amount is within the range
        static bool checkCover(float c)
        {
            if (c >= 5000000 && c <= 50000000)
                return true;

            else
            return false;  
        }

        //Checks validity that if the value in smoker is correct or not
        static bool checkSmoker(int s)
        {
            if (s==1)
                return true;

            if (s == 2)
                return true;

            else
            return false;
        }

        //Checks the validity of the age of the user
        static bool isValidAge(int age)
        {
            if (age >= 20 && age <= 60)
                return true;

            return false;
        }

        // takes Insurance Cover amount and verify it wether it is in range or not
        static float calcCover()
        {
            Console.WriteLine("For Term Plan you need to provide certain details- ");
            Console.Write("Enter the cover amount ");
            float coverOfI = float.Parse(Console.ReadLine());

            bool isCoverRight = checkCover(coverOfI);

            while (isCoverRight == false)
            {
                Console.WriteLine("Cover amount should be between 50 Lakh to 5 Crore only check again");
                coverOfI = float.Parse(Console.ReadLine());
                isCoverRight = checkCover(coverOfI);
            }

            return coverOfI;
        }

        //Checks wether user is a smoker or not and checks wether it is valid or not
        static bool isSmoker()
        {
            Console.WriteLine("Are you a smoker if YES press 1 if NOT press 2");
            int smokerI = int.Parse(Console.ReadLine());

            bool isValid=checkSmoker(smokerI);

            while(isValid==false)
            {
                Console.WriteLine("Select appropriate option");
                smokerI = int.Parse(Console.ReadLine());
                isValid = checkSmoker(smokerI);
            }

            if (smokerI == 1)
                return true;

            else
                return false;              

        }

        //Takes users Age and checks its validity
        static int calcAge()
        {
            Console.WriteLine("Enter your age-");
            int ageI = int.Parse(Console.ReadLine());
            bool isValid = isValidAge(ageI);


            while (isValid == false)
            {
                Console.WriteLine("Your age must be between 20 to 60 years");
                ageI = int.Parse(Console.ReadLine());
                isValid = isValidAge(ageI);
            }

            return ageI;


        }
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                int select;
                Console.WriteLine("Select an appropriate choice-");
                Console.WriteLine("1. Select New Term Plan");
                Console.WriteLine("2. Select New Endowent Plan");
                Console.WriteLine("3. Show Previous Term Plan");
                Console.WriteLine("4. Show Previous Endowent Plan");
                Console.WriteLine("5. Add your own Insurance Plan-");
                Console.WriteLine("6. Exit");

                //takes users desired choice
                select = Convert.ToInt32(Console.ReadLine());
                Term term = new Term();


                switch(select)
                {
                    case 1:
                        float coverI = calcCover(); //This gets the cover amount 
                        bool smoker = isSmoker(); // smoking habit 
                        int age = calcAge();//this checks the validity of the user age and get desired age

                        term = new Term(coverI, age, smoker);

                        //int i=Terms();

                        bool flagt = true;
                        while(flagt)
                        {
                            int i = Terms();
                            //Calculates the Premium of the insurance
                            if (i == 1)
                            {
                                float ans = term.CalcPremium();

                                Console.WriteLine($"Premium amount is {ans}");
                            }
                            //To change the current values of the term plan and modify them
                            else if (i == 2)
                            {
                                Console.WriteLine("Select the desired option you want to modify \n1. Age \n2. Cover Amount \n3. Smoking Status");
                                int modifyI = int.Parse(Console.ReadLine());

                                if (modifyI == 1)
                                {
                                    term.Age = calcAge();
                                    sucess();

                                }

                                else if (modifyI == 2)
                                {
                                    term.CoverOf = calcCover();
                                    sucess();
                                }

                                else if (modifyI == 3)
                                {
                                    if (term.SmokingStatus == true)
                                        term.SmokingStatus = false;

                                    else
                                        term.SmokingStatus = true;

                                    sucess();
                                }
                                else
                                {
                                    Console.WriteLine("You are not eligible for change");
                                }
                            }
                            //to show the values you have entered
                            else if (i == 3)
                            {

                                Console.WriteLine("What would you like to see Select your preferred choice \n1.User age \n2.Users Cover Amount \n3.Tax in % being paid \n4.User is a Smoker or not");
                                int k = int.Parse(Console.ReadLine());

                                if (k == 1)
                                    Console.WriteLine($"Age of the user is {term.Age}");

                                if (k == 2)
                                    Console.WriteLine($"CoverAmount of the user is {term.CoverOf}");

                                if (k == 3)
                                    Console.WriteLine($"Tax % are {term.Tax}%");

                                if (k == 4)
                                    Console.WriteLine($"Current user is smoker = {term.SmokingStatus} ");

                                else if (k > 4)
                                    Console.WriteLine("Input Wrong Better luck next time");

                            }

                            else if (i == 4)
                                flagt = false;

                            else
                            {
                                Console.WriteLine("Select available Options only");
                            }

                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("Select one of these for Endowent Plan-");
                        Console.WriteLine("1. Calculate Premuim \n2. Modify Amount \n3. Check Entered Details \n4. Go back");

                        int j = int.Parse(Console.ReadLine());

                        if (j == 1)
                        {
                            //Calculate Premuim
                        }
                        else if (j == 2)
                        {
                            //Modify Amount
                        }
                        else if (j == 3)
                        {
                            //Check Enetered details
                        }
                        else
                        {
                            //Select available Options only
                        }
                        break;
                    case 3:
                        Console.WriteLine("What would you like to see Select your preferred choice \n1.User age \n2.Users Cover Amount \n3.Tax in % being paid \n4.User is a Smoker or not");
                        int show = int.Parse(Console.ReadLine());

                        if (show== 1)
                            Console.WriteLine($"Age of the user is {term.Age}");

                        if (show == 2)
                            Console.WriteLine($"CoverAmount of the user is {term.CoverOf}");

                        if (show == 3)
                            Console.WriteLine($"Tax % are {term.Tax}%");

                        if (show == 4)
                            Console.WriteLine($"Current user is smoker = {term.SmokingStatus} ");

                        else if (show > 4)
                            Console.WriteLine("Input Wrong Better luck next time");
                        break;

                    case 4:
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please Choose from available list of items");
                            break;
                        }

                }
               
            }
        }
    }
}
