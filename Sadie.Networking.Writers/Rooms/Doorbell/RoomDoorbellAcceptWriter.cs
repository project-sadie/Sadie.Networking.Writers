using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Doorbell;

[PacketId(ServerPacketId.RoomDoorbellAccept)]
public class RoomDoorbellAcceptWriter : AbstractPacketWriter
{
    public required string Username { get; init; }
}