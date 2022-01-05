using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLaye;

public class BusinessLayer
{
	private readonly DonorRepository donorRepository = new DonorRepository();
	private readonly PacijentRepository pacijentRepository = new PacijentRepository();
	private readonly RadnikRepository radnikRepository = new RadnikRepository();
	
	private string delete_Donor_B(Donor donor)
	{
		return (donorRepository.BrisanjeDonora(donor.Id) < 0) ? "Donor nije pronadjen." : "Donor je uspesno obrisan.";
	}

	private string update_Donor_B(Donor donor)
		{
		return   (donorRepository.AzuriranjeDonora(donor) < 0 ) ? "Donor nije pronadjen." : insert_Donor_B(donor);
		}
	private string insert_Donor_B(Donor donor)
		{
		return ( donorRepository.UnesiNovogDonora(donor) < 0 ) ? "Donor nije upisan u bazu. Proverite da li ste popunili sva polja." : "Donor je uspesno upisan u bazu.";
		}
	private List<Donor> getall_Donor_B()
    {
		return donorRepository.VratiDonora();
	}


	private List<Pacijent> getall_pacients_B()
    {
		return pacijentRepository.VratiPacijenta();
	}
	private string insert_Pacient_B(Pacijent p)
    {
		return ( pacijentRepository.UnesiNovogPacijenta(p) < 0 ) ? "Pacijent nije upisan u bazu. Proverite da li ste popunili sva polja." : "Pacijent je uspesno upisan u bazu.";
    }
	private string update_Pacient_B(Pacijent p)
    {
		return ( pacijentRepository.AzuriranjePacijenta(p) < 0 ) ? "Baza nije azurirana. Proverite da li ste popunili sva polja." : "Baza je uspesno azurirana.";
    }
	private string delete_Pacient_B(int key)
    {
		return ( pacijentRepository.BrisanjePacijent(key) < 0 ) ? "Pacijent nije pronadjen. Proverite unesene podatke." : "Pacijent je uspesno obrisan.";
    }


	private List<Radnik> getall_Workers_B()
    {
		return radnikRepository.VratiRadnika();
	}
	private string insert_Worker_B(Radnik r)
    {
		return ( radnikRepository.UnesiNovogRadnika(r) < 0 ) ? "Radnik nije upisan u bazu. Proverite da li ste popunili sva polja." : "Radnik je uspesno upisan u bazu.";
    }
	private string update_Worker_B(Radnik r)
    {
		return ( radnikRepository.AzuriranjeRadnika(r) < 0 ) ? "Baza nije azurirana. Proverite da li ste popunili sva polja." : "Baza je uspesno azurirana.";
    }
	private string delete_Worker_B(int key)
    {
		return ( radnikRepository.BrisanjeRadnika(key) < 0 ) ? "Radnik nije pronadjen. Proverite unesene podatke." : "Radnik je uspesno obrisan.";
    }
}
