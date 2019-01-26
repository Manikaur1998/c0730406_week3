using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730406_week3
{
    class Program
    {
        static void Main(string[] args)




            
        {

        }
    }

    class Countryside
    {
        Village Alst;
        Village Mealand;
        Village Schenig;

        public void InstialltizeMap()
        {
             Alst = new Village();
            Alst.VillageName = "Alst";
             Mealand = new Village();
            Mealand.VillageName = "Mealand";
            Mealand.isAstrildeHere = true;
            Schenig = new Village();
            Schenig.VillageName = "Schenig";

            Alst.NextVillage = Mealand;
            Mealand.NextVillage = Schenig;
            Schenig.NextVillage = Alst;

        }
        public void FindAstrilde()
        { 
           Village CurrentVillage = this.Mealand;
          if   (CurrentVillage.isAstrildeHere)
            {
                Console.WriteLine("Hugi Found Astride !!!Celebrations!XOXO");
            }
           Village NextVillage;

            NextVillage = CurrentVillage.NextVillage;
           
        
        
        
    }
    class Village
    {
       
       public Village PreviosVillage;
        public Village NextVillage;
        public String VillageName;
         public bool isAstrildeHere = false;
        public  Village() { }

    }

 


}
