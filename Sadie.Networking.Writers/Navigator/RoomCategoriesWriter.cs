using Sadie.API.Networking;
using Sadie.Db.Models.Rooms;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Navigator;

[PacketId(ServerPacketId.RoomCategories)]
public class RoomCategoriesWriter : AbstractPacketWriter
{
    public required List<RoomCategory> Categories { get; init; }
}