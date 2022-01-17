using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using Moq;
using DataLayer.Models;
using DataLaye;

namespace DataLayerTests
{
    [TestClass]
    public class DonorTest
    {
        private DonorRepository donorRepository;
        //private Mock<DonorRepository> mocDonorRepository = new Mock<DonorRepository>();
        private Donor donor = new Donor
            {
        Id = 1,
        Ime "Nikola",
        Prezime = "Sreckovic",
        Datum_rodjenja = "18/12/1878",
        Pol = 'M',
        Telefon = "0636307337",
        Adresa = "Izmisljena Adresa Levo",
        Krvna_grupa = "A+"
            };
        [TestMethod]
        public void IsDonorInserted()
        {
            // Arange
           // mocDonorRepository.Setup(x => x.UnesiNovogDonora(donor)).Returns(1);
            this.donorRepository = new DonorRepository();
            // Act
            var result = donorRepository.UnesiNovogDonora(donor);

            if (result > 0)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void isDonorReturned()
        {
            // Arange
            this.donorRepository = new DonorRepository();

            // Act
            var result = donorRepository.VratiDonora();

            if(result != null)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }



        [TestMethod]
        public void isDonorUpdated()
        {
            // Arange
            this.donorRepository = new DonorRepository();

            // Act
            var result = donorRepository.AzuriranjeDonora(donor);

            if (result > 0)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void isDonorRemoved()
        {
            // Arange
            this.donorRepository = new DonorRepository();

            // Act
            var result = donorRepository.BrisanjeDonora(donor.Id);

            if (result > 0)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }
    }
}
