using ASPNET;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<TreasureDbContext>(options => options.UseSqlServer(connectionString));
var app = builder.Build();



app.MapGet("/", () => "Hello World!");

app.MapGet("/about", (TreasureDbContext db) =>
{
    return db.About.Where(a => a.Id == 1).First();
});

app.MapGet("/rules", (TreasureDbContext db) =>
{
    return db.Rules.ToList();
});

app.MapGet("/treasure", (TreasureDbContext db) =>
{
    return db.Treasures.ToList();
});

app.MapGet("/shops", (TreasureDbContext db) =>
{
    return db.Shops.ToList();
});


app.MapGet("/rules/{id}", (int id, TreasureDbContext db) =>
{
    Rule? rule = db.Rules.Where(r => r.Id == id)?.FirstOrDefault();
    if (rule != null) return Results.Ok(rule);
    return Results.NotFound();
});

app.MapGet("/treasure/{id}", (int id, TreasureDbContext db) =>
{
    Treasure? treasure = db.Treasures.Where(t => t.Id == id).FirstOrDefault();
    if(treasure != null) return Results.Ok(treasure);
    return Results.NotFound();
});

app.MapGet("/shops/{id}", (int id, TreasureDbContext db) =>
{

    Shop? shop = db.Shops.Where(s => s.Id == id).FirstOrDefault();
    if(shop != null) return Results.Ok(shop);
    return Results.NotFound();
});

app.MapPost("/shops", (Shop newShop, TreasureDbContext db) =>
{
    db.Shops.Add(newShop);
    db.SaveChanges();
    return Results.Ok(newShop);
});


app.MapPost("/rules", (Rule newRule, TreasureDbContext db) =>
{
    db.Rules.Add(newRule);
    db.SaveChanges();
    return Results.Ok(newRule);
});

app.MapDelete("/rules/{id}", (int id, TreasureDbContext db) =>
{
    Rule? ruleToDelete = db.Rules.Where(s => s.Id == id).FirstOrDefault();
    if(ruleToDelete == null) return Results.NotFound();
    db.Rules.Remove(ruleToDelete);
    db.SaveChanges();
    return Results.NoContent();
});

app.MapPatch("/rules/{id}", (int id, Rule newRule, TreasureDbContext db) =>
{
    Rule? ruleToPatch = db.Rules.Where(r => r.Id == id).FirstOrDefault();
    if(ruleToPatch == null) return Results.NotFound();
    ruleToPatch.Description = newRule.Description ?? ruleToPatch.Description;
    ruleToPatch.RuleText = newRule.RuleText ?? ruleToPatch.RuleText;
    db.SaveChanges();
    return Results.Ok(ruleToPatch);   
});

app.Run();

