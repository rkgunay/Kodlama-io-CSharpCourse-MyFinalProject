using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //publicler büyük harfli yazılır. private'ler ilk harf küçük.
        //Buraya ekledik çünkü sadece Business katmanında kullanılıyor. Tüm projede kullanılacak
        //olsaydı Core katmanına yazardık. 
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım saati";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductCountofCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlredyExists = "Bu isimde bir ürün zaten var";
        internal static string CategoryNumberExceededError = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
