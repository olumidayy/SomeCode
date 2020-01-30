// using System;
// namespace myapp
// {
//     class lettheBattlebegin
//     {
//         public static int[] getResult(Warrior warriorA, Warrior warriorB)
//         {
//             int att = warriorA.genAttack();
//             int blk = warriorB.genBlock();
//             int diff = blk - att;
//             if (diff < 0)
//             {
//                 warriorB.health += diff;
//             }else diff = 0;
//             int[] arr = {warriorB.health, att, blk, diff};
//             return arr;
//         }

//         public static void startfight(Warrior warriorA, Warrior warriorB){
            
//                 while (true)
//                 {
//                     int[] arr = (lettheBattlebegin.getResult(warriorA, warriorB));
//                     warriorB.health = arr[0];
//                     Console.WriteLine($"{warriorA.name} dealt an attack of {arr[1]}, and {warriorB.name} a block of {arr[2]}, giving a resultant damage of {arr[3]}!"); 
//                     if(warriorB.health <= 0)
//                     {
//                         Console.WriteLine($"{warriorA.name} wins as {warriorB.name} loses with a health of {warriorB.health}");
//                         break;
//                     }

//                     int [] ar = (lettheBattlebegin.getResult(warriorB, warriorA));
//                     warriorA.health = ar[0];
//                     Console.WriteLine($"{warriorB.name} dealt an attack of {ar[1]}, and {warriorA.name} a block of {ar[2]}, giving a resultant damage of {ar[3]}!"); 
//                     Console.WriteLine($"{warriorA.name} health: {warriorA.health}\n{warriorB.name} health: {warriorB.health}");  
//                     if(warriorA.health <= 0)
//                     {
//                         Console.WriteLine($"{warriorB.name} wins as {warriorA.name} loses with a health of {warriorA.health}");
//                         break;
//                     }
//                 } 
//         }
//     }
// }


