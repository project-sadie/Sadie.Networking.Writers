using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Players.Rooms;

[PacketId(ServerPacketId.PlayerHomeRoom)]
public class PlayerHomeRoomWriter : AbstractPacketWriter
{
    public required int HomeRoom { get; init; }
    public required int RoomIdToEnter { get; init; }
}