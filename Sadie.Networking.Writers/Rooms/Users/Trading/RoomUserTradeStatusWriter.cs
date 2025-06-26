using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users.Trading;

[PacketId(ServerPacketId.RoomUserTradeStatus)]
public class RoomUserTradeStatusWriter : AbstractPacketWriter
{
    public required long UserId { get; set; }
    public required int Status { get; set; }
}