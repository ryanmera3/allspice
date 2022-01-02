using System.Collections.Generic;
using System.Data;
using System.Linq;
using allspice.Models;
using Dapper;

namespace allspice.Repositories
{
  public class RecipesRepository
  {
    private readonly IDbConnection _db;
    public RecipesRepository(IDbConnection db)
    {
      _db = db;
    }
    internal List<Recipe> Get()
    {
      string sql = "SELECT * FROM recipes;";
      return _db.Query<Recipe>(sql).ToList();
    }
    internal Recipe Create(Recipe newRecipe)
    {
      string sql = @"
      INSERT INTO recipes
      (title, subtitle, category, creatorId)
      VALUES
      (@Title, @Subtitle, @Category, @CreatorId);
      SELECT LAST_INSERT_ID()
      ;";
      int id = _db.ExecuteScalar<int>(sql, newRecipe);
      newRecipe.Id = id;
      return newRecipe;
    }
  }
}