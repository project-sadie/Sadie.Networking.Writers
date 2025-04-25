using Sadie.API.Networking;
using Sadie.Networking.Serialization.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users.Trading;

[PacketId(ServerPacketId.RoomUserTradeWaitingConfirm)]
public class RoomUserTradeWaitingConfirmWriter : AbstractPacketWriter;