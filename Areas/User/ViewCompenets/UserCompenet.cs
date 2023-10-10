using celilcavus.Controllers;
using celilcavus.models;
using Microsoft.AspNetCore.Mvc;

namespace celilcavus.ViewCompenets;

public class UserCompenet : ViewComponent
{
   
    public UserCompenet()
    {
       
    }
    public IViewComponentResult Invoke()
    {

        // var user = _users.ToList();
        // if (user is not null)
        // {
        //     return View(user);
        // }
        // else
        // {
        //     return View(Enumerable.Empty<User>());
        // }

        return View(UserController.users.ToList());

    }
}