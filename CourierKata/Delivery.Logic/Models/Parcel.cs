using Delivery.Logic.Enums;
using Delivery.Logic.Interfaces;
using System;

namespace Delivery.Logic.Models
{
    public class Parcel : IParcel
    {

        public Parcel(int length, int width, int height)
        {
            if (length < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }
            if (width < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(width));
            }

            if (height < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(height));
            }

            Length = length;
            Width = width;
            Height = height;
        }

        public int Length { get; private set; }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public ParcelSizeType ParcelSize
        {
            get
            {
                if (Length >= 100 || Width >= 100 || Height >= 100)
                    return ParcelSizeType.XL;

                if (Length < 10 && Width < 10 && Height < 10)
                    return ParcelSizeType.Small;

                if (Length < 50 && Width < 50 && Height < 50)
                    return ParcelSizeType.Medium;

                return ParcelSizeType.Large;
            }
        }

        public int ParcelCost
        {
            get
            {
                int price = ParcelSize switch
                {
                    ParcelSizeType.Small => 3,
                    ParcelSizeType.Medium => 8,
                    ParcelSizeType.Large => 15,
                    ParcelSizeType.XL => 25,
                    _ => throw new ArgumentOutOfRangeException(nameof(ParcelSize))
                };
                return price;
            }
        }

        private Parcel()
        {

        }
    }
}
