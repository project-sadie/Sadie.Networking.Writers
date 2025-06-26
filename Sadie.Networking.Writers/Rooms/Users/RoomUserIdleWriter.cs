﻿using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users;

[PacketId(ServerPacketId.RoomUserIdle)]
public class RoomUserIdleWriter : AbstractPacketWriter
{
    public required long UserId { get; set; }
    public required bool IsIdle { get; set; }
}