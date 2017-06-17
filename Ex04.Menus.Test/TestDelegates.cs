namespace Ex04.Menus.Test
{
    using Ex04.Menus.Delegates;

    public class TestDelegates
    {
        Menu m_MainMenu;

        public void Run()
        {
            buildMenu();

            m_MainMenu.Show();
        }

        private void buildMenu()
        {
            m_MainMenu = new Menu(MenuStrings.k_MainMenu + " Delegates", Menu.eMenuType.MainMenu, 2);
            Menu subMenuActionInfo = createSubMenu(MenuStrings.k_ActionsAndInfo, 2, m_MainMenu);
            Menu subMenuDateTime = createSubMenu(MenuStrings.k_ShowDateOrTime, 2, m_MainMenu);
            Menu subActions = createSubMenu(MenuStrings.k_Actions, 2, subMenuActionInfo);

            MenuAction displayVersion = createAction(MenuStrings.k_DisplayVersion, subMenuActionInfo);
            MenuAction countSpaces = createAction(MenuStrings.k_CountSpaces, subActions);
            MenuAction charsCount = createAction(MenuStrings.k_CharsCount, subActions);
            MenuAction showTime = createAction(MenuStrings.k_ShowTime, subMenuDateTime);
            MenuAction showDate = createAction(MenuStrings.k_ShowDate, subMenuDateTime);

            displayVersion.ActionDone += new DisplayVersion().DoAction;
            countSpaces.ActionDone += new CountSpaces().DoAction;
            charsCount.ActionDone += new CharsCount().DoAction;
            showTime.ActionDone += new ShowTime().DoAction;
            showDate.ActionDone += new ShowDate().DoAction;
        }

        private MenuAction createAction(string i_Title, Menu i_ParentMenu)
        {
            MenuAction action = new MenuAction(i_Title);
            i_ParentMenu.AddMenuItem(action);
            return action;
        }

        private Menu createSubMenu(string i_Title, int i_SubMenusAmount, Menu i_ParentMenu)
        {
            Menu sub = new Menu(i_Title, Menu.eMenuType.SubMenu, i_SubMenusAmount);
            i_ParentMenu.AddMenuItem(sub);
            return sub;
        }
    }
}