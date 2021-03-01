﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // bu classlara CRUD - Creat Read Update Delete denir

        public void Add(Product product) //void -> Git bir iş yap, git ekle demektir. İşlem  yaptırırız. 
        {
            Console.WriteLine(product.ProductName + " Eklendi ");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi ");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2) //Burada sayi1 ve sayi2 toplanıp ekrana yazdırılır.
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        //public void BiSeyYap(int sayi)
        //{
        //    sayi = 99;
        //}
    }
}