using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factorial();
            //CountDigits();
            //Capitalise();
            //SecondLargest();
            QuadraticFunc();
        }

        static void Factorial() {
          try {
              Console.WriteLine("Nhap vao 1 so nguyen bat ki");
              int input = Convert.ToInt32(Console.ReadLine());
              int k =1;
              for (int i=1; i <= input ; i++) {
                 k = k * i;
            }
            Console.WriteLine("{0} giai thua bang {1}", input, k);
          }

          catch (System.FormatException) {
              Console.WriteLine("Nhap lai 1 so di ban");
          }
        }

        static void CountDigits(){
            try {
                Console.WriteLine("Nhap vao 1 so nguyen bat ki");
                int input=Convert.ToInt32(Console.ReadLine());
                string output = Convert.ToString(input);
                int sum =0;
                for (int i=0; i < output.Length; i++) {   
                   sum += (int)Char.GetNumericValue(output[i]);
                }
                Console.WriteLine("Tong cac chu so cua so vua nhap la {0}",sum);
            }
            
            catch (System.Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        

        static void Capitalise() {
          try {
               Console.WriteLine("Nhap vao 1 chuoi ki tu");
           string input = Console.ReadLine();
           string[] arr = input.Split(' ');
           string output= "";
           
           for (int i=0; i < arr.Length; i++) {
               output = output + " " + char.ToUpper(arr[i][0]) + arr[i].Substring(1, arr[i].Length-1);
           }
           Console.WriteLine(output);
          }

          catch (System.Exception e) {
                Console.WriteLine(e.Message);
            }
           
        }


        static void SecondLargest()
        {
            try {
                Console.WriteLine ("Ban muon so sanh bao nhieu so ?");
                int input = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[input];
                 for (int i =0; i <input; i++)
                {
                    Console.WriteLine("Nhap vao so");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int so_lon_nhat =0, so_lon_thu_hai =0, temp;
                for (int k=0; k < arr.Length; k++)
                {
                    if(arr[k] > so_lon_nhat) {
                        temp = so_lon_nhat;
                        so_lon_nhat = arr[k];
                        so_lon_thu_hai =temp;
                    }
                }
                Console.WriteLine("So lon thu hai la {0}", so_lon_thu_hai);
            }

             catch (System.Exception e) {
                Console.WriteLine(e.Message);
            }
        }


        static void QuadraticFunc()
        {
            try {
                Console.WriteLine("Hay nhap cac so a,b,c cua phuong trinh bac 2 dang ax^2 + bx +c = 0");
                Console.WriteLine("Nhap a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap b");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap c");
                int c = Convert.ToInt32(Console.ReadLine());
            
                int delta = b*b - 4*a*c;
                double Sqrt_delta = Math.Sqrt(delta);

                if (a==0) {
                    Console.WriteLine("Khong phai phuong trinh bac 2");
                } else if (a !=0) {
                    if (delta > 0) {
                        double x1 = (-b + Sqrt_delta)/(2*a);
                        double x2 = (-b - Sqrt_delta)/(2*a);
                        Console.WriteLine("Phuong trinh co 2 nghiem la x1 = {0} va x2 = {1}", x1 ,x2);
                    }

                    if (delta == 0) {
                        double x  = -b/(2*a);
                        Console.WriteLine("Phuong trinh co nghiem kep x = x1 = x2 = {0}", x);
                    }

                    if (delta < 0) {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
            }

             catch (System.Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
