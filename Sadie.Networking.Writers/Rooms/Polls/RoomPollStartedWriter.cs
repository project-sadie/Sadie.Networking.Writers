using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Polls;

[PacketId(ServerPacketId.RoomPollStarted)]
public class RoomPollStartedWriter : AbstractPacketWriter
{
    public required string Question { get; init; }
    public required List<string> Choices { get; init; }
}