using Dranga_Marius_M531.Models;

namespace BusinessLayer.Contracts
{
	public interface IGeneralService
	{
		void MoveClient(Banca oldBank, Banca newBank, Client client);
		string SameClient(Banca bank1, Banca bank2, Client client);
	}
}
