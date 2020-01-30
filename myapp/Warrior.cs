// using System;
// namespace myapp
// {
//     class Warrior
//     {
//         public string name{set; get; }
//         public int health{set; get; }
//         public int maxatt{set; get; }
//         public int maxblk{set; get; }
//         Random rnd = new Random();

//         public Warrior(string Name = "Warrior x", int Health = 1000, int Maxatt = 0, int Maxblk = 0)
//         {
//             name = Name;
//             health = Health;
//             maxatt = Maxatt;
//             maxblk = Maxblk;
//         }

//         public int genAttack()
//         {
//             return rnd.Next(1, maxatt);
//         }
        
//         public int genBlock()
//         {
//             return rnd.Next(1, maxblk);
//         }

        
//     }
// }