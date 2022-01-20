using System;

namespace IterationStatementsExercise3Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();

            PrintNumbersBy3();

            var userAge = UserAge();
            var friendAge = FriendAge();

            EqualChecker(userAge, friendAge);

            IsOddOrEven();

            IsPosOrNeg();

            AgeChecker(userAge);

            IntegerRange();

            MultiplyTable();

        }
        
        //All methods below

        public static void PrintNumbers()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
            
        }

        public static void PrintNumbersBy3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static int UserAge()
        {
            bool ageRange;
            int num1;

            do
            {
                while (true)
                {
                    Console.WriteLine("How old are you? ");
                    if (int.TryParse(Console.ReadLine(), out num1))
                    {
                        break;
                    }
                    Console.WriteLine("It has to be a whole number! No decimals or letters you crazy person!");
                }
                
                if (num1 > 0 && num1 < 120)
                {
                    ageRange = true;
                }
                else
                {
                    Console.WriteLine($"Impossible! There is no way you are {num1}. Try again! No funny business this time!");
                    ageRange = false;
                }

            } while (ageRange == false);
            
            return num1;
        }

        public static int FriendAge()
        {
            bool ageRange;
            int num1;

            do
            {
                while (true)
                {
                    Console.WriteLine("How old is your best friend? ");
                    if (int.TryParse(Console.ReadLine(), out num1))
                    {
                        break;
                    }
                    Console.WriteLine("It has to be a whole number! No decimals or letters you crazy person!");
                }

                if (num1 > 0 && num1 < 120)
                {
                    ageRange = true;
                }
                else
                {
                    Console.WriteLine($"Impossible! There is no way they are {num1}. Try again! No funny business this time!");
                    ageRange = false;
                }

            } while (ageRange == false);
            
            return num1;
        }

        public static void EqualChecker(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"You and your best friend are both {num1}!");
            }
            else
            {
                Console.WriteLine($"You are {num1}, and your friend is {num2}. You are not the same age!");
            }
        }

        public static void IsOddOrEven()
        {
            bool yearBorn;

            do
            {

                int num1;
                while (true)
                {
                    Console.Write("What year were you born? No funny business now! ");
                    if (int.TryParse(Console.ReadLine(), out num1))
                    {
                        break;
                    }
                    Console.WriteLine("It has to be a whole number! No decimals or letters you crazy person!");
                }

                if (num1 > 1900 && num1 < 2022)
                {
                    var response = (num1 % 2 == 0) ? $"You were born on an EVEN year!" : $"You were born on an ODD year!";
                    Console.WriteLine(response);
                    yearBorn = true;
                }
                else
                {
                 Console.WriteLine($"No way you were born in {num1}! Tell me your real birth year!");
                 yearBorn = false;
                 } 
            
            } while (yearBorn == false);
            
        }
            
        public static void IsPosOrNeg()
        {
            int num1;
            while (true)
            {
                Console.Write("Give me a random number that is either positive or negative: ");
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                Console.WriteLine("It has to be a whole number! No decimals or letters you crazy person!");
            }

            var response = (num1 < 0) ? $"{num1} is a negative number! You need a more positive mindset!" : $"{num1} is a positive number! Don't let those negitive thoughts creep in!";
            Console.WriteLine(response);
        }

        public static void AgeChecker(int userAge)
        {

            var response = (userAge >= 18) ? $"I already know that you are {userAge}. It looks like you're old enough to vote!" : $"I already know that you are {userAge}. Too bad, you are too young to vote!";
            Console.WriteLine(response);
            
        }

        public static void IntegerRange()
        {
            bool userNumber;

            do
            {

                int num1;
                while (true)
                {
                    Console.Write("Give me a number between -10 and 10. I dare you to try something out of that range! ");
                    if (int.TryParse(Console.ReadLine(), out num1))
                    {
                        break;
                    }
                    Console.WriteLine("It has to be a whole number! No decimals or letters you crazy person!");
                }

                if (num1 >= -10 && num1 <= 10)
                {
                    Console.WriteLine("You're no fun!");
                    userNumber = true;
                }
                else
                {
                    Console.WriteLine($"Hahahaha! Did you really think you could get away with typing {num1}? Try again you fool!");
                    userNumber = false;
                }

            } while (userNumber == false);

        }

        public static void MultiplyTable()
        {
            int userNumber;
            while (true)
            {
                Console.Write("Give me any random number, and I'll multilply it by the numbers 1 through 12: ");
                if (int.TryParse(Console.ReadLine(), out userNumber))
                {
                    break;
                }
                Console.WriteLine("It has to be a whole number! No decimals or letters you crazy person!");
            }
            var multiplyTo = 12;
            int product = 0;

            for (int i = 1; i <= multiplyTo; i++)
            {
                product = userNumber * i;
                Console.WriteLine($"{userNumber} X {i} = {product}");
            }
        }

    }
}
