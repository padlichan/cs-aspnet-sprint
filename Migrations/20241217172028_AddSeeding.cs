using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASPNET.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treasures_Shops_ShopId",
                table: "Treasures");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Treasures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "Description", "Mission", "Name", "OriginStory" },
                values: new object[] { 1, "Pippa's Rare Treasures is an exquisite collection of rare and legendary artifacts, gathered from the most distant and mysterious corners of the world. From enchanted jewels to ancient relics, each piece holds its own story, representing the pinnacle of craftsmanship and history.", "Our mission is to preserve and showcase the most extraordinary and valuable treasures ever discovered, allowing adventurers, collectors, and historians to experience the magic and wonder of forgotten realms.", "Pippa's Rare Treasures", "Pippa Pom, an adventurous soul with a thirst for discovery, started her collection after uncovering a rare artifact during an expedition to the Lost Kingdom. Since then, her passion for hunting down hidden treasures has turned into a renowned collection admired by many." });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Description", "FoundedYear", "Location", "Name", "OpeningHours", "Owner", "Reputation", "Type" },
                values: new object[,]
                {
                    { 1, "A well-known general store offering a variety of goods, from food to adventuring gear.", 50, "Main Street, Capital City", "The Golden Coin", "8 AM - 8 PM", "Marcus Goldfinger", "Trusted", "General Store" },
                    { 2, "A mystical shop filled with rare and powerful magical items.", 112, "Wizard's District, Silverport", "Arcturus's Arcane Emporium", "10 AM - 6 PM", "Arcturus the Wise", "Respected", "Magic Shop" },
                    { 3, "A renowned blacksmith offering expertly crafted weapons and armor.", 85, "Forge Alley, Stonehold", "The Silver Dagger", "7 AM - 5 PM", "Hrogar Ironforge", "Renowned", "Blacksmith" },
                    { 4, "A tailor shop known for its enchanted and elegant garments.", 95, "Market Square, Elvenholm", "The Enchanted Needle", "9 AM - 6 PM", "Elyndra Moonweaver", "Esteemed", "Tailor Shop" },
                    { 5, "A popular tavern for sailors, known for its strong drinks and lively atmosphere.", 70, "Dockside, Seabreeze", "The Crimson Chalice", "12 PM - 2 AM", "Captain Redbeard", "Infamous", "Tavern" },
                    { 6, "A well-known general store offering a variety of goods, from food to adventuring gear.", 6, "Skyrim", "Riverwood Trader", "8 AM - 8 PM", "Lucan Valerias", "Trusted", "General Store" },
                    { 7, "A well-known general store offering a variety of goods, from food to adventuring gear.", 6, "Skyrim", "nuts and seeds", "8 AM - 8 PM", "Lucan Valerias", "Trusted", "food shop" }
                });

            migrationBuilder.InsertData(
                table: "Treasures",
                columns: new[] { "Id", "Description", "Material", "Name", "Origin", "Rarity", "ShopId", "Type", "Value", "Weight" },
                values: new object[,]
                {
                    { 1, "A magnificent crown made of pure gold, adorned with rare gems.", "Gold", "Golden Crown", "Ancient Kingdom", "Legendary", null, "Jewelry", 50000, "2 kg" },
                    { 2, "An ancient, leather-bound tome containing forgotten knowledge and the cryptic writings of Neil, an eccentric scholar. It is said that reading too much of the book at once can drive a person to madness, but those who master its secrets are rewarded with incredible insight.", "Leather-bound with silver inlay", "Neil's Book", "Library of Shadows", "Mythical", null, "Book", 75000, "1.5 kg" },
                    { 3, "These legendary football boots, once worn by Alice the Undefeated, are made from rare dragonhide leather. They are said to grant the wearer unmatched speed, agility, and the ability to bend the ball in impossible ways. Legends claim that those who wear them can never lose a match—but only if they believe in the magic.", "Dragonhide Leather", "Alice's Football Boots", "Tournament of Champions", "Legendary", null, "Footwear", 120000, "0.8 kg" },
                    { 4, "A delicate silver necklace with a large sapphire centerpiece.", "Silver", "Sapphire Necklace", "Royal Family", "Rare", null, "Jewelry", 15000, "0.5 kg" },
                    { 5, "An ancient scroll containing powerful spells written in an extinct language.", "Papyrus", "Ancient Scroll", "Forgotten Empire", "Epic", null, "Artifact", 8000, "0.2 kg" },
                    { 6, "A deadly dagger carved from the fang of a dragon, rumored to be unbreakable.", "Dragon Fang", "Dragon's Fang Dagger", "Dragon Slayers Guild", "Legendary", null, "Weapon", 30000, "0.3 kg" },
                    { 7, "A small leather bag filled with coins from ancient civilizations.", "Gold and Silver", "Bag of Rare Coins", "Lost Merchant Ship", "Uncommon", null, "Currency", 10000, "1 kg" },
                    { 8, "A ceremonial chalice studded with rubies, used in ancient rituals.", "Gold", "Ruby-Studded Chalice", "Temple of the Sun", "Epic", null, "Relic", 25000, "1.5 kg" },
                    { 9, "An amulet with mystical powers, said to protect the wearer from harm.", "Bronze", "Enchanted Amulet", "Mystic Forest", "Epic", null, "Jewelry", 12000, "0.3 kg" },
                    { 10, "A large chest filled with gold, gems, and rare artifacts, rumored to be cursed.", "Wood and Iron", "Pirate's Treasure Chest", "Sunken Pirate Ship", "Legendary", null, "Container", 40000, "30 kg" },
                    { 11, "A beautifully crafted silver chalice said to hold lunar powers.", "Silver", "Silver Chalice of the Moon", "Temple of the Moon", "Rare", null, "Relic", 18000, "1 kg" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Treasures_Shops_ShopId",
                table: "Treasures",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treasures_Shops_ShopId",
                table: "Treasures");

            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Treasures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Treasures",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Treasures_Shops_ShopId",
                table: "Treasures",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
