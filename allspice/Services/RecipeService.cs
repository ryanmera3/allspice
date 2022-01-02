using System.Collections.Generic;
using allspice.Models;
using allspice.Repositories;

namespace allspice.Services
{
  public class RecipeService
{
  private readonly RecipesRepository _repo;
  public RecipeService(RecipesRepository repo)
  {
    _repo = repo;
  }
  internal List<Recipe> Get()
  {
    return _repo.Get();
  }
  internal Recipe Create(Recipe newRecipe)
  {
    return _repo.Create(newRecipe);
  }
}
}