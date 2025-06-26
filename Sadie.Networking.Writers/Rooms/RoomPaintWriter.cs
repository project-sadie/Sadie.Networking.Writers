using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms;

[PacketId(ServerPacketId.RoomPaint)]
public class RoomPaintWriter : AbstractPacketWriter
{
    public required string Type { get; init; }
    public required string Value { get; init; }
}