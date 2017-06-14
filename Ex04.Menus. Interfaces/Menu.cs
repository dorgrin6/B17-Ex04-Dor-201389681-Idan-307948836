namespace Ex04.Menus.Interfaces
{
    using System.Collections.Generic;
    using System.Text;

    public class Menu : MenuItem, IMenu
    {
        private readonly List<MenuItem> m_MenuItems;

        private eMenuType m_MenuType;

        private readonly string m_QuitString;

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
            eMenuSession menuSession = eMenuSession.Running;

            do
            {

            }
            while (menuSession != eMenuSession.UserQuit);
        }

        public void AddItem(MenuItem i_MenuItem)
        {
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
