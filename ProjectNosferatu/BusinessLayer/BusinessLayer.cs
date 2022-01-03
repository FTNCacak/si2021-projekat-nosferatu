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
}
