using Sadie.API.Networking;
using Sadie.Db.Models.Players;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Players.Navigator;

[PacketId(ServerPacketId.NavigatorSavedSearches)]
public class PlayerSavedSearchesWriter : AbstractPacketWriter
{
    public required ICollection<PlayerSavedSearch> Searches { get; init; }
}