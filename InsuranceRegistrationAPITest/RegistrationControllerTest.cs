using AutoMapper;
using InsuranceRegistrationAPI.Controllers;
using InsuranceRegistrationAPI.DTO;
using InsuranceRegistrationAPI.Mappings;
using InsuranceRegistrationAPI.Models;
using InsuranceRegistrationAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace InsuranceRegistrationAPITest
{
    [TestClass]
    public class RegistrationControllerTest
    {
        private Mock<ICustomerService> mockService;
        private MapperConfiguration mockMapper;
        private IMapper mapper;
        private RegistrationController controller;

        [TestInitialize]
        public void TestInit()
        {
            mockService = new Mock<ICustomerService>();

            mockService.Setup(x => x.CreateCustomer(It.IsAny<Customer>()))
                .Returns(new Customer { CustomerId = 1 });

            mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ResourceToModelProfile());
            });
            mapper = mockMapper.CreateMapper();

            controller = new RegistrationController(mockService.Object, mapper);

        }
        [TestMethod]
        public void GetMethodShouldReturnSuccess()
        {
            var result = controller.Get();
            Assert.AreEqual("Running...", result);
        }

        [TestMethod]
        public void RegisterTest()
        {
            CustomerDTO customerInfo = new CustomerDTO
            {
                CustomerName = "Serkan",
                CustomerSurname = "Cakir",
                PolicyReferenceNumber = "SC-123456",
                Email = "test_-.120sd@asd_-.123.co.uk"

            };
            var result = controller.Register(customerInfo);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, ((OkObjectResult)result).Value);
            Assert.AreEqual(Microsoft.AspNetCore.Http.StatusCodes.Status200OK, ((OkObjectResult)result).StatusCode);
        }
    }
}
