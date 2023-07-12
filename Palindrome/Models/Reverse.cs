using System.Collections.Generic;
using System;

namespace Palindrome.Models
{


    public class ReverseWord
    {
        public string TestReverseWord(string UserInput) {
            List<string> LetterList = new List<string>();
            int WordLength = UserInput.Length;
            for (int index = (WordLength - 1); index != -1; index -= 1) 
            {
                LetterList.Add(UserInput.Substring(index,1));
            }
            return string.Join("", LetterList);
        }
    }
    
    public class ReverseWordTest
    {
        public char[] TestReverse (string word)
        {
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            return wordArray;
        }
    }

}



//         public int UserNum { get; set; }
//         public string Output(int UserNum)
//         {
//             List<string> numbers = new List<string>();
//             for (int index = 1; index <= UserNum; index++)
//             {
//                 if (index % 3 == 0 && index % 5 == 0)
//                 {
//                     numbers.Add("ping pong");
//                 }
//                 else if (index % 3 == 0)
//                 {
//                     numbers.Add("ping");
//                 }
//                 else if (index % 5 == 0)
//                 {
//                     numbers.Add("pong");
//                 }
//                 else
//                 {
//                     numbers.Add(index.ToString());
//                 }
//             }

//             return string.Join(", ", numbers);

//         }
//         public NumTransform(int userNum)
//         {
//             UserNum = userNum;
//         }
//     }
// }













