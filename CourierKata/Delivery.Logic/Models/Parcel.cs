using Delivery.Logic.Enums;
using Delivery.Logic.Interfaces;
using System;

namespace Delivery.Logic.Models
{
    public class Parcel : IParcel
    {
        public int Length => throw new NotImplementedException();

        public int Width => throw new NotImplementedException();

        public int Height => throw new NotImplementedException();

        public ParcelSizeType ParcelSize => throw new NotImplementedException();

        public int ParcelCost => throw new NotImplementedException();
    }
}
