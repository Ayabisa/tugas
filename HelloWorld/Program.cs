// 1. Deklarasi Pustaka,menyediakan sekumpulan fungsi, kelas, 
//    dan metode yang dapat digunakan dalam program tanpa perlu menulis ulang kode.
using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace HelloWorld
{
    // 2.class, adalah nama program
    class HelloWorld
    {  
        int s = 10;//variabel untuk menyimpan data.
        string divisidncc;
        static void main(string[] args)//3.main funtion,adalah fungsi utama yang akan dieksekusi c#
       {
        Console.WriteLine("BTNG divisi game");//writeline,untuk menampilkan program c# di console
        Console.WriteLine("BTNG divisi game");//kode tanpa variabel
        //kode dengan variabel.
        string divisidncc = "game";// deklarasi variabel
        Console.WriteLine("divisidncc");
        Console.WriteLine("divisidncc");
        //TipeData akan dibaca sesuai dengan isi nilai nya secara otomatis oleh C#
        var divisidncc = "game";
        Console.WriteLine("divisidncc");
        Console.WriteLine("divisidncc");
        //const,digunakan untuk menjadikan variable dan nilainya menjadi immutable.
        const float phi = 3.14f;
        phi = 22.8f;
        Console.WriteLine("divisidncc");
        Console.WriteLine("divisidncc");
        Console.WriteLine("divisidncc");
        //<== ini aadalah komentar multi line. komentar adalah kode program yang diabaikan ketika program dijalankan.
            /*
            contoh komentar multiline
            */
        // tipe data numeber adalah tipe data yang biasanya hanya bisa diisi oleh angka
        // contoh:
        int angka = 10;
        double angkaDouble = 3.14;//tipe data double digunakan ketika angka berkoma.
        float angkafloat =22.5f//tipe data float sama seperti double yang membedakan adalah float harus diakhiri oleh f.
        Console.WriteLine(angka);
        Console.WriteLine(angkaDouble);
        Console.WriteLine(angkafloat);
        //string adalah tipe data yang biasanya menggunakan huruf
        // contoh:
        string firstname;
        string lastname = "game";
        firstname = "divisi";
        Console.WriteLine(firstname);
        Console.WriteLine(lastname);
        // karakter backslash
        string hari = "\tsenin,\tselasa\trabu";
        string bulan ="\rjanuari,\rfebuari,\r maret";
        string film ="\"one piece\"";
        // manipulasi string
        string txt = "ini text";
        Console.WriteLine(txt.ToLower());
        Console.WriteLine(txt.ToUpper());
        Console.WriteLine("panjang string itu adalah"+ length);
        Console.WriteLine(txt."yang digabungkan");
        // array dalam c# digunakan untuk menyimpan koleksi elemen
        string[] divisi = {"game","mobile","jaringan","web","mulmed"};
        Console.WriteLine(divisi[0]);
        Console.WriteLine(divisi[1]);
         Console.WriteLine(divisi[2]);
          Console.WriteLine(divisi[3]);
           Console.WriteLine(divisi[4]);
        string[] names = new string[5];
        names[0] = "game";
        names[0] = "mobile";
        names[0] = "jaringan";
        names[0] = "web";
        names[0] = "mulmed";
        //array multidimensi
        //array 2D
        int[,] number = new int[2,3];
        int[,] number = { {1,2,3} },{ {4,5,6} };
        Console.WriteLine(number[0,1]);
         Console.WriteLine(number[1,2]);
        //array 3D
        int[,,] number =  new int[2,2,3];
        int[,,] number = int{{1,2,3}, {4,5,6,},{7,8,9}, {10,11,12}};
        Console.WriteLine(number[0,0,0]);
         Console.WriteLine(number[1,1,0]);
        // list
        var names = new List<string> {"game","mobile","web"};
        for (int i = 0; i<names.Count; i++);
        {
            Console.Write(names[i] +" ");
        }
        //if-else adalah salah satu pengendalian alur program yang digunakan untuk mengambil keputusan berdasarkan kondisi tertentu
        if i = 5;
        if (1 > i)
        {
            Console.WriteLine("benar");
        }
           else
           {
            Console.WriteLine("salah");
           }
        //switch adalah salah satu struktur kontrol yang digunakan dalam pemrograman untuk membuat keputusan berdasarkan nilai ekspresi yang berbeda.
        int nilai = 75;
        switch (nilai)
        {
            case > 95:
                Console.WriteLine("memuaskan");
                break;
            case > 80:
                Console.WriteLine("baik");
                break;
            case > 75:
                Console.WriteLine("cukup");
                break;
            default:
                Console.WriteLine("kurang");
                break;  
        }



       }
        
    }   

 }