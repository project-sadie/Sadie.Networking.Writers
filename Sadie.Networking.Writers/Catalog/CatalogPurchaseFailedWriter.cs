using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Catalog;

[PacketId(ServerPacketId.CatalogPurchaseFailed)]
public class CatalogPurchaseFailedWriter : AbstractPacketWriter
{
    public required int Error { get; init; }
}