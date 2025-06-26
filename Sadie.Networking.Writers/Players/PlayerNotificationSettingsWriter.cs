using Sadie.API.Networking;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Players;

[PacketId(ServerPacketId.NotificationSettings)]
public class PlayerNotificationSettingsWriter : AbstractPacketWriter
{
    public required bool ShowNotifications { get; init; }
}