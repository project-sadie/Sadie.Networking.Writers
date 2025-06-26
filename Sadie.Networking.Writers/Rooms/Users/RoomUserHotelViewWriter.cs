using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users;

[PacketId(ServerPacketId.RoomUserHotelView)]
public class RoomUserHotelViewWriter : AbstractPacketWriter;