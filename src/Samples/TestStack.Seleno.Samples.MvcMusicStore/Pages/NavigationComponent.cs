using TestStack.Seleno.PageObjects;
using OpenQA.Selenium;

namespace TestStack.Seleno.Samples.MvcMusicStore.Pages
{
    public class NavigationComponent : UiComponent
    {
        public LogonPage SelectAdminForNotLoggedInUser()
        {
            return NavigateTo<LogonPage>(By.LinkText("Admin"));
        }
    }
}