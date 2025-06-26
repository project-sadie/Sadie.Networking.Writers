using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms;

[PacketId(ServerPacketId.RoomSettingsUpdated)]
public class RoomSettingsUpdatedWriter : AbstractPacketWriter
{
    public required long RoomId { get; init; }
}