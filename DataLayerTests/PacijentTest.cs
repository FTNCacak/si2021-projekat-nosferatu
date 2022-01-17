using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using Moq;
using DataLayer.Models;
using DataLaye;

namespace DataLayerTests
{
    [TestClass]
    public class PacijentTest
    {
        private PacijentRepository pacijentRepository;
        //private Mock<DonorRepository> mocDonorRepository = new Mock<DonorRepository>();
        private Pacijent pacijent = new Pacijent
            {
        Id = 1,
        Ime = "Nikola",
        Prezime = "Sreckovic",
        Datum_rodjenja = "18/12/1878",
        Pol = 'M',
        Telefon = "0636307337",
        Adresa = "Izmisljena Adresa Levo",
        Krvna_grupa = "A+"
            };
        [TestMethod]
        public void IsPacijentInserted()
        {
            // Arange
           // mocDonorRepository.Setup(x => x.UnesiNovogDonora(donor)).Returns(1);
            this.pacijentRepository = new PacijentRepository();
            // Act
            var result = pacijentRepository.UnesiNovogPacijenta(pacijent);

            if (result > 0)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void isPacijentReturned()
        {
            // Arange
            this.pacijentRepository = new PacijentRepository();


            // Act
            var result = pacijentRepository.VratiPacijenta();

            if (result != null)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }



        [TestMethod]
        public void isPacijentUpdated()
        {
            // Arange
            this.pacijentRepository = new PacijentRepository();

            // Act
            var result = donorRepository.AzuriranjePacijenta(pacijent);

            if (result > 0)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void isPacijentRemoved()
        {
            // Arange
            this.pacijentRepository = new PacijentRepository();

            // Act
            var result = donorRepository.BrisanjePacijenta(pacijent.Id);

            if (result > 0)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }
    }
}
