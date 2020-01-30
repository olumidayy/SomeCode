using System;

namespace myapp{

    class Babies{
        public string name;
        public int age;
        public int weight;

        public Babies(string name = "none", int age = 0, int weight = 1){
            Name = name;
            Age = age;
            Weight = weight;
        }
        public string Name{
            set {
                name = value;
            }
            get {return name;}
        }

        public int Age{
            get{return age;}

            set{
                age = value;
            }
        }

        public int Weight{
            get{return weight;}

            set{
                weight = value;
            }
        }
        }
        
    }
