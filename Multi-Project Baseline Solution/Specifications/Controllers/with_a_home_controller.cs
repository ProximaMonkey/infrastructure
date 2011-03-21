namespace Specifications.Controllers
{
        public abstract class with_a_home_controller
        {
            Establish context = () =>
                controller = new HomeController();

            protected static HomeController controller;
        }

        public class when_calling_home_view_actions : with_a_home_controller
        {
            static ActionResult result;

            Because of = () =>
                result = controller.Index();

            It should_return_index = () =>
                result.ShouldNotBeNull();
        }
}
