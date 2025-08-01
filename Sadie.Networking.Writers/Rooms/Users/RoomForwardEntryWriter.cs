using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users;

[PacketId(ServerPacketId.RoomForwardEntry)]
public class RoomForwardEntryWriter : AbstractPacketWriter
{
    public required long RoomId { get; init; }
}