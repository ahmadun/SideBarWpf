using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace MenuWithSubMenu
{
    class SideMenuViewModel
    {


        ResourceDictionary dict = Application.LoadComponent(new Uri("/MenuWithSubMenu;component/Assets/IconDictionary.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;


        public List<MenuItemsData> MenuList => new List<MenuItemsData>
         {
                    new MenuItemsData(){ PathData= (PathGeometry)dict["icon_dashboard"], MenuText="Dashboard", SubMenuList=null},

                    new MenuItemsData()
                    { 
                        PathData= (PathGeometry)dict["icon_users"], MenuText="Profile", 
                        SubMenuList=new List<SubMenuItemsData>
                        {
                            new SubMenuItemsData(){ PathData=(PathGeometry)dict["icon_adduser"], SubMenuText="New User" },
                            new SubMenuItemsData(){ PathData=(PathGeometry)dict["icon_alluser"], SubMenuText="All Users" }
                        }
                    },

                    new MenuItemsData()
                    { PathData= (PathGeometry)dict["icon_mails"], MenuText="Mails",

                    SubMenuList=new List<SubMenuItemsData>
                    {
                        new SubMenuItemsData(){ PathData=(PathGeometry)dict["icon_inbox"], SubMenuText="Inbox" },
                        new SubMenuItemsData(){ PathData=(PathGeometry)dict["icon_outbox"], SubMenuText="Outbox" },
                        new SubMenuItemsData(){ PathData=(PathGeometry)dict["icon_sentmail"], SubMenuText="Sent" }}
                    },

                    new MenuItemsData(){ PathData= (PathGeometry)dict["icon_settings"], MenuText="Settings", SubMenuList=null}
        };
    }

    public class MenuItemsData
    {
        public PathGeometry PathData { get; set; }
        public string MenuText { get; set; }
        public List<SubMenuItemsData> SubMenuList { get; set; }

        public MenuItemsData()
        {
            Command = new CommandViewModel(Execute);
        }

        public ICommand Command { get; }

        private void Execute()
        {
            string MT = MenuText.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(MT))
                navigateToPage(MT);
        }

        private void navigateToPage(string Menu)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainWindowFrame.Navigate(new Uri(string.Format("{0}{1}{2}", "Pages/", Menu, ".xaml"), UriKind.RelativeOrAbsolute));
                }
            }
        }
    }
    public class SubMenuItemsData
    {
        public PathGeometry PathData { get; set; }
        public string SubMenuText { get; set; }

        public SubMenuItemsData()
        {
            SubMenuCommand = new CommandViewModel(Execute);
            navigateToPage("Dashboard");
        }

        public ICommand SubMenuCommand { get; }

        private void Execute()
        {
            string SMT = SubMenuText.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(SMT))
                navigateToPage(SMT);
        }

        private void navigateToPage(string Menu)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainWindowFrame.Navigate(new Uri(string.Format("{0}{1}{2}", "Pages/", Menu, ".xaml"), UriKind.RelativeOrAbsolute));
                }
            }
        }
    }
}