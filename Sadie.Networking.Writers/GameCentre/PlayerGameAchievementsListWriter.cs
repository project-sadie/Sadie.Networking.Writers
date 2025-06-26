using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.GameCentre;

[PacketId(ServerPacketId.GameCentreConfig)]
public class PlayerGameAchievementsListWriter : AbstractPacketWriter;