using Sadie.API;
using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users;

[PacketId(ServerPacketId.RoomUserEffect)]
public class RoomUserEffectWriter : AbstractPacketWriter
{
    public required int UserId { get; init; }
    public required int EffectId { get; init; }
    public required int DelayMs { get; init; }

    public override void OnSerialize(INetworkPacketWriter writer)
    {
        writer.WriteInteger(UserId);
        writer.WriteInteger(EffectId);
        writer.WriteInteger(DelayMs);
    }
}