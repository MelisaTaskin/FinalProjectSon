﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static  class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz ";
        internal static string MaintenanceTime = "sistem bakımda";
        internal static string ProductListed = "ürünler listelendi";
        internal static string UnitPriceInvalid;
        internal static string ProductCountOfCategoryError;
        internal static string ProductNameAlreadyExist;
        internal static string CategoryLimitExceded = "Kategori Limiti aşıldığı için kategori eklenemiyor.";
    }
}
