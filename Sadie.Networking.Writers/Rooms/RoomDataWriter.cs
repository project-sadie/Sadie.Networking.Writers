﻿using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms;

[PacketId(ServerPacketId.RoomData)]
public class RoomDataWriter : AbstractPacketWriter
{
    public required string LayoutName { get; init; }
    public required int RoomId { get; init; }
}