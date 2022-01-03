using System.Collections.Generic;
using System.Data;
using System.Linq;
using allspice.Models;
using Dapper;

namespace allspice.Repositories
{
  public class IngredientsRepository
  {
    private readonly IDbConnection _db;
    public IngredientsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal List<Ingredient> Get()
    {
      string sql = "SELECT * FROM ingredients;";
      return _db.Query<Ingredient>(sql).ToList();
    }
    internal Ingredient Create(Ingredient newIngredient)
    {

    string sql = @"
    INSERT INTO  ingredients
    (name, quantity, recipeId)
    VALUES
    (@Name, @Quantity, @RecipeId);";
    _db.ExecuteScalar<int>(sql, newIngredient);
    return newIngredient;
    }
  }
}