using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UpSchoolAkbank_CapStone.Models;

namespace UpSchoolAkbank_CapStone.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}	

		[HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> SignUp(UserRegisterViewModel p)
		{
			AppUser appUser = new AppUser()
			{
				Name = p.Name,
				Surname = p.Surname,
				Email = p.Mail,
				UserName = p.Username
				//şifreyi bu kısımda almadık aşağıdaki döngü ile aldık çünkü burada create async metodu ile alınıyor ve şifreler arka tarafta heşlenerek geliyor. ıdentity tablosunda öyle 
			};
			if (p.Password == p.ConfirmPassword) //şifreler uyumlu mu değil mi
			{
				var result = await _userManager.CreateAsync(appUser, p.Password);

				if (result.Succeeded)
				{
					return RedirectToAction("SignIn");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View(p);
		}


		[HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> SignIn(UserSignInViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Profile", new {area = "Member"});
				}
				else
				{
					return RedirectToAction("SignIn", "Login");
				}
			}
			return View();
		}
	}
}
