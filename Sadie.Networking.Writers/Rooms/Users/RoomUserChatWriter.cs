using Sadie.Networking.Serialization.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users;

[PacketId(ServerPacketId.RoomUserChat)]
public class RoomUserChatWriter : RoomUserWhisperWriter;