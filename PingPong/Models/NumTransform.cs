using System.Collections.Generic;
using System;

namespace PingPong.Models
{

    public class NumTransform
    {
        public int UserNum { get; set; }
        public string Output(int UserNum)
        {
            List<string> numbers = new List<string>();
            for (int index = 1; index <= UserNum; index++)
            {
                if (index % 3 == 0 && index % 5 == 0)
                {
                    numbers.Add("ping pong");
                }
                else if (index % 3 == 0)
                {
                    numbers.Add("ping");
                }
                else if (index % 5 == 0)
                {
                    numbers.Add("pong");
                }
                else
                {
                    numbers.Add(index.ToString());
                }
            }

            return string.Join(", ", numbers);

        }
        public NumTransform(int userNum)
        {
            UserNum = userNum;
        }
    }
}













