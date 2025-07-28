using Sadie.API;
using Sadie.API.Networking;
using Sadie.Db.Models.Players;
using Sadie.Enums.Game.Players;
using Sadie.Shared.Attributes;

namespace Sadie.Networking.Writers.Players.Inventory;

[PacketId(ServerPacketId.PlayerInventoryBotItems)]
public class PlayerInventoryBotItemsWriter : AbstractPacketWriter
{
    public required ICollection<PlayerBot> Bots { get; init; }

    public override void OnSerialize(INetworkPacketWriter writer)
    {
        writer.WriteInteger(Bots.Count);

        foreach (var bot in Bots)
        {
            writer.WriteInteger(bot.Id);
            writer.WriteString(bot.Username);
            writer.WriteString(bot.Motto);
            writer.WriteString(bot.Gender == PlayerAvatarGender.Male ? "m" : "f");
            writer.WriteString(bot.FigureCode);
        }
    }
}