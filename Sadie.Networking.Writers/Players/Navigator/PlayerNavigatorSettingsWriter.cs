using Sadie.API.Networking;
using Sadie.Db.Models.Players;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Players.Navigator;

[PacketId(ServerPacketId.NavigatorSettings)]
public class PlayerNavigatorSettingsWriter : AbstractPacketWriter
{
    public required PlayerNavigatorSettings NavigatorSettings { get; init; }
}