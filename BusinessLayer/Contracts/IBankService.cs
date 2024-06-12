using Dranga_Marius_M531.Models;

namespace Dranga_Marius_M531.Contracts
{
	public interface IBankService
	{
		void AddClient(Banca banca, Client client);
		void RemoveClient(Banca banca, Client client);
		void UpdateBank(Banca banca, string nume, Adresa adresa);
		List<Client> DisplayClients(Banca banca);
		List<Client> FilterClients(Banca banca, string nume, Adresa adresa, string tipCredit);
	}
}
