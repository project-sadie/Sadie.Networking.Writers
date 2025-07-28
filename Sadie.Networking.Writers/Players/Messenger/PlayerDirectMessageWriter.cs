using Sadie.API;
using Sadie.API.Networking;
using Sadie.Db.Models.Players;
using Sadie.Shared.Attributes;
using Sadie.Shared.Extensions;

namespace Sadie.Networking.Writers.Players.Messenger;

[PacketId(ServerPacketId.PlayerMessage)]
public class PlayerDirectMessageWriter : AbstractPacketWriter
{
    public required PlayerMessage Message { get; init; }

    public override void OnSerialize(INetworkPacketWriter writer)
    {
        writer.WriteLong(Message.OriginPlayerId);
        writer.WriteString(Message.Message ?? "");
        writer.WriteLong(DateTime.Now.ToUnix() - Message.CreatedAt.ToUnixTimeSeconds());
    }
}