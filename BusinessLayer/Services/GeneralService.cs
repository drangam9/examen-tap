using Dranga_Marius_M531.Models;

namespace Dranga_Marius_M531.Services
{
	public class GeneralService
	{

		public void MoveClient(Banca oldBank, Banca newBank, Client client)
		{
			var checkClient = oldBank.Clienti.Find(c => c.Id == client.Id);
			if (checkClient != null)
			{
				newBank.Clienti.Add(client);
				oldBank.Clienti.Remove(client);
			}
		}
		public string SameClient(Banca bank1, Banca bank2, Client client)
		{
			var bank1Client = bank1.Clienti.Find(c => c.Id == client.Id);
			var bank2Client = bank2.Clienti.Find(c => c.Id == client.Id);
			if (bank1Client == null) return $"client doesn't exist in bank {bank1.Nume}";
			if (bank2Client == null) return $"client doesn't exist in bank {bank2.Nume}";
			if (bank1Client == bank2Client)
				return $"client found at banks {bank1.Nume} and {bank2.Nume}";
			return "error";
		}
	}
}
