using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Catalog;

[PacketId(ServerPacketId.CatalogRecyclerLogic)]
public class CatalogRecyclerLogicWriter : AbstractPacketWriter
{
    public required int PrizeSize { get; init; }
}