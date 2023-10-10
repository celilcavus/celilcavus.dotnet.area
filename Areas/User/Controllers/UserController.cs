using celilcavus.models;
using celilcavus.ViewCompenets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace celilcavus.Controllers;

[Area("User")]
public class UserController : Controller
{

    public static List<User> users = new List<User>();
    User user = new User();
    public IActionResult index()
    {
        return View();
    }


    [HttpPost]
    public IActionResult index(User user)
    {
        user.Name = user.Name;
        user.Lastname = user.Lastname;
        users.Add(user);

        return View();
    }

    [HttpGet]
    public IActionResult Update(string guid)
    {
        var findUser = users.SingleOrDefault(x => x.id.ToString() == guid);
         return View(findUser);
    }

    [HttpPost]
    public IActionResult Update(User user)
    {
        var findUser = users.SingleOrDefault(x => x.id == user.id);

        if (findUser is { Name: not null, Lastname: not null })
        {
            // findUser.ListNumber  = users.Count() + 1;
            findUser.Name = user.Name;
            findUser.Lastname = user.Lastname;
            findUser.UpdateDate = DateTime.Now;
            
            return RedirectToAction(nameof(index));
        }
        else
        {
            return View(Enumerable.Empty<User>());
        }
    }

    public IActionResult Delete(string id)
    {
        var findUser = users.SingleOrDefault(x => x.id.ToString() == id);

        if (findUser is { Name: not null, Lastname: not null })
        {
            users.Remove(findUser);
            return RedirectToAction(nameof(index));
        }
        else
        {
            return RedirectToAction(nameof(index));
        }
    }
}