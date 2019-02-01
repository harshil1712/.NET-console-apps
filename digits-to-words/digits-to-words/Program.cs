using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digits_to_words
{
    class Program
    {
        public static String singleDigit(int n)
        {
            String singleDigitWord = "";
            switch(n){
                case 0:
                    singleDigitWord = "Zero";
                    break;
                case 1:
                    singleDigitWord = "One";
                    break;
                case 2:
                    singleDigitWord = "Two";
                    break;
                case 3:
                    singleDigitWord = "Three";
                    break;
                case 4:
                    singleDigitWord = "Four";
                    break;
                case 5:
                    singleDigitWord = "Five";
                    break;
                case 6:
                    singleDigitWord = "Six";
                    break;
                case 7:
                    singleDigitWord = "Seven";
                    break;
                case 8:
                    singleDigitWord = "Eight";
                    break;
                case 9:
                    singleDigitWord = "Nine";
                    break;
            }
            return singleDigitWord;
        }

        public static String twoDigit(int n)
        {
            String twoDigitWord = "";

            switch (n)
            {
                case 10:
                    twoDigitWord = "Ten";
                    break;
                case 11:
                    twoDigitWord = "Eleven";
                    break;
                case 12:
                    twoDigitWord = "Twelve";
                    break;
                case 13:
                    twoDigitWord = "Thirteen";
                    break;
                case 14:
                    twoDigitWord = "Fourteen";
                    break;
                case 15:
                    twoDigitWord = "Fifteen";
                    break;
                case 16:
                    twoDigitWord = "Sixteen";
                    break;
                case 17:
                    twoDigitWord = "Seventeen";
                    break;
                case 18:
                    twoDigitWord = "Eighteen";
                    break;
                case 19:
                    twoDigitWord = "Ninteen";
                    break;
                case 20:
                    twoDigitWord = "Twenty";
                    break;
                case 30:
                    twoDigitWord = "Thirty";
                    break;
                case 40:
                    twoDigitWord = "Fourty";
                    break;
                case 50:
                    twoDigitWord = "Fifty";
                    break;
                case 60:
                    twoDigitWord = "Sixty";
                    break;
                case 70:
                    twoDigitWord = "Seventy";
                    break;
                case 80:
                    twoDigitWord = "Eighty";
                    break;
                case 90:
                    twoDigitWord = "Ninty";
                    break;
            }

            return twoDigitWord;
        }

        static void Main(string[] args)
        {
            int userNumber = 0;
            String word = "";
            Console.Write("Enter the number: ");
            userNumber = Convert.ToInt16(Console.ReadLine());

            if(userNumber>=0 && userNumber <= 9)
            {
                word = singleDigit(userNumber);
            }
            else if(userNumber >=10 && userNumber <= 99)
            {
                if(userNumber/10 != 1)
                {
                    int secondDigit = (userNumber / 10) * 10;
                    int unitDigit = userNumber % 10;
                    if(unitDigit == 0)
                    {
                        word = twoDigit(secondDigit);
                    }
                    else
                    {
                        word = twoDigit(secondDigit) + " "+singleDigit(unitDigit);
                    }                    
                }
                else
                {
                    word = twoDigit(userNumber);
                }
            }
            else
            {
                int thirdDigit = userNumber /100;
                int secondDigit = (userNumber % 100)/10;
                int unitDigit = userNumber % 10;
                if (userNumber % 100 <= 19 || unitDigit == 0)
                {
                    word = singleDigit(thirdDigit) + " Hundred " + twoDigit(userNumber % 100);
                }
                else
                {
                    word = singleDigit(thirdDigit) + " Hundred " + twoDigit(secondDigit*10)+ " "+ singleDigit(unitDigit);
                }
            }

            Console.Write(word);
            Console.Read();
        }
    }
}
