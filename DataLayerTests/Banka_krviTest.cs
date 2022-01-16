using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using Moq;
using DataLayer.Models;
using DataLaye;

namespace DataLayerTests
{
    [TestClass]
    public class TransferTest
    {
        private TransferRepository transferRepository;
        //private Mock<DonorRepository> mocDonorRepository = new Mock<DonorRepository>();
        private Transfer transfer = new Transfer
        {
        Zalihe = 2,
        Sifra = "12345678"
            };
        [TestMethod]
        public void isBankReturned()
        {
            // Arange
            this.krviRepository = new Banka_krviRepository();

            // Act
            var result = krviRepository.VratiZaliheKrvi();

            if(result != 0)
                result = true;
            else
                return false;
            // Assert
            Assert.IsTrue(result);
        }



        [TestMethod]
        public void isBankUpdated()
        {
            // Arange
            this.krviRepository = new Banka_krviRepository();


            // Act
            var result = krviRepository.AzuriranjeListeKrvi(banka);


            if (result > 0)
                    result = true;
            else
                    result = false;
            // Assert
            Assert.IsTrue(result);
        }
    }
}
