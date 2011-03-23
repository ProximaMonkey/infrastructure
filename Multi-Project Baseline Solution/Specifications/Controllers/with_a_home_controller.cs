using System.Web.Mvc;
using Machine.Specifications;
using Web.Controllers;

namespace Specifications.Controllers
{
    public abstract class with_a_home_controller
    {
        Establish context = () =>
            controller = new HomeController();

        protected static HomeController controller;
    }

    public class when_calling_index : with_a_home_controller
    {
        static ActionResult result;

        Because of = () =>
            result = controller.Index();

        It should_return_index = () =>
            result.ShouldNotBeNull();
    }

    public class when_calling_translations : with_a_home_controller
    {
        static ActionResult result;

        Because of = () =>
            result = controller.Translations();

        It should_return_translations = () =>
            result.ShouldNotBeNull();
    }

    public class when_calling_zen_garden :with_a_home_controller
    {
        static ActionResult result;

        Because of = () =>
            result = controller.ZenGarden();

        It shoould_return_zengarden = () =>
            result.ShouldNotBeNull();
    }
}
