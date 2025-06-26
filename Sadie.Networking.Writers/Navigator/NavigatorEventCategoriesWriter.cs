using Sadie.API.Networking;
using Sadie.Db.Models.Rooms;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Navigator;

[PacketId(ServerPacketId.NavigatorEventCategories)]
public class NavigatorEventCategoriesWriter : AbstractPacketWriter
{
    public required List<RoomCategory> Categories { get; init; }
}