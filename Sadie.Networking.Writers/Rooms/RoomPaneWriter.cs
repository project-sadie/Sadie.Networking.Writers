using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms;

[PacketId(ServerPacketId.RoomPane)]
public class RoomPaneWriter : AbstractPacketWriter
{
    public required int RoomId { get; init; }
    public required bool Owner { get; init; }
}