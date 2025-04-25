﻿using Sadie.API.Networking;
using Sadie.Networking.Serialization.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users;

[PacketId(ServerPacketId.RoomUserAction)]
public class RoomUserActionWriter : AbstractPacketWriter
{
    public required long UserId { get; set; }
    public required int Action { get; set; }
}