using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Writer.Api.Controllers;

namespace Writer.Tests
{
    [TestClass]
    public class WritersControllerTests
    {
        [TestMethod]
        public void GivenTheGetEndpoint_WhenNoParameters_ThenReturnEveryWriters()
        {
            var controller = InstantiateController();
            var result = controller.Get();

            Assert.IsNotNull(result);
            Assert.IsTrue(result is OkObjectResult);
        }

        [TestMethod]
        public void GivenTheGetEndpoint_WhenSendIdAsParameter_ThenReturnTheWriterWithThisId()
        {
            var controller = InstantiateController();
            var result = controller.Get(1);

            Assert.IsNotNull(result);
            Assert.IsTrue(result is OkObjectResult);
        }

        [TestMethod]
        public void GivenTheGetEndpoint_WhenSendNotFoundIdAsParameter_ThenReturnNotFound()
        {
            var controller = InstantiateController();
            var result = controller.Get(999);

            Assert.IsNotNull(result);
            Assert.IsTrue(result is NotFoundResult);
        }

        [TestMethod]
        public void GivenThePostEndpoint_WhenSendData_ThenCreateNewWriter()
        {
            var controller = InstantiateController();
            var result = controller.Post(new Writer.Api.Models.Writer { Id = 0, Name = "New Writer" });

            Assert.IsNotNull(result);
            Assert.IsTrue(result is CreatedResult);
        }

        public WritersController InstantiateController()
        {
            return new WritersController();
        }
    }
}

