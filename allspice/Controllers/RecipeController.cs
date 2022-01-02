using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using allspice.Models;
using allspice.Services;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace allspice.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class RecipeController : ControllerBase
  {
    private readonly RecipeService _rs;
    private readonly AccountService _acctService;

    public RecipeController(RecipeService rs, AccountService acctService)
    {
      _rs = rs;
      _acctService = acctService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Recipe>> Get()
    {
      try
      {
        var recipes = _rs.Get();
        return Ok(recipes);
      }
      catch (Exception e)
      {
      return BadRequest(e.Message);
      }
    }
    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Recipe>> Create([FromBody] Recipe newRecipe)
    {
      try
      {
           Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
           newRecipe.creatorId = userInfo?.Id;
           Recipe recipe = _rs.Create(newRecipe);
           return Ok(recipe);
      }
      catch (Exception e)
      {
          return BadRequest(e.Message);
      }
    }
  }
}