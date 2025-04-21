using Sadie.API.Networking;
using Sadie.Networking.Serialization.Attributes;

namespace Sadie.Networking.Writers.Rooms;

[PacketId(ServerPacketId.RoomChatSettings)]
public class RoomChatSettingsWriter : AbstractPacketWriter
{
    public required int ChatType { get; init; }
    public required int ChatWeight { get; init; }
    public required int ChatSpeed { get; init; }
    public required int ChatDistance { get; init; }
    public required int ChatProtection { get; init; }
}