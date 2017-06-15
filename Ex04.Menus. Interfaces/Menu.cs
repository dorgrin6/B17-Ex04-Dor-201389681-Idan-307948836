namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices.WindowsRuntime;
    using System.Text;

    public class Menu : MenuItem, IMenu
    {
        private const string k_Back = "Back";

        private const string k_Exit = "Exit";

        private const int k_UserQuitIndex = 0;

        private const string k_Bar = "------------------------------------";

        private readonly List<MenuItem> m_MenuItems;

        private readonly eMenuType r_MenuType;

        private readonly string r_QuitString;

        public Menu(string i_Title, eMenuType i_MenuType, int i_SubMenusAmount)
            : base(i_Title)
        {
            m_MenuItems = new List<MenuItem>(i_SubMenusAmount);

            r_MenuType = i_MenuType;

            switch (i_MenuType)
            {
                case eMenuType.SubMenu:
                    r_QuitString = k_Back;
                    break;
                case eMenuType.MainMenu:
                    r_QuitString = k_Exit;
                    break;
            }
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

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            i_MenuItem.ParentMenuItem = this;
            m_MenuItems.Add(i_MenuItem);
        }

        public string GetLayout()
        {
            int index = 1;

            StringBuilder layout = new StringBuilder();
            foreach (MenuItem item in m_MenuItems)
            {
                layout.AppendLine($"{index}) {item.Title}");
                ++index;
            }
            layout.AppendLine($"{k_UserQuitIndex}) {r_QuitString}");

            return layout.ToString();
        }

        public override void Show()
        {
            int userChoice;
            eMenuSession menuSession = eMenuSession.Running;

            do
            {
                Console.Clear();
                showTitle();
                Console.WriteLine("Please choose one of the options:");
                Console.WriteLine(this.GetLayout());
                userChoice = getValidUserInput();
                if (userChoice == k_UserQuitIndex)
                {
                    menuSession = eMenuSession.UserQuit;
                }
                else
                {
                    m_MenuItems[userChoice - 1].Show();
                    if (this.m_MenuItems[userChoice - 1] is MenuAction)
                    {
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }
            }
            while (menuSession != eMenuSession.UserQuit);
        }

        private int getValidUserInput()
        {
            bool validInput = false;
            int result;

            do
            {
                string input = Console.ReadLine();
                validInput = int.TryParse(input, out result);

                if (!validInput)
                {
                    Console.WriteLine("Please try again.");
                }
            }
            while (!validInput);

            return result;
        }

        private void showTitle()
        {
            Console.WriteLine(k_Bar);
            Console.WriteLine("\t    {0}", Title);
            Console.WriteLine(k_Bar);
        }
    }
}