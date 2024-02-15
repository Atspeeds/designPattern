using System.Collections.Generic;
using CompositeDP.Components;

namespace CompositeDP
{
    public class Category : ICategoryComponent, ICategoryOpration
    {
        private List<ICategoryComponent> _components;
        public Category(string name, string description) : base(name, description)
        {
            _components = new List<ICategoryComponent>();
        }

        public void Add(ICategoryComponent component)
        { 
            _components.Add(component);
        }

        public List<ICategoryComponent> GetAll()
        {
            var categorys =new List<ICategoryComponent>();
            foreach (var item in _components)
            {
                categorys.Add(item);
            }
            return categorys;
        }

        public void Remove(ICategoryComponent component)
        {
            _components.Remove(component);
        }

    }

}

