using Delivery.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Logic.Models
{
    public class OrderSummary
    {

        public OrderSummary(IEnumerable<IParcel> parcels, double speedyDelivery, double regularDelivery)
        {
            Parcels = parcels;
            SpeedyDelivery = speedyDelivery;
            RegularDelivery = regularDelivery;
        }

        public IEnumerable<IParcel> Parcels { get; private set;}

        public double SpeedyDelivery { get; private set; }

        public double RegularDelivery { get; private set; }
    }
}
