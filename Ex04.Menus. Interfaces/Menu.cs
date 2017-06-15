using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class Menu : MenuItem, IMenu
    {
        private readonly List<MenuItem> m_MenuItems;

        private eMenuType m_MenuType;

        private readonly string m_QuitString;

        public Menu(string i_Title, eMenuType i_MenuType, int i_SubMenusAmount) 
            : base(i_Title)
        {
            m_MenuItems = new List<MenuItem>(i_SubMenusAmount);
        }

        public enum eMenuType
        {
            MainMenu,
            SubMenu
        }

        private enum eMenuSession
        {
            Running,
            UserQuit
        }

        public void Show()
        {
            int userChoice;
            eMenuSession menuSession = eMenuSession.Running;

            do
            {
                Console.WriteLine(Title);
                Console.WriteLine("Please choose one of the options:");
                ShowLayout();
                userChoice = int.Parse(Console.ReadLine());
                //m_MenuItems[userChoice-1].Show/Execute
                //we have a problem with our inheritance scheme

            }
            while (menuSession != eMenuSession.UserQuit);
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            i_MenuItem.ParentMenuItem = this;
            m_MenuItems.Add(i_MenuItem);
        }

        public string ShowLayout()
        {      
            int index = 1;

            StringBuilder layout = new StringBuilder();
            foreach (MenuItem item in m_MenuItems)
            {
                layout.AppendLine($"{index}) {item.Title}");
                ++index;
            }
            layout.AppendLine($"0) {m_QuitString}");

            return layout.ToString();
        }

    }


}
