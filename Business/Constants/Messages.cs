using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages 
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintananceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi.";
        public static string productCountOfCategoryError = "Bir kategoride en fazla 10 ürn olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkilendirme başarısız."; 
        public static string UserRegistered = "Kullanıcı kaydı başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı.";
        public static string AccessTokenCreated = "Şifre oluşturuldu.";


    }
}
