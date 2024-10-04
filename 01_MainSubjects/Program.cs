using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdirmaKomutlari   
            ////Console.WriteLine("Merhaba Dunya");
            ////Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri ***** ");
            //Console.WriteLine();
            //Console.WriteLine("1-Corbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Ara Sicaklar");
            //Console.WriteLine("4-Mezeler");
            //Console.WriteLine("5-Icecekler");
            //Console.WriteLine("6-Tatlilar");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri ***** ");

            #endregion

            #region StringDegiskenler

            //string
            //Degisken_turu degisken adi;

            //string name;
            //name = "Omer";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;


            //customerName = "Omer";
            //customerSurname = "Kirici";
            //customerPhone = "+49 15228309188";
            //customerEmail = "bbccnn@gmail.com";
            //district = "Alexanderplatz";
            //city = "Berlin";

            //Console.WriteLine("*** Rezervasyon Karti *** ");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Iletisim: " + customerPhone + " " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------");

            //Console.WriteLine();



            //customerName = "Nur";
            //customerSurname = "Gul";
            //customerPhone = "+49 15438239023";
            //customerEmail = "nrg@gmail.com";
            //district = "Alexanderplatz";
            //city = "Berlin";

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Iletisim: " + customerPhone + " " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------");


            #endregion


            #region Int Degiskenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 30;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int donerPrice = 150;

            Console.WriteLine("*** Restoran Menu Fiyati*** ");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger " + hamburgerPrice + " TL ");
            Console.WriteLine("-----Kola " + cokePrice + " TL ");
            Console.WriteLine("-----Su " + waterPrice + " TL ");
            Console.WriteLine("-----Patates  " + friesPrice + " TL ");
            Console.WriteLine("-----Pizza  " + pizzaPrice + " TL ");
            Console.WriteLine("-----Doner  " + donerPrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("*** Restoran Menu Fiyati*** ");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int donerCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalDonerPrice;
               

            

            hamburgerCount = 0;
            cokeCount = 3;
            waterCount = 0;
            friesCount = 1;
            pizzaCount = 0;
            donerCount = 3;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokeCount;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalDonerPrice = donerCount * donerPrice;

            Console.WriteLine("------------------");
            Console.WriteLine("Hamburger Tutari: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutari: " + totalCokePrice + "TL");
            Console.WriteLine("Su Tutari: " + totalWaterPrice + "TL");
            Console.WriteLine("Patates Tutari: " + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutari: " + totalPizzaPrice + "TL");
            Console.WriteLine("Doner Tutari: " + totalDonerPrice + "TL");


            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalHamburgerPrice + totalDonerPrice;

            Console.WriteLine("Toplam Odenecek Tutar: " + totalPrice + " TL ");






            #endregion

            Console.Read();
        }
    }
}




//Yazdırma Komutları
