using System.Threading.Tasks;
using task.Models.TokenAuth;
using task.Web.Controllers;
using Shouldly;
using Xunit;

namespace task.Web.Tests.Controllers
{
    public class HomeController_Tests: taskWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}