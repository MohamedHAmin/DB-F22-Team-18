using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainPage_Demo.Forms
{
    public class StoredProcedures
    {
        public static string SelectNumberofInventoryItems = "selectProductsCount";
        public static string SelectInventoryItems = "selectInventoryItems";
        public static string ChangeInventoryCapacity = "updateInventoryCapacity";
        public static string InsertDevice = "inserDevice";
        public static string DeleteDevice = "deleteDevice";
        public static string SelectDevicesInfo = "selectDevicesInfo";
        public static string DeleteService = "deleteService";
        public static string UpdateDuration = "updateDuration";
        public static string UpdatePrice = "updatePrice";
        public static string UpdateDiscount = "updateDiscount";
        public static string InsertService = "inserSevice";
        public static string CountWorkers = "countWorkers";
    }
}
