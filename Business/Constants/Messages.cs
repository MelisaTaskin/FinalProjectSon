using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static  class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz ";
        public static string MaintenanceTime = "sistem bakımda";
        public static string ProductListed = "ürünler listelendi";
        public static string UnitPriceInvalid;
        public static string ProductCountOfCategoryError;
        public static string ProductNameAlreadyExist;
        public static string CategoryLimitExceded = "Kategori Limiti aşıldığı için kategori eklenemiyor.";
        public static string  AuthorizationDenied = "yetkiniz yok ";
        public static string UserRegistered;

        public static string SuccessfulLogin = "";
        public static string AccessTokenCreated = "";

        internal static string UserAlreadyExists = "";
    }
}
