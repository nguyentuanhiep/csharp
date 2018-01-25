using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hangman();
           UpdateHangman();           
        }
        static void Hangman() {
            
            string input ="vietnem";
            char[] new_input = input.ToCharArray();     
            Console.WriteLine("Bat dau choi game doan chu nhe");
            Console.WriteLine("Tu can tim co 7 chu cai");
                
            char[] output = new char[input.Length];
            for (int i=0; i< input.Length; i++) {
                output[i] = '-';
            }

            while (true) {
                Console.WriteLine("Nhap chu cai");
                
                try {
                    char word = char.Parse(Console.ReadLine());
                    for (int k=0; k<input.Length; k++) {
                        if(word == input[k]) {
                            output[k] =  word;
                        }                           
                    }
                }
            
                catch (System.FormatException) {
                    Console.WriteLine("Ban chi duoc nhap 1 ki tu");
                    continue;
                }
                Console.WriteLine(output);

                if(output.SequenceEqual(new_input)==true)
                    {
                        Console.WriteLine("Ban da doan dung roi day");
                        break;
                    }
                              
            }

        }

        static void UpdateHangman() 
        {
            string[] list = new string[5];
            list[0] = "vietnam";
            list[1] = "hanoi";
            list[2] = "techmaster";
            list[3] = "csharp";
            list[4] = "hiep";

            Random result = new Random();
            var temp = result.Next(0,5);
            string input = list[temp];
            char[] new_input = input.ToCharArray();

            Console.Write("Nhap 1 so bat ki:");
            char[] output = new char[input.Length];
            for (int i=0; i< input.Length; i++) {
                output[i] = '-';
            }

            while (true) {
                // Console.WriteLine("Nhap chu cai");
                
                try {
                    char word = char.Parse(Console.ReadLine());
                    for (int k=0; k<input.Length; k++) {
                        if(word == input[k]) {
                            output[k] =  word;
                        }                           
                    }
                }
            
                catch (System.FormatException) {
                    Console.WriteLine("Ban chi duoc nhap 1 ki tu");
                    continue;
                }
                Console.WriteLine(output);

                if(output.SequenceEqual(new_input)==true)
                    {
                        Console.WriteLine("Ban da doan dung roi day");
                        break;
                    }
                              
            }

        }
        
    }
}
