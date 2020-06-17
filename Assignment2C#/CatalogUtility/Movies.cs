using System;

namespace CatalogUtility
{
    public class Movies : Catalog
    {

        private string Director,Actor,Actress;

        public string _Director { get => Director; set => Director = value; }
        public string _Actor { get => Actor; set => Actor = value; }
        public string _Actress { get => Actress; set => Actress = value; }

        public virtual void Play(){
           Console.WriteLine("Not Implemented"); 
        }

        public virtual void RetrieveInfo(){
            Console.WriteLine("Connecting to network");
        }
        
    }
}