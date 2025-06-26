using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Rooms.Users.Trading;

[PacketId(ServerPacketId.RoomUserTradeWaitingConfirm)]
public class RoomUserTradeWaitingConfirmWriter : AbstractPacketWriter;