using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (bilinçsiz dönüşüm)
            //küçük veri tipleri gerektiğinde kendilerinden büyük veri tiplerine otomatik dönüşür.
            

            byte a=5;
            sbyte b=30;
            short c=10;

            int d=a+b+c;
            Console.WriteLine("d:"+d);

            long h=d;
            Console.WriteLine("h:"+h);

            float i =h;
            Console.WriteLine("i:"+i);

            string e="mustafa";
            char f='k';
            object g=e+f+d;
            Console.WriteLine("g:"+g);
            
            
            
            //Explicit Conversion(Bilinçli dönüşüm)

            Console.WriteLine("********* Explicit Conversion *********");

            int x=4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            float w=10.3f;
            byte v=(byte)w;
             Console.WriteLine("v:"+v);
            
            //***ToString Metodu***
            Console.WriteLine("****ToString Metodu****");
            int xx=6;
            string yy=xx.ToString(); // int to string

            string zz=12.5f.ToString(); //float to



        }
    }
}
