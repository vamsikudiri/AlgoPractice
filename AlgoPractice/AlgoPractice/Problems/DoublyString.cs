using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    public class DoublyString : Problem, INormalSolution
    {

        string input = string.Empty;
        bool isYes;

        public void SetInput(string inputString)
        {
            input = inputString;
        }

        public bool VerifyWithExpectedValue(bool expectedValue)
        {
            return isYes == expectedValue;
        }

        public void CalculateSolution()
        {

            if (string.IsNullOrEmpty(input))
            {
                isYes = true;
            }
            else if (input.Length == 1)
            {
                isYes = false;
            }
            else if (input.Length % 2 == 0)
            {
                isYes = true;

                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] != input[i + input.Length / 2])
                    {
                        isYes = false;
                        break;
                    }
                }

            }
            else
            {

                bool leftToRight = true, rightToLeft = true;
                int numberOfChances = 1;

                for (int i = 0, j = input.Length / 2; i < input.Length / 2; i++, j++)
                {
                    if (input[i] != input[j])
                    {
                        if (numberOfChances == 0)
                        {
                            leftToRight = false;
                            break;
                        }
                        else
                        {
                            numberOfChances--;
                            j++;
                        }
                    }
                }

                numberOfChances = 1;

                for (int i = input.Length - 1, j = input.Length / 2; i > input.Length / 2 ; i--, j--)
                {
                    if (input[i] != input[j])
                    {
                        if (numberOfChances == 0)
                        {
                            rightToLeft = false;
                            break;
                        }
                        else
                        {
                            numberOfChances--;
                            j--;
                        }
                    }
                }

                isYes = leftToRight || rightToLeft;
            }

        }
    }
}
