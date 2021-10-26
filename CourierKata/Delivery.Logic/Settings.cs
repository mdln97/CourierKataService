using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Logic
{
    public static class Settings
    {
        public const int SMALL_PARCEL_MAX_WEIGHT_NO_EXTRA_CHARGE = 1; // kg
        public const int MEDIUM_PARCEL_MAX_WEIGHT_NO_EXTRA_CHARGE = 3; // kg
        public const int LARGE_PARCEL_MAX_WEIGHT_NO_EXTRA_CHARGE = 6; // kg
        public const int XL_PARCEL_MAX_WEIGHT_NO_EXTRA_CHARGE = 10; // kg
        public const int HEAVY_PARCEL_WEIGHT_LIMIT = 50; // kg

        public const int OVER_WEIGHT_PARCEL_EXTRA_CHAGE_PER_KG = 2; // dollars
        public const int OVER_WEIGHT_HEAVY_PARCEL_EXTRA_CHAGE_PER_KG = 1; // dollars


        public const int SMALL_PARCEL_COST = 3; // Dollars
        public const int MEDIUM_PARCEL_COST = 8; // Dollars
        public const int LARGE_PARCEL_COST = 15; // Dollars
        public const int XL_PARCEL_COST = 25; // Dollars
        public const int HEAVY_PARCEL_COST = 50; // Dollars

    }
}
