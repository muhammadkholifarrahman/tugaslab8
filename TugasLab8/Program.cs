using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "52382395992";
            karyawanTetap.Nama = "Kholif";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "148328692375";
            karyawanHarian.Nama = "Ahmad";
            karyawanHarian.JumlahJamKerja = 50;
            karyawanHarian.UpahPerJam = 30000;

            Sales sales = new Sales();
            sales.Nik = "173229245624";
            sales.Nama = "Rama";
            sales.JumlahPenjualan = 100;
            sales.Komisi = 10000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}