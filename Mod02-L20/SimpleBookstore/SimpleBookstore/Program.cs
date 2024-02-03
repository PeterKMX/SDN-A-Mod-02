using System.Reflection;

using SimpleBookstore.Controllers;
using SimpleBookstore.Backend;

namespace SimpleBookstore
{
  internal class Program
  {
    //------------------------------------------------------------------------------
    static void Main(string[] args)
    {
      string appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
      Console.WriteLine($"App: M02-L20, v.{appVersion}");
      Console.WriteLine($"Today is {DateTime.Now}");
      Console.WriteLine("");
      Console.WriteLine("Welcome to Simple Bookstore application");

      BackendInMemoryStore.Configure();
      MainMenuService mainMenuService = new MainMenuService();
      mainMenuService.Configure();
      MainMenu mainMenu = new MainMenu(mainMenuService);
      MenuActionController controller = new MenuActionController();

      while (true)
      {
        ActionTypes userAction = mainMenu.SelectFromActionsMenu();
        if (userAction != ActionTypes.Exit)
        {
          controller.ProcessUserAction(userAction);
        }
        else
        {
          break;
        }
      }

      Console.WriteLine();
      Console.WriteLine("STOPPING: Press any key to exit ...");
      string s = Console.ReadLine();
    }
  }
}
