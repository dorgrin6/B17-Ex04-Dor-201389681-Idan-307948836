namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class TestInterface : IActionObserver
    {
        Menu m_MainMenu;

        public void ReportExecutingAction(IAction i_Action)
        {
            i_Action.DoAction();
        }

        public void Run()
        {
            buildMenu();

            m_MainMenu.Show();
        }

        private void buildMenu()
        {
            Menu subMenuActionInfo, subMenuDateTime, subActions;
            m_MainMenu = new Menu(MenuStrings.k_MainMenu + " Interfaces", Menu.eMenuType.MainMenu, 2);
            subMenuActionInfo = createSubMenu(MenuStrings.k_ActionsAndInfo, 2, m_MainMenu);
            subMenuDateTime = createSubMenu(MenuStrings.k_ShowDateOrTime, 2, m_MainMenu);
            createAction(new DisplayVersion(), MenuStrings.k_DisplayVersion, subMenuActionInfo);
            subActions = createSubMenu(MenuStrings.k_Actions, 2, subMenuActionInfo);
            createAction(new CountSpaces(), MenuStrings.k_CountSpaces, subActions);
            createAction(new CharsCount(), MenuStrings.k_CharsCount, subActions);
            createAction(new ShowTime(), MenuStrings.k_ShowTime, subMenuDateTime);
            createAction(new ShowDate(), MenuStrings.k_ShowDate, subMenuDateTime);
        }

        private void createAction(IAction i_Action, string i_Title, Menu i_ParentMenu)
        {
            MenuAction action = new MenuAction(i_Action, i_Title);
            i_ParentMenu.AddMenuItem(action);
            action.AttachObserver(this as IActionObserver);
        }

        private Menu createSubMenu(string i_Title, int i_SubMenusAmount, Menu i_ParentMenu)
        {
            Menu sub = new Menu(i_Title, Menu.eMenuType.SubMenu, i_SubMenusAmount);
            i_ParentMenu.AddMenuItem(sub);
            return sub;
        }
    }
}