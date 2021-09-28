using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //programm küsib kasutaja käest PIN-koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234,siis konsool kuvab "Tere tulemast"
            //kui sisestatud PIN-kood on midagi muud ,konsool kuvab "vale-PIN. Proovi uuesti."
            //tingimus 1. katsete arv on piiramatu
            //tingimus 2. kasutajal on kolm katset
            /*
            int i = 0;
           while (i < 3)
            {
                Console.WriteLine("Hello World");
                i = i + 1;
            }
            Console.WriteLine("Kena päeva");*/
            
             //boolean =true/false 

            //*while (true)
            
            {
                Console.WriteLine("Sisesta PIN-kood");
                int UserPIN = Convert.ToInt32(Console.ReadLine());

                
                if(UserPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
                  else                
                {
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                }


            }*/
              
            //tingimus 2. kasutajal on kolm katset

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN-kood:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                    
                    {
                     else
                    }
                    
                    {
                        i = i + 1;
                        Console.WriteLine($"Vale PIN.{ 3 - i } katset on jäänud.");
                        {
                            Console.WriteLine("Kena päeva");
                        } 
                    }
              
   

      
                
        
           
        }
    }
}
