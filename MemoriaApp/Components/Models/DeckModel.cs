using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoriaApp.Components.Models;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Replace 'Deck' with your actual data model class
    public DbSet<DeckModel> Decks { get; set; } 
}

[Table("deck")]
public class DeckModel
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
}

public class CardModel
{
    public int id { get; set; }
    public string front_text { get; set; }
}

/*
public class DeckModel
{
    public string DeckName { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime DateCreated { get; set; }
    public string DeckLabel { get; set; }
    public int DeckID { get; set; }
}
*/

/*
public class CardModel
{
    public int Id { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime Created { get; set; }
    public string Tag { get; set; }
    public string FrontText { get; set; }
    public string BackText { get; set; }
    public int CardID { get; set; }
    
}
*/
