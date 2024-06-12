using Dranga_Marius_M531.Contracts;
using Dranga_Marius_M531.Models;

namespace Dranga_Marius_M531.Services
{
	public class BankService : IBankService
	{
		public void AddClient(Banca banca, Client client)
		{
			banca.Clienti.Add(client);
		}

		public void RemoveClient(Banca banca, Client client)
		{
			var existingClient = banca.Clienti.FirstOrDefault(c => c.Id == client.Id);
			if (existingClient != null)
			{
				banca.Clienti.Remove(existingClient);
			}
		}

		public void UpdateBank(Banca banca, string nume, Adresa adresa)
		{
			banca.Nume = nume;
			banca.Adresa = adresa;
		}

		public List<Client> DisplayClients(Banca banca)
		{
			var clients = banca.Clienti;
			return clients;
		}

		public List<Client> FilterClients(Banca banca, string nume, Adresa adresa, string tipCredit)
		{
			var filteredClients = banca.Clienti.Where(c =>
			{
				if (c.Adresa == adresa && c.TipCredit == tipCredit && c.Nume == nume) return true;
				return false;
			});

			return filteredClients.ToList();
		}

	}
}
