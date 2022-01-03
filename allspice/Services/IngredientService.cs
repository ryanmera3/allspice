using System.Collections.Generic;
using allspice.Models;
using allspice.Repositories;

namespace allspice.Services
{
  public class IngredientService
  {
    private readonly IngredientsRepository _repo;
    public IngredientService(IngredientsRepository repo)
    {
      _repo = repo;
    }
    internal List<Ingredient> Get()
    {
      return _repo.Get();
    }
    internal Ingredient Create(Ingredient newIngredient)
    {
      _repo.Create(newIngredient);
      return newIngredient;
    }
  }
}