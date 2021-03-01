using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategortId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategortId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            }; // Alternatif yazış şekli

            //Pascal Case   //Camel Case
            ProductManager productManager = new ProductManager();
            productManager.Add(product1); // parantez içine parametreler atılır
            Console.WriteLine(product1.ProductName);
            // Name = Kamera //method ile buradan referansı göndeririz.


            productManager.Topla2(3, 6); //Product Managerdaki voidli toplaya atandı. İşlem yapılıp ekrana yazıldı.
                                           //Burada sadece işlem yapıldı geri dönüş alınamadı.
            int toplamaSonucu = productManager.Topla(2, 4); //Product Managerdaki intli toplaya atandı. int tipindeki methodda return olduğu için
                                        //değer burada geri gelir 
                                        //Eğer ortaya çıkan sonuç üzerinde başka işlemler yapacaksak return şart


            //int sayi = 100;
            //productManager.BiSeyYap(sayi);
            //Console.WriteLine(sayi);
            //// sayi = 100

            Console.ReadLine();
        }
    }
}
