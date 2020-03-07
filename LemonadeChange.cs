using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChalleng
{
    class LemonadeChange
    {
        public bool LemonadeChangeMEthod(int[] bills)
        {
            int five = 0;
            int tens = 0;
            int twenty = 0;
            bool change = false;

            foreach(int element in bills)
            {
               if(element == 5)
                {
                    five = ++five;
                    change = true;
                }
               else if(element == 10)
                {
                    tens = ++tens;
                    if (five > 0)
                    {
                        five = --five;
                        change = true;
                    }
                    else
                        change = false;
                    
                }
               else if(element == 20)
                {
                    twenty = ++twenty;
                    if (five>= 3 && tens == 0)
                    {
                        five -= 3;
                        change = true;
                    }
                    else if (five >=1 && tens >=1)
                    {
                        five -= 1;
                        tens -= 1;
                        change = true;
                    }
                    else
                    {
                        return false;
                    }
                    
                }
                else
                {
                    return false;
                }
            }

            return change;
        }
    }
}
