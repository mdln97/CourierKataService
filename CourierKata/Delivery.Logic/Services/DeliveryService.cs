using Delivery.Logic.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Logic.Services
{
    public class DeliveryService : IDeliveryService
    {
        public int CalculateParcelDeliveryCosts(IEnumerable<IParcel> parcels)
        {
            return parcels.Sum(x => x.ParcelCost);
        }
    }
}
