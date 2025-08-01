using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Catalog;

[PacketId(ServerPacketId.CatalogMode)]
public class CatalogModeWriter : AbstractPacketWriter
{
    public required int Mode { get; init; }
}