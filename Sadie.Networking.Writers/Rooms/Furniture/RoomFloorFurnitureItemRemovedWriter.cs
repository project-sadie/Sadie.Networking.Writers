using Sadie.API.Networking;
using Sadie.Networking.Serialization.Attributes;

namespace Sadie.Networking.Writers.Rooms.Furniture;

[PacketId(ServerPacketId.RoomFurnitureItemRemoved)]
public class RoomFloorFurnitureItemRemovedWriter : AbstractPacketWriter
{
    public required string Id { get; init; }
    public required bool Expired { get; init; }
    public required long OwnerId { get; init; }
    public required int Delay { get; init; }
}