using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users.HandItems;

[PacketId(ServerPacketId.RoomUserHandItem)]
public class RoomUserHandItemWriter : AbstractPacketWriter
{
    public required long UserId { get; init; }
    public required int ItemId { get; init; }
}