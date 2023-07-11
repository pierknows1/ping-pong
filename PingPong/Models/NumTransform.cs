using System.Collections.Generic;
using System;

namespace PingPong.Models
{

    public class NumTransform
    {
        public int UserNum { get; set; }

        // public static List<NumTransform>
        // _instances = new List<NumTransform> { };
        public string Output()
        {
            if (UserNum % 3 == 0 && UserNum % 5 == 0)
            {
                return "ping pong";
            }
            else if (UserNum % 3 == 0)
            {
                return "ping";
            }
            else if (UserNum % 5 == 0)
            {
                return "pong";
            }
            else
            {
                return UserNum.ToString();
            }
        }
        public NumTransform(int userNum)
        {
            UserNum = userNum;
           // _instances.Add(this);
        }

        public string NumLoop(string UserNum) 
        {
            Output();
            
            // string[] theEntireArray = {};
            // for (int index = 0; index < theEntireArray.Length; index++)
            // {
            //     Console.WriteLine($"{index}: {theEntireArray[index]}");
            // }
        }
    }

}


//this is for a commit

// planetLeft (){
//   let left = this.expectancy - this.earthAge;

//   if (left > 0) {
//     this.left = `you have ${left} years to live.`
//   } else if (left < 0 ){
//     this.left = `You have lived ${Math.abs(left)} past your expectancy.`
//   } else {
//     this.left = `You have reached your life expectancy.`;
//   }
//   return this.left;
//   }
// }

// test('should return years lived past expectancy on mercury', () => {
//             let planet = new Age (28, 38);
//             planet.mercury();
//             expect(planet.planetLeft()).toEqual("You have lived 79 past your expectancy.")
//           });

//pierknows1 pierknows@gmail.com 


//ESC18 <ponderosaprintingus@gmail.com>



// Business Logic
// let arr = [];

// function arraySave(savedValue) {
//     arr.push(savedValue);
//     display(arr);
// }

// function tester (index) {
//     if (index.toString().includes("3") === true) {
//         index = " Won't you be my Neighbor? "
//         let savedValue = index;
//         arraySave(savedValue);
//     } else if (index.toString().includes("2") === true) {
//         index = " Beep";
//         let savedValue = index;
//         arraySave(savedValue);
//     } else if (index.toString().includes("1") === true) {
//         index = " Boop ";
//         let savedValue = index;
//         arraySave(savedValue);
//     } else {
//         let savedValue = index;
//         arraySave(savedValue);
//     }
// }



// UI Logic
// function counter (event) {
//     arr = [];
//     event.preventDefault();
//     let value = document.getElementById("input").value; 
//     for (let index = 0; index <= value; index++) {
//         tester(index);
//     }
// }

// window.onload = function () {
//     let form = document.getElementById("form");
//     form.addEventListener("submit",counter);
// }

// function display(arr) {
//     let output = document.querySelector("p");
//     output.innerHTML = arr.toString();
// }