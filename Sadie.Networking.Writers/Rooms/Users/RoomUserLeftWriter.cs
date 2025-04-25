using Sadie.API.Networking;
using Sadie.Networking.Serialization.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users;

[PacketId(ServerPacketId.RoomUserLeft)]
public class RoomUserLeftWriter : AbstractPacketWriter
{
    public required string UserId { get; init; }
}