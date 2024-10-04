using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, mangoPrice, onion, garlic;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //mangoPrice = 45;
            //onion = 9.74;
            //garlic = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyati: " + applePrice + " TL ");
            //Console.WriteLine("---- Portakal Birim Fiyati: " + orangePrice + " TL ");
            //Console.WriteLine("---- Mango Birim Fiyati: " + mangoPrice + " TL ");
            //Console.WriteLine("---- Sogan Birim Fiyati: " + onion + " TL ");
            //Console.WriteLine("---- Sarimsak Birim Fiyati: " + garlic + " TL ");

            //double appleGram, orangeGram, mangoGram, onionGram, garlicGram;

            //appleGram = 1.245;
            //orangeGram = 2.500;
            //mangoGram = 1.820;
            //onionGram = 3.000;
            //garlicGram = 0.452;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double mangoTotalPrice = mangoGram * mangoPrice;
            //double onionTotalPrice = onionGram * onion;
            //double garlicTotalPrice = garlicGram * garlic;


            //Console.WriteLine("Alinan Urun: Elma - " + "Birim Fiyat:" + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alinan Urun: Portakal - " + "Birim Fiyat:" + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alinan Urun: Mango - " + "Birim Fiyat:" + mangoPrice + " - Gramaj: " + mangoGram + " - Toplam Tutar: " + mangoTotalPrice);
            //Console.WriteLine("Alinan Urun: Sogan - " + "Birim Fiyat:" + onion + " - Gramaj: " + onionGram + " - Toplam Tutar: " + onionTotalPrice);
            //Console.WriteLine("Alinan Urun: Sarimsak - " + "Birim Fiyat:" + garlic + " - Gramaj: " + garlicGram + " - Toplam Tutar: " + garlicTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + mangoTotalPrice + onionTotalPrice + garlicTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alisveris Toplam Tutar:" + shoppingTotalPrice + " TL ");




            #endregion

            #region Char Degiskenler

            //' ile tanimlaniyor

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girisleri String Degiskenler

            //Console.WriteLine("*** CSharp HY Yolcu Bilgisi ***");
            //Console.WriteLine("");

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerID;

            //Console.Write(" Yolcu Adi: ");
            //passengerName = Console.ReadLine();

            //Console.WriteLine(" Yolcu Soyadi: ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write(" Ilce Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write(" Sehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write(" Yas Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write(" Kimlik Numarasi: ");
            //passengerID = Console.ReadLine();



            //Console.WriteLine("---------------");
            //Console.WriteLine(" Yolcu TC Kimlik No " + passengerID + " " + "Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge +  " ");



            #endregion

            #region Klavyeden Tam Sayi Girisleri ve Donusumler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 300;
            //tvPrice = 5000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lutfen aldiginiz ayakkabi sayisini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz bilgisayar sayisini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz sandalye sayisini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz tv sayisini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice= shoesCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice +  tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Odemeniz Gereken Tutar: " + totalPrice );




            #endregion

            #region Klavyeden Ondalikli Sayi Islemleri

            //double exam1, exam2, result;

            //Console.Write("Lutfen 1. Sinav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2. Sinav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2) / 2;

            //Console.WriteLine();
            //Console.WriteLine("Sinav Ortalamasi: " + result);



            #endregion

            #region Klavyeden Karakter Girisleri

            //char gender;
            //Console.Write("Lutfen Cinsiyet Seciniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Sectiginiz Cinsiyet: " + gender);



            #endregion


            Console.Read();
        }
    }
}
