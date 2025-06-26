using Sadie.API;
using Sadie.API.Game.Rooms.Users;
using Sadie.API.Networking;
using Sadie.Enums.Game.Furniture;
using Sadie.Shared.Attributes;
using Sadie.Shared.Helpers;

namespace Sadie.Networking.Writers.Rooms.Users.Trading;

[PacketId(ServerPacketId.RoomUserTradeUpdate)]
public class RoomUserTradeUpdateWriter : AbstractPacketWriter
{
    public required IRoomUserTrade Trade { get; init; }

    public override void OnSerialize(INetworkPacketWriter writer)
    {
        foreach (var user in Trade.Users)
        {
            writer.WriteLong(user.Player.Id);

            var usersOfferedItems = Trade
                .Items
                .Where(x => x.PlayerId == user.Player.Id)
                .ToList();
            
            writer.WriteInteger(usersOfferedItems.Count);
            
            foreach (var item in usersOfferedItems)
            {
                writer.WriteInteger(item.Id);
                writer.WriteString(EnumHelpers.GetEnumDescription(item.FurnitureItem!.Type)!);
                writer.WriteInteger(item.Id);
                writer.WriteInteger(item.FurnitureItem.AssetId);
                writer.WriteInteger(0);
                writer.WriteBool(item.FurnitureItem.CanInventoryStack);
                writer.WriteInteger(0);
                writer.WriteString(item.MetaData);
                writer.WriteInteger(0);
                writer.WriteInteger(0);
                writer.WriteInteger(0);

                if (item.FurnitureItem.Type == FurnitureItemType.Floor)
                {
                    writer.WriteInteger(0);
                }
            }
            
            writer.WriteInteger(usersOfferedItems.Count);
            writer.WriteInteger(0);
        }
    }
}