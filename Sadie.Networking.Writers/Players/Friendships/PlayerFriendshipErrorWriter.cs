using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Players.Friendships;

[PacketId(ServerPacketId.PlayerFriendshipError)]
public class PlayerFriendshipErrorWriter : AbstractPacketWriter
{
    public required int ClientMessageId { get; init; }
    public required int Error { get; init; }
}