using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using DataLayer.Models;
using DataLaye;

namespace DataLayerTestss
{
    [TestClass]
    public class DataLayerTest
    {
        private DonorRepository donorRepository;
        private Mock<DonorRepository> mocDonorRepository = new Mock<DonorRepository>();
        private Donor donor = new Donor
            {
        Id = 123456789,
        Ime "Nikola",
        Prezime "Sreckovic",
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
            mocDonorRepository.Setup(x => x.UnesiNovogDonora(donor)).Returns(1);
            this.donorRepository = new DonorRepository(mocDonorRepository.Object);
            // Act
            var result = donorRepository.UnesiNovogDonora(donor);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // Arange

            // Act

            // Assert
        }
    }
}
