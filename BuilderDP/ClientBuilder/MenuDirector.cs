using BuilderDP.AbstractBuilder;

namespace BuilderDP.ClientBuilder
{
    public class MenuDirector
    {
        private IMenuBuilder _menuBuilder;

        public MenuDirector(IMenuBuilder menuBuilder)
        {
            _menuBuilder = menuBuilder;
        }

        public void ConstructMenu(string id, string name, string link)
        {
            _menuBuilder.SetId(id);
            _menuBuilder.SetName(name);
            _menuBuilder.SetLink(link);
        }
        public void ConstructMenu2(string name, string link)
        {
            _menuBuilder.SetId("Null ID");
            _menuBuilder.SetName(name);
            _menuBuilder.SetLink(link);
        }

    }




}
