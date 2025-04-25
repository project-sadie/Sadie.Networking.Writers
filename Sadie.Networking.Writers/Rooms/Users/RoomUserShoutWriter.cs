using Sadie.Networking.Serialization.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users;

[PacketId(ServerPacketId.RoomUserShout)]
public class RoomUserShoutWriter : RoomUserChatWriter;