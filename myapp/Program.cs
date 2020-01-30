using System;
using System.IO;
using System.Text;

namespace myapp
    {
    class Program
        {   
            static void Main(string[] args)
            {   
                string words = @"C:\Users\User\Desktop\coding\wordss.txt";
                string[] WordList = File.ReadAllLines(words)[0].Split("   ");
                var length = WordList.Length;
                Random rnd = new Random();
                int index = rnd.Next(0, length);
                string unknownWord = WordList[index];      
                System.Console.WriteLine(unknownWord);    
                WordGame gameStart = new WordGame(Word: unknownWord);
                gameStart.startGame();
                
                
            //     int[][] arrr = {new int[]{7,3,5,6,1,4,8,9,2},
            //                     new int[]{8,4,2,9,7,3,5,6,1},  
            //                     new int[]{9,6,1,2,8,5,3,7,4}, 
            //                     new int[]{2,8,6,3,4,9,1,5,7},  
            //                     new int[]{4,1,3,8,5,7,9,2,6}, 
            //                     new int[]{5,7,9,1,2,6,4,3,8}, 
            //                     new int[]{1,5,7,4,9,2,6,8,3}, 
            //                     new int[]{6,9,4,7,3,8,2,1,5}, 
            //                     new int[]{3,2,8,5,6,1,7,4,9}
            //                     };
            // int [][] arr =  {new int[]{1,5,3},new int[] {4, 8, 7},new int[] {6, 9, 1}};
            // bool val = (sudokuValidator(arrr));
            // string moyin = "moyinoluwa";
            // if (val) // Means if (val == true)
            //     Console.WriteLine("This arrangement is valid.");
            // else
            //     Console.WriteLine("This arrangement is not valid!");
            // System.Console.WriteLine(moyin[2]);
            
            }

            static int[] rot2(int[] arr, int d)
            {
                int diff = arr.Length - (d%arr.Length);
                var arrNew = new int[arr.Length];
                for(int i =0; i < arr.Length; i++)
                {
                    arrNew[(i + diff)%arr.Length] = arr[i];
                }
                return arrNew;
            }

            static int process(int num, int[][] arr)
            {
                int[] nums = new int[num];
                for (int p = 0; p < arr.Length; p++)
                {
                    for (int i = arr[p][0]-1; i < arr[p][1]; i++)
                    {
                        nums[i] += arr[p][2];
                    }
                }
                Array.Sort(nums);
                return nums[nums.Length-1];

            }
            // This function checks to confirm that a row/column contains
            // all and only nine numbers from 1-9
            static bool check(int[] args){
                int[] arr = new int[]{1,2,3,4,5,6,7,8,9};
                foreach(int i in arr){
                    if ((Array.Exists(args, element=> element == i) == false) || (args.Length != 9)){
                        return false;
                    }
                }return true;
            }

            //This function forms/gets the vertical arrays(columns) and uses
            // the *check* fuction to confirm that they meet the  criterium for
            // a complete column/row
            static bool getArray(int[][] args, int column){
                int[] newguy = new int[9];
                for(int i = 0; i < 9; i++){
                    newguy[i] = args[i][column];
                }return check(newguy);
            }
            
            // This function which receives a jagged array and two integers
            // describing the position of number in the array, adds all the
            // numbers in the 3 x 3 cell created at that point to an array and
            // uses the *check* function to confirm it's validity
            static bool checkcell(int[][] arr, int num, int num1){
                int[] temp = new int[9];
                int sn = 0;
                for(int i = 0; i < 3; i++){
                    for(int j = 0; j < 3; j++){
                        temp[sn] = arr[num][num1];  sn += 1; num1 += 1;
                    }num += 1;  num1 -= 3;
                }return check(temp);
            }

            // This function checks the 9 subcells which start at the positons
            // {(0,0), (0,3), (0,6), (3,0), (3,3), (3,6), (6,0), (6,3), (6,6)}
            //  using the *checkcell* function to confirm validity
            static bool checkcells(int[][] arr){
                int m = 0, n = 0;
                for(int i = 0; i < 3; i++){
                    for(int j = 0; j < 3; j++){
                        if(!(checkcell(arr, m, n))){
                            return false;
                        }n += 3;
                    }n = 0;  m += 3;
                }return true;
            }

            // This function which is kind of the main, uses *getArray* to check
            // the columns, *check* for the rows(which are basically all the individual
            // int arrays the jagged array) and *checkcells* for all the subcells
            static bool sudokuValidator(int[][] arg){                         
                for(int i=0; i < 9; i++){
                    if((getArray(arg, i)==false) || (check(arg[i])==false) || checkcells(arg)==false)
                        return false;
                }return true;
            }

        }
    }

    // I WISH YOU A PROSPEROUS NEW YEAR!
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
    //    static int process(int num, int[][] arr)
    //         {
    //             int[] nums = new int[num];
    //             for (int p = 0; p < arr.Length; p++)
    //             {
    //                 for (int i = arr[p][0]; i < arr[p][1] + 1; i++)
    //                 {
    //                     nums[i] += arr[p][2];
    //                 }
    //             }
    //             Array.Sort(nums);
    //             return nums[nums.Length-1];
    //         }

            

            // static int[] rot(int[] arr, long d){
            //     for(int j = 0; j < d%arr.Length; j++)
            //     {
            //         int k = arr[0];
            //         for(int i = 0; i < arr.Length-1; i++)
            //         {
            //             arr[i] = arr[i+1];
            //         }
            //         arr[arr.Length-1] = k;
            //     }
            //     return arr;
            // }


        //     static int getnum(char itr, string arr)
        //     {
        //         int k = 0;
        //         foreach(char i in arr)
        //         {
        //             if (i == itr)
        //             {
        //                 k++;
        //             }
        //         }
        //         return k;
        //     }

        //    static int sumup(params int[] arr)
        //    {
        //         int h = 0;
        //         foreach(int i in arr){
        //            h += i;
        //        }
        //        return h;
        //    }
        // static int countBobs(string str)
        // {
        //     string l;
        //     l = str.ToLower();
        //     int k = 0;
        //     for(int i = 0; i <= (str.Length - 3); i++)
        //     {
        //         if (l.Substring(i, 3) == "bob")
        //         {
        //             k++;
        //         }
        //     }
        //     return k;
        // }

        // static string rev(string word)
        // {
        //     string str = "";
        //     int i = (word.Length - 1);
        //     do {
        //         str += word[i];
        //         i--;
        //     }while(i >= 0);
                
        //     return str;
            
        // }
        
        // string runtime(int n){
        //     return ( n.ToString());
        // }

        // static string sqret(double no){
        //     string num;
        //     if (no >= 0){
        //         num = (Math.Pow(no, 0.5).ToString());
        //     }
        //     else num = (Math.Pow(no*-1, 0.5).ToString())+" i";

        //     return num;
        // }

        // static string[] qsoln(double a, double b, double c)
        // {   
        //     string[] ans = {"0","0"};
        //     double ans1 = 0;
        //     double ans2 = 0;
        //     string ans3 = "0";
        //     string ans4 = "0";
        //     double d = (Math.Pow(b, 2)) - (4*a*c);
        //     if (d >= 0){
        //         ans1 = (Math.Pow(d, 0.5) - b)/(2*a);
        //         ans2 = -1*(Math.Pow(d, 0.5) + b)/(2*a);
        //         ans[0] = ans1.ToString();
        //         ans[1] = ans2.ToString();
        //     }
        //     else{
        //         ans3 = (" - " + (b/(2*a)).ToString() + " + " + sqret(d/(a*a*4)) );
        //         ans4 = " - " + (b/(2*a)).ToString() + " - " + sqret(d/(a*a*4));
        //         ans[0] = ans3;
        //         ans[1] = ans4;
        //     }
            
        //     return ans;
        // }

        // static bool factor(int n){
        //     if ((n == 0) || (n == 1)){
        //         return false;
        //     }
        //     for(int i = 2; i < n; i++){
        //         if (n % i == 0){
        //             return false;
        //         }
        //     }
        //     return true;    
        // }

        // // static int prime(int n){
        //     for(int i=0; i < n; i++){
        //         if(factor(i)==true){
        //             Console.WriteLine(i);
        //         }
        // }  
        //     return 0;
        // }

        


