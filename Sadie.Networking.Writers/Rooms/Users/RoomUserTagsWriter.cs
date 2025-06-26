﻿using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users;

[PacketId(ServerPacketId.RoomUserTags)]
public class RoomUserTagsWriter : AbstractPacketWriter
{
    public required long UserId { get; init; }
    public required List<string> Tags { get; init; }
}