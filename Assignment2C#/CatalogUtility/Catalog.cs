using System;
namespace CatalogUtility
{
    public class Catalog
    {
        private string Name;
        private string Code;
        private string category;
        private double size;



        public string _Name { get => Name; set => Name = value; }
        public double _Size { get => size; set => size = value; }
        public string _Category { get => category; set => category = value; }
        public string _Code1 { get => Code; set => Code = value; }

        
    }
}