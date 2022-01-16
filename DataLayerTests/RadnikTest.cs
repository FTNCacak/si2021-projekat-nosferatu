using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using Moq;
using DataLayer.Models;
using DataLaye;

namespace DataLayerTests
{
    [TestClass]
    public class RadnikTest
    {
        private RadnikRepository radnikRepository;
        //private Mock<DonorRepository> mocDonorRepository = new Mock<DonorRepository>();
        private Radnik radnik = new Radnik
            {
        Id = 1,
        Korisnicko_ime = "Nikola",
        Sifra = "12345678"
            };
        [TestMethod]
        public void IsRadnikInserted()
        {
            // Arange
           // mocDonorRepository.Setup(x => x.UnesiNovogDonora(donor)).Returns(1);
            this.radnikRepository = new RadnikRepository();
            // Act
            var result = radnikRepository.UnesiNovogRadnika(radnik);

            if (result > 0)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void isRadnikReturned()
        {
            // Arange
            this.radnikRepository = new RadnikRepository();

            // Act
            var result = radnikRepository.VratiRadnika();

            if (result != null)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }



        [TestMethod]
        public void isRadnikUpdated()
        {
            // Arange
            this.radnikRepository = new RadnikRepository();

            // Act
            var result = radnikRepository.AzuriranjeRadnika(radnik);

            if (result > 0)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void isRadnikRemoved()
        {
            // Arange
            this.radnikRepository = new RadnikRepository();

            // Act
            var result = radnikRepository.BrisanjeRadnika(radnik.Id);

            if (result > 0)
                result = true;
            else
                result = false;
            // Assert
            Assert.IsTrue(result);
        }
    }
}
