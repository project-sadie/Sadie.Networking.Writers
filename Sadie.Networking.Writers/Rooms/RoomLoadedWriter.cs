using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms;

[PacketId(ServerPacketId.RoomLoaded)]
public class RoomLoadedWriter : AbstractPacketWriter;