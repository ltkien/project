using BloodFlow.Data;
using BloodFlow.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BloodFlow.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AdminController: ControllerBase
{
    private readonly ApplicationDbContext _db;
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    public AdminController(ApplicationDbContext db,RoleManager<IdentityRole> roleManager,UserManager<User> userManager)
    {
        _db = db;
        _roleManager = roleManager;
        _userManager = userManager;
    }
    [HttpGet]
    public async Task<IActionResult> ManageUser()
    {
            
        var user = await _userManager.GetUsersInRoleAsync("User");
        return Ok(user);
    }

}
