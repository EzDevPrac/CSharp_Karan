using System;

namespace Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Tables[] _Tables = new Tables[5];
            CofeeTable[] _CofeeTable =  new CofeeTable[5];

           for(int i =0 ;i<_Tables.Length;i++){
            _Tables[i] = new Tables(10,20);
            _CofeeTable[i] = new CofeeTable(20,30);
           // _CofeeTable[0]= new CofeeTable(20,30);
           
            _Tables[i].ShowData();
            _CofeeTable[i].ShowData();
            //_CofeeTable[0].ShowData();
           }
        }
    }
}
