using BuilderDP.AbstractBuilder;
using BuilderDP.Entity;

namespace BuilderDP.ConcreateBuilder
{
    public class MenuBuilderTwo : IMenuBuilder
    {
        protected MenuDynamic _Menue = new MenuDynamic();

        public MenuDynamic GetMenu()
        {
            return _Menue;
        }

        public void SetId(string id)
        {
            _Menue.Id = id;
        }

        public void SetLink(string link)
        {
            _Menue.Link = $"https//www.{link}.com";
        }

        public void SetName(string name)
        {
            _Menue.Name = name;
        }
    }




}
