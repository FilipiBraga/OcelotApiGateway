using Article.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Article.Tests
{
    [TestClass]
    public class ArticleControllerTests
    {
        [TestMethod]
        public void GivenTheGetEndpoint_WhenNoParameters_ThenReturnEveryArticles()
        {
            var controller = InstantiateController();
            var result = controller.Get();

            Assert.IsNotNull(result);
            Assert.IsTrue(result is OkObjectResult);
        }

        [TestMethod]
        public void GivenTheGetEndpoint_WhenSendIdAsParameter_ThenReturnTheArticleWithThisId()
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
            var result = controller.Get(99);

            Assert.IsNotNull(result);
            Assert.IsTrue(result is NotFoundResult);
        }

        [TestMethod]
        public void GivenTheDeleteEndpoint_WhenSendIdAsParameter_ThenDeleteTheArticleWithThisId()
        {
            var controller = InstantiateController();
            var result = controller.Delete(1);

            Assert.IsNotNull(result);
            Assert.IsTrue(result is OkObjectResult);
        }

        [TestMethod]
        public void GivenTheDeleteEndpoint_WhenSendNotFoundIdAsParameter_ThenReturnNoContent()
        {
            var controller = InstantiateController();
            var result = controller.Delete(1);

            Assert.IsNotNull(result);
            Assert.IsTrue(result is NoContentResult);
        }

        private ArticlesController InstantiateController()
        {
            return new ArticlesController();
        }
    }
}