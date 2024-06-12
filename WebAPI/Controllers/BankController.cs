using Dranga_Marius_M531.Contracts;
using Dranga_Marius_M531.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	public class BankController : Controller
	{
		private readonly IBankService _bankService;
		private readonly Stocare stocare;

		public BankController(IBankService bankService)
		{
			_bankService = bankService;
		}

		[HttpGet]
		public IActionResult GetClients(Guid bankId)
		{
			var bank = stocare.GetBanks().Find(b => b.Id == bankId);
			var clients = _bankService.DisplayClients(bank);
			return Ok(clients);
		}
	}
}
