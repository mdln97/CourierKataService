using Delivery.Logic.Interfaces;
using Delivery.Logic.Models;

namespace Delivery.Logic.NUnitTest.Helpers
{
    public static class ParcelHelper
    {
        public static IParcel GetSmallParcel()
        {
            return new Parcel(5, 6, 7, 1);
        }

        public static IParcel GetLargeParcel()
        {
            return new Parcel(5, 55, 7, 2);
        }

        public static IParcel GetMediumParcel()
        {
            return new Parcel(5, 32, 7, 3);
        }

        public static IParcel GetXLParcel()
        {
            return new Parcel(122, 6, 4, 4);
        }

    }
}
