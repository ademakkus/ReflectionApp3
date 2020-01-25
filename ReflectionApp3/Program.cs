using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
    #region Person sınıfı
    class Person
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
        public string KisiBilgileriniGetir()
        {

            return string.Format("ID:{0} adınız  {1} ve soyadınız {2}", _id, _ad, _soyad);
        }
        public Person(int id, string ad, string soyad)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
        }
        public Person()
        {

        }

    } 
    #endregion
}
