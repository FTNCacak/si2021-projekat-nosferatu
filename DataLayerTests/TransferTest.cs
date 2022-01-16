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
        Sifra = "12345678",
        Datum_transfera = "18/12/1878",
        Ime_pacijenta = "Nikola",
        Krvna_grupa = "A+"
        };
        [TestMethod]
        public void isTransferReturned()
        {TransferRepository
            // Arange
            this.transferRepository = new TransferRepository();

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
        public void isTransferInserted()
        {
            // Arange
            this.transferRepository = new TransferRepository();


            // Act
            var result = krviRepository.UnesNovogTransfera(transfer);


            if (result > 0)
                    result = true;
            else
                    result = false;
            // Assert
            Assert.IsTrue(result);
        }
    }
}
