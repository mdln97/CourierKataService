using System.Collections.Generic;

namespace Delivery.Logic.Interfaces
{
    public interface IDeliveryService
    {
        int CalculateDeliveryCosts(IEnumerable<IParcel> parcels);

        int CalculateSpeedyDeliveryCosts(IEnumerable<IParcel> parcels);
    }
}
