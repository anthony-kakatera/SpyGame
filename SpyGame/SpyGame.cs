namespace SpyGame
{
    public class SpyGame
    {
        static void Main(string[] args)
        {
            // request statement
            Console.WriteLine("Provide your statement");
            string statement = Console.ReadLine();
            //perform jump five
            string result = performJumpFive(statement);

            //printing out array as string
            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static string performJumpFive(string? statement)
        {
            //create char array from statement
            char[] charArry = statement.ToCharArray();

            //loop through char array
            for (int i = 0; i < charArry.Length; i++)
            {
                if (Char.IsDigit(charArry[i]))
                {
                    //performing jump five
                    if (charArry[i].Equals('0') || charArry[i].Equals('5'))
                    {
                        //jump five called
                        charArry[i] = jumpFive(5, charArry[i]);
                    }
                    else
                    {
                        //jump five called
                        charArry[i] = jumpFive(10, charArry[i]);
                    }
                }
            }
            //get array as string
            return string.Join("", charArry);
        }

        //jump five algorithm
        public static char jumpFive(int num, char digit)
        {
            int tempValue = (int)Char.GetNumericValue(digit);
            int jumpValue = num - tempValue;
            return Char.Parse(jumpValue.ToString());
        }
    }
}