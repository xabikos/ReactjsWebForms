using System;
using React;

namespace ReactjsWebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var env = AssemblyRegistration.Container.Resolve<IReactEnvironment>();
            var objectModel = new { user = "React User" };
            var reactComponent = env.CreateComponent("PageContent", objectModel);

            PageContent.Text = reactComponent.RenderHtml();
        }
    }
}