

internal class Program
{
    private static void Main(string[] args)
    {
        char mySymbol = (char)65;
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Teyyan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*   // - comment
             *   string - sozleri tutur
             *   cw + TAB + TAB
             *   ad soyad yas;
             *   = - menimsetmek ucundu
             *   == - beraberdir
             *   bool - Boolean (true yada False qaytarir)
             *   Double - Heqiqi ededler
             *   object
             *   (2 ustu 63 )-1 e kimi ozunde saylayir
             *   > <  >= <=
             *   != beraber deil
             *   && ve demekdir 2 sert birden odenmelidir
             *   || ve ya demekdir 2 sertden 1 i ve ya 2 side odense olar
             *   ! inkar edir
             *   % - qaliqli bolme ( renainder sign )
             *   $"   {}"
             *   static ve dinamik
             *   static kenardan mudaxile lazm deyil
             *   dinamic istifadeci deyerleri manual olaraq oturur
             *   console.readline - strip qaytarir
             *   console.readline - tip cevrilmesi vermeliyik (String --> Integer)
             *   int.parse(cossole.readline()) <--> convert.Toint32(consele.readline())
             *   
             *   adlandirma qaydasi
             *   camel case - adlandirma 2 sozden ibaretdirse 2 ci sozun bas herfi boyuk olmalidir (firstName)
             *   pascal case - adlandirma 2 sozden ibaretdirse her sozun bas herfi boyuk olmalidir (FirstName)
             *   
             *  \n new line
             *  \t tab qeder bosluq qoyur
             *  if (a>0 && a< 10)
             *  {
             *    Console.Writeline("a ededi 0 ve 10 arasindadi");
             *  }
             *  else if(a>10 && a<20)
             *  {
             *     Console.Writeline("a ededi 10 ve 20 arasindadi");
             *  }
             *  
             *  if ((a>0 && a<100) || (a>200 && a<300))
             *   { 
             *    Console.Writeline(" eded 0-100 ve ya 200-300 arasindadir");
             *    }
             *    else
             *    {
             *        Console.Writeline(" eded 0-100 ve ya 200-300 arasinda deyil")
             *    }
             *    
             *    
             *    
             *    int hour = int.Parse(Console.Readline());
             *    int minute = int.Parse(Console.Readline());
             *    if ((hour == 23) && (minute >= 45 && minute < 60))
             *    {
             *      Console.Writeline($"0 : {minute+15-60:0#}");
             *    }
             *    else if ((minute >= 0 && minute < 45))
             *    {
             *       Console.WriteLine($"{hour} : {minute+15}");
             *    }
             *    else if (minute >= 45 && minute < 60)
             *    {
             *      Console.Writeline(&"{hour+1} : {minute+15-60:0#}");
             *    }
             *    
             *    //operators
             *    
             *    //unary operator
             *      int x = 5;
             *      x = x + 3;
             *      x +=3;
             *      x++;
             *      Console.WriteLine(++x);
             *      Console.Writeline(x);
             *      
             *      //binary operator
             *       int x = 10;
             *       int y = 30;
             *       Console.WriteLine(x>y);
             *       
             *       //ternary operator
             *       int x = 60;
             *       if (x>50)
             *       {
             *         Console.WriteLine("x boyukdur 50 den");
             *       }
             *       else
             *       {
             *         Console.WriteLine("x kicikdir 50 den");
             *       }
             *       
             *       Console.Writeline(x > 50 ? "x boyukdur 50 den" : "x kicikdir 50 den");
             *       Console.Redkey();
            




             
             
             

            int x = 34;
            int y = 10;
            int z = x * y;
            Console.WriteLine(z);
            Console.WriteLine(31>69);
            Console.WriteLine(16!=8);
            int t = 41;
            int f= 31;
            Console.WriteLine(t%f);
            double pi = 3.14;
            double uzunluq = 18;
            Console.WriteLine(pi);
            Console.WriteLine(uzunluq);
            int yas = 18;
            string Name = "Teyyan Rzayev";
            Console.WriteLine(yas);
            Console.WriteLine(Name);
            
            
            int age1 =int.Parse( Console.ReadLine());

            string Name1 = Console.ReadLine();
            Console.WriteLine($"hello {Name} {age1}");

            Console.ReadLine(); 
            int bal = 80;

            if (bal > 40) 
            {
                Console.WriteLine("delayed");
                
            }

            else
            {
                Console.WriteLine("failed to pass");
                
            }


           
            Console.ReadLine();
           

            */



/*
int pul = 1000;
Console.WriteLine("ATM ye xos gelmisiz");
Console.WriteLine("etmek istediyinizi secin");
String secim = Console.ReadLine();

if (secim== "1")
{
    Console.WriteLine("indiki pulunuz : "+pul);
    Console.ReadLine();
}
else if (secim== "2")
{
    Console.WriteLine("cixartmaq istediyiniz mebleqi girin");

    int cixardilacaq_mebleq = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("qalan mebleq :"+(pul-cixardilacaq_mebleq));
    Console.ReadLine();
}

else if(secim=="3")
{
    Console.WriteLine("Artirmaq istediyiniz mebleqi girin");
    int artirilacaq_mebleq = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Yeni meblqiniz:"+(artirilacaq_mebleq+pul));
    Console.ReadLine();
}
else if( secim=="q")
{
    Console.WriteLine( "Atm den cixilir"  );
    Console.WriteLine("cixis yerine yetirildi xos gunler...");
    Console.ReadLine();


}
else
{
    Console.WriteLine("xais olunur gecerli bir qiymet girin");
    Console.ReadLine();
}
*/

/*

int pul = 700;
Console.WriteLine("ATM ya xos gelmisiniz...");
Console.WriteLine("etmek istediynizi secin");
Console.WriteLine("1-pulunuz");
Console.WriteLine("2-pul cixartmaq");
Console.WriteLine("3-pul artirmaq");
Console.WriteLine("4-cixis etmek");

string secim = Console.ReadLine();
switch (secim)
{
    case "1":
        Console.WriteLine(pul);
        Console.ReadLine();
        break;

    case "2":
        Console.WriteLine("cixarmaq istediyniz mebleqi girin");
        int cixarilacaq_mebleq = Convert.ToInt32(Console.ReadLine());
        if (cixarilacaq_mebleq > pul)
        {
            Console.WriteLine("mebleqinizden cox cixara bilmersiz");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("qalan pulunuz " + (pul - cixarilacaq_mebleq));
            Console.ReadLine();
        }
        break;

    case "3":
        Console.WriteLine("artirmaq istediyiniz mebleqi girin");
        int artirilacaq_pul = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("teze balansiniz  :" + (pul + artirilacaq_pul));
        Console.ReadLine();
        break;

    case "4":

        Console.WriteLine("heabinizdan cixilir xos gunler");
        Console.ReadLine();
        break;

    default:
        Console.WriteLine("xais olunur gecerli bir sey girin");
        Console.ReadLine();
        break;









}            }

}
}
*/