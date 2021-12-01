using System.Threading.Tasks;
using JenkinsTryOut.Models.TokenAuth;
using JenkinsTryOut.Web.Controllers;
using Shouldly;
using Xunit;

namespace JenkinsTryOut.Web.Tests.Controllers
{
    public class HomeController_Tests: JenkinsTryOutWebTestBase
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