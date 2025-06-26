using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms;

[PacketId(ServerPacketId.RoomSettingsSaved)]
public class RoomSettingsSavedWriter : AbstractPacketWriter
{
    public required long RoomId { get; init; }
}