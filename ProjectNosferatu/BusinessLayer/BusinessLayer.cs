using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BusinessLayer
{
	public class BusinessLayer()
	{
		
	}
	private string insert_B(Donor donor)
		{
		return (insert_D(donor) == false) ? "Donor nije upisan u bazu. Proverite da li ste popunili sva polja." : "Donor je uspesno upisan u bazu.";
		}
}
