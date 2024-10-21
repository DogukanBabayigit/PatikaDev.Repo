using System;

class Program
{
  static void Main(string[] args)
  {
    //-Byte'lar
    byte b = 5;//1 Byte
    sbyte c = 5;//1 Byte

    short s = 5;//2 Byte
    ushort us = 5;//2 Byte 

    Int16 i16 = 5;//2 Byte
    int i = 5;//4 Byte
    Int32 i32 = 5;//4 Byte
    Int64 i64 = 5;//8 Byte

    uint ui = 5;//4 Byte
    long l = 4;//8 Byte
    ulong ul = 5;//8 Byte

    //-Reel Sayilar
    float f = 5;//4 Byte 
    double d = 5;//8 Byte
    decimal de = 5;//16 Byte

    char ch = '2';//2 Byte
    string str = "Dodo"; //sınırsız

    bool b1 = true; //false;

    DateTime dt = DateTime.Now;

    //-String İfadeler
    string str1 = string.Empty;
    str1 = "Dodo";
    string ad = "Dogukan";
    string soyAd = "Babayigit";
    string tamAd = ad + " " + soyAd;

    //-Integer Tanımlamalar
    int s1 = 5;
    int s2 = 3;
    int sum = s1 + s2;

    //-Boolean
    bool bo1 = 10 > 2;

    //-Degisken Donusumleri
    string str2 = "20";
    int s20 = 20;

    string yeniDeger = str2 + s20.ToString(); //Output = 2020

    //-Int Donusumleri
    int sum1 = s20 + Convert.ToInt32(str2);//Output = 40

    int sum2 = s20 + int.Parse(str2);//Output = 40

    //-DateTime

    string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
    System.Console.WriteLine(dateTime);
    string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
    System.Console.WriteLine(dateTime2);
    string dateTime3 = DateTime.Now.ToString("HH:mm");
    System.Console.WriteLine(dateTime3);

    Console.WriteLine("Hello, World!");
  }
}