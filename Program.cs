using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karyawan2595.Induk;
using Karyawan2595.Anak;

namespace Karyawan2595
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            //membuat objek utk semua karyawan
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.nik = "122-334-455";
            karyawanTetap.nama = "Alydrus Handoko";
            karyawanTetap.gajibulanan = 4000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.nik = "111-222-333";
            karyawanharian.nama = "Pandu Renjana";
            karyawanharian.JmlJamKerja = 8;
            karyawanharian.UpahperJam = 13000;

            Sales sales = new Sales();
            sales.nik = "123-111-456";
            sales.nama = "David";
            sales.JmlPenjualan = 30;
            sales.Komisi = 45000;

            //objek class collection
            List<Karyawan> listkaryawan = new List<Karyawan>();
            listkaryawan.Add(karyawanTetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik : {1}, Nama: {2}, Gaji:{3}", noUrut, karyawan.nik, karyawan.nama, karyawan.gaji());

                noUrut++;
            }
            Console.ReadKey();
            
        }
    }
}
