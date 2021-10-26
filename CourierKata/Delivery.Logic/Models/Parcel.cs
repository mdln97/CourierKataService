using Delivery.Logic.Enums;
using Delivery.Logic.Interfaces;
using System;

namespace Delivery.Logic.Models
{
    public class Parcel : IParcel
    {
        #region Obsolete
        [Obsolete("A weight parameter is required with the new version", true)]
        public Parcel(double length, double width, double height)
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

        #endregion

        #region Public

        public Parcel(double length, double width, double height, double weight)
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

            if (weight < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(weight));
            }

            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        /// <summary>
        /// height in cm
        /// </summary>
        public double Length { get; private set; }
        /// <summary>
        /// height in cm
        /// </summary>
        public double Width { get; private set; }
        /// <summary>
        /// height in cm
        /// </summary>
        public double Height { get; private set; }

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
        /// <summary>
        /// cost in dollars
        /// </summary>
        public double ParcelCost
        {
            get
            {
                double price = ParcelSize switch
                {
                    ParcelSizeType.Small => GetCost(Settings.SMALL_PARCEL_MAX_WEIGHT_NO_EXTRA_CHARGE, Settings.SMALL_PARCEL_COST, Settings.OVER_WEIGHT_PARCEL_EXTRA_CHAGE),

                    ParcelSizeType.Medium => GetCost(Settings.MEDIUM_PARCEL_MAX_WEIGHT_NO_EXTRA_CHARGE, Settings.MEDIUM_PARCEL_COST, Settings.OVER_WEIGHT_PARCEL_EXTRA_CHAGE),

                    ParcelSizeType.Large => GetCost(Settings.LARGE_PARCEL_MAX_WEIGHT_NO_EXTRA_CHARGE, Settings.LARGE_PARCEL_COST, Settings.OVER_WEIGHT_PARCEL_EXTRA_CHAGE),

                    ParcelSizeType.XL => GetCost(Settings.XL_PARCEL_MAX_WEIGHT_NO_EXTRA_CHARGE, Settings.XL_PARCEL_COST, Settings.OVER_WEIGHT_PARCEL_EXTRA_CHAGE),

                    _ => throw new ArgumentOutOfRangeException(nameof(ParcelSize))
                };
                return price;
            }
        }

        public double Weight { get; private set; }


        #endregion 

        #region Private

       

        private double GetCost(int maxVal, int regularPrice, int pricePerKgIncrease)
        {
            return Weight > maxVal ? regularPrice + pricePerKgIncrease * (int)(Math.Ceiling(Weight) - maxVal) : regularPrice;
        }


        private Parcel()
        {

        }
        #endregion
    }
}
