using BuilderDP.Entity;

namespace BuilderDP.AbstractBuilder
{
    public interface IMenuBuilder
    {
        void SetId(string id);
        void SetName(string name);
        void SetLink(string link);
        MenuDynamic GetMenu();
    }




}
