using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{

    public delegate void AnalyzeNumber();

    class Runtime
    {
        public event AnalyzeNumber NumberInput;

        int numberInput;

        public void Start()
        {

            Console.WriteLine("Type in a number");
            int result;
            bool isANumber = int.TryParse(Console.ReadLine(), out result);
            if (isANumber == true)
            {
                numberInput = result;
            }
            else
            {
                Console.WriteLine("Error! must type in a number...");
            }
            NumberInput += new AnalyzeNumber(IsEven);
            NumberInput += new AnalyzeNumber(IsDivisableByThree);
            NumberInput += new AnalyzeNumber(IsPrimeNumber);

            NumberInput.Invoke();
            Console.ReadLine();
            
        }

        public void IsEven()
        {
            if (numberInput % 2 == 0)
                Console.WriteLine("Number is even");
            else
                Console.WriteLine("Number is odd");
        }

        public void IsDivisableByThree()
        {
            if (numberInput % 3 == 0)
                Console.WriteLine("Number is divisable by three");
            else
                Console.WriteLine("Number is NOT divisable by three");
        }

        public void IsPrimeNumber()
        {
            bool isPrime = true;
            for (int i = 2; i < numberInput; i++)
            {
                if (numberInput % 1 == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine("Is prime: " + isPrime);
        }
    }
}
