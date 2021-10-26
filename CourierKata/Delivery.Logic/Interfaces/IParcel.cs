using Delivery.Logic.Enums;

namespace Delivery.Logic.Interfaces
{
    public interface IParcel
    {
        int Length { get; }

        int Width { get; }

        int Height { get; }

        int Weight { get; }

        ParcelSizeType ParcelSize { get; }

        int ParcelCost { get; }
    }
}
