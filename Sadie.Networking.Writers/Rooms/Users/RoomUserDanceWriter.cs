﻿using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users;

[PacketId(ServerPacketId.RoomUserDance)]
public class RoomUserDanceWriter : AbstractPacketWriter
{
    public required long UserId { get; init; }
    public required int DanceId { get; init; }
}