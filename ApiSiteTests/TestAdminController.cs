using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace ApiSiteTests
{
    [TestClass]
    public class TestAdminController
    {
        [TestMethod]
        public async Task TestLogin()
        {
            //var tempData = new Mock<ITempDataDictionary>();
            //var settingService = new Mock<ISettingService>();
            //var syslogService = new Mock<ISysLogService>();
            //var authenticationService = new Mock<IAuthenticationService>();
            //authenticationService.Setup(s => s.AuthenticateAsync(It.IsAny<HttpContext>(), It.IsAny<string>()))
            //    .ReturnsAsync(AuthenticateResult.Success(new AuthenticationTicket(new System.Security.Claims.ClaimsPrincipal(), "")));
            //var sp = new Mock<IServiceProvider>();
            //sp.Setup(s => s.GetService(typeof(IAuthenticationService)))
            //    .Returns(() => {
            //        return authenticationService.Object;
            //    });

            //var ctrl = new AdminController(settingService.Object);
            //ctrl.ControllerContext = new ControllerContext();
            //ctrl.ControllerContext.HttpContext = new DefaultHttpContext();
            //ctrl.ControllerContext.HttpContext.RequestServices = sp.Object;
            //ctrl.TempData = tempData.Object;

            //authenticationService.Setup(s => s.AuthenticateAsync(It.IsAny<HttpContext>(), It.IsAny<string>()))
            //   .ReturnsAsync(AuthenticateResult.Fail(""));
            //settingService.Setup(s => s.HasSuperAdminPassword())
            //    .ReturnsAsync(false);


            //settingService.Setup(s => s.HasSuperAdminPassword())
            //   .ReturnsAsync(true);

   
        }

        [TestMethod]
        public async Task TestLogin1()
        {
            //var tempData = new Mock<ITempDataDictionary>();
            //var settingService = new Mock<ISettingService>();
            //settingService.Setup(s => s.ValidateAdminPassword("123456")).ReturnsAsync(true);
            //var syslogService = new Mock<ISysLogService>();

            //var ctrl = new AdminController(settingService.Object);
            
        }


        [TestMethod]
        public async Task TestInitPassword()
        {
            //var settingService = new Mock<ISettingService>();
            //var syslogService = new Mock<ISysLogService>();

            //var ctrl = new AdminController(settingService.Object);
            //var model = new InitPasswordVM
            //{
            //    password = "",
            //    confirmPassword = ""
            //};
            //var act = await ctrl.InitPassword(model);
            //Assert.IsNotNull(act);
            //var vr = act as ViewResult;
            //Assert.IsNotNull(vr);
            //var msg = vr.ViewData["ErrorMessage"];
            //Assert.AreEqual("���벻��Ϊ��", msg);
            //act = await ctrl.InitPassword(new InitPasswordVM
            //{
            //    password = "1",
            //    confirmPassword = ""
            //});
            //Assert.IsNotNull(act);
            //vr = act as ViewResult;
            //Assert.IsNotNull(vr);
            //msg = vr.ViewData["ErrorMessage"];
            //Assert.AreEqual("���벻��Ϊ��", msg);
            //act = await ctrl.InitPassword(new InitPasswordVM
            //{
            //    password = "",
            //    confirmPassword = "1"
            //});
            //Assert.IsNotNull(act);
            //vr = act as ViewResult;
            //Assert.IsNotNull(vr);
            //msg = vr.ViewData["ErrorMessage"];
            //Assert.AreEqual("���벻��Ϊ��", msg);

            //model = new InitPasswordVM
            //{
            //    password = "a12222222222222222222222222222222122222222222222222222222222222222a12222222222222222222222222222222122222222222222222222222222222222",
            //    confirmPassword = "1"
            //};
            //act = await ctrl.InitPassword(model);
            //Assert.IsNotNull(act);
            //vr = act as ViewResult;
            //Assert.IsNotNull(vr);
            //msg = vr.ViewData["ErrorMessage"];
            //Assert.AreEqual("��������ܳ���50λ", msg);

            //act = await ctrl.InitPassword(new InitPasswordVM
            //{
            //    password = "1",
            //    confirmPassword = "2"
            //});
            //Assert.IsNotNull(act);
            //vr = act as ViewResult;
            //Assert.IsNotNull(vr);
            //msg = vr.ViewData["ErrorMessage"];
            //Assert.AreEqual("������������벻һ��", msg);

            //settingService.Setup(s => s.HasSuperAdminPassword()).ReturnsAsync(true);
            //act = await ctrl.InitPassword(new InitPasswordVM
            //{
            //    password = "1",
            //    confirmPassword = "1"
            //});
            //Assert.IsNotNull(act);
            //vr = act as ViewResult;
            //Assert.IsNotNull(vr);
            //msg = vr.ViewData["ErrorMessage"];
            //Assert.AreEqual("�����Ѿ����ù�������Ҫ�ٴ�����", msg);

            //settingService.Setup(s => s.HasSuperAdmin()).ReturnsAsync(false);
            //settingService.Setup(s => s.HasSuperAdmin(It.IsAny<string>())).ReturnsAsync(false);
            //act = await ctrl.InitPassword(new InitPasswordVM
            //{
            //    password = "1",
            //    confirmPassword = "1"
            //});
            //Assert.IsNotNull(act);
            //vr = act as ViewResult;
            //Assert.IsNotNull(vr);
            //msg = vr.ViewData["ErrorMessage"];
            //Assert.AreEqual("��ʼ������ʧ��", msg);

            //settingService.Setup(s => s.SetSuperAdminPassword(It.IsAny<string>())).ReturnsAsync(true);
            //act = await ctrl.InitPassword(new InitPasswordVM
            //{
            //    password = "1",
            //    confirmPassword = "1"
            //});
            //Assert.IsNotNull(act);
            //var rr = act as RedirectResult;
            //Assert.IsNotNull(rr);
            //Assert.AreEqual("InitPasswordSuccess", rr.Url);
        }
    }
}
