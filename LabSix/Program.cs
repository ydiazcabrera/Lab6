using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSix
{
    class Program
    {
             
        static void Main(string[] args)
        {
            Random random = new Random();
                                

            while (true)
            {
               Console.WriteLine("Welcome to Grand Circus Casiono!");
               

               Console.WriteLine("How many sides should each die have?");
               int nside = int.Parse(Console.ReadLine());
            

               Console.WriteLine("How many dice?");
               int ndice=int.Parse(Console.ReadLine());
            
            
               int result = GetRoll(nside,ndice, random);
               Console.WriteLine(result);
                           

                Console.WriteLine("Roll again? (Y/N)");
                string answer= Console.ReadLine();
                if(answer=="N" || answer == "no") 
                break;

              {  }
                
            }

            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }

        public static int GetRoll(int side, int dice,Random r)
        {
            int result= 0;

            for (int i=0; i< dice; i++)
            {
                int roll = 0;
                roll = GetRandom(side,r);
                Console.WriteLine("rolled a "+ roll);
                result+= roll;
            }   

            if (result == 2)
            {
             Console.WriteLine("You rolled: " + result + " \'Snake Eyes!\'");  
            }
            else if (result == 12)
            {
          Console.WriteLine("You rolled: " + result + " \'Box Cars!\'");
            }
            else
            {
          Console.WriteLine("You rolled: " + result);
            }

            //Display result CRAPS! on 2, 3, 12
            if (result == 2 || result == 3 || result == 12)
            {
          Console.WriteLine("CRAPS!");
            }
            return result;

            
        }

        public static int GetRandom(int nside, Random r)
        {
            
            return r.Next(1,nside +1);
             
        }

        
        

        
    }
}
