using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASPNET.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rules",
                columns: new[] { "Id", "Description", "RuleText" },
                values: new object[,]
                {
                    { 1, "Under no circumstances shall any treasure be touched without the enchanted silk gloves provided at the entrance. Failure to comply will result in an immediate transformation into a harmless yet embarrassing woodland creature (e.g., a squirrel).", "No Touching Without Gloves" },
                    { 2, "If you encounter Evie Pom or Millie Pom, you must immediately say 'bork' in greeting. Failure to do so will result in an overly dramatic escort off the premises, as it is considered the highest form of disrespect to pass a Pomeranian without a proper 'bork.'", "Always Greet the Pomeranians" },
                    { 3, "Any visitor must compliment at least one treasure aloud upon entering the exhibit. Criticizing any piece will invoke a loud, disapproving echo that follows the offender for the duration of their visit.", "Treasure Compliments Only" },
                    { 4, "If you spot Poppy, you must immediately perform a joyful dance in her honor. Failure to do so will result in Poppy giving you the most disappointed look imaginable, followed by an inexplicable urge to break out in spontaneous dance for the rest of the day.", "Dance for Poppy" },
                    { 5, "Test", "Test RUle" },
                    { 6, "Talking excessively about the latest internet trends, memes, or social media drama will result in an immediate case of 'brain rot.' Symptoms include saying 'lol' out loud, quoting obscure memes non-stop, and the inability to think about anything other than the latest viral video for 24 hours.", "Limit Your Internet Chatter" },
                    { 7, "To engage with any item in the Ancient Scroll section, one must speak only in riddles. Failure to do so will result in the scrolls shuffling themselves into confusing and endless new patterns.", "Speak in Riddles at the Ancient Scroll Display" },
                    { 8, "Whistling in the presence of the Jewels of Royalty will cause the gemstones to vibrate, resulting in a short-lived but dazzling light show. However, it may also summon a royal ghost seeking an audience.", "No Whistling in the Hall of Jewels" },
                    { 9, "If boardgames are mentioned, the shopkeeper (and everyone nearby) will start an unstoppable conversation about boardgames, reciting every obscure rule, strategy, and historical fact. The conversation will continue for hours, making it impossible to leave until you've learned at least three new games.", "No Mentioning Boardgames" },
                    { 10, "Visitors who approach the Pirate's Treasure Chest must knock on it twice before leaving. Forgetting this small ritual may trigger an ancient pirate's curse, resulting in an uncontrollable urge to speak in pirate slang for the rest of the day.", "Pirate's Treasure Chest Must Be Knocked On Twice" },
                    { 11, "To view the Ruby-Studded Chalice of the Sun up close, visitors must place a gold coin in the offering dish. If no offering is made, the chalice will glow dimly and quietly hum a melancholic tune.", "Offer One Gold Coin at the Chalice of the Sun" },
                    { 12, "Upon approaching the Silver Chalice of the Moon, visitors are required to perform a brief dance (no longer than 10 seconds) under the moonlight lamp. Failure to comply may result in a night of strange dreams involving talking animals.", "Dance in the Moonlight" },
                    { 13, "Photography is only permitted if the treasure appears to smile at the photographer. Capturing a treasure's displeasure on camera could result in your images mysteriously vanishing from your device.", "No Photography Unless the Treasure Smiles" },
                    { 14, "Pippa's Rare Treasures is in no way associated with Poppy's Rare Treasures! Any implication otherwise will result in a stern lecture from Pippa about the importance of brand identity.", "No Association with Poppy's Rare Treasures" },
                    { 15, "Or you will be fired.", "Try your very best" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
