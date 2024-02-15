using System.Collections.Generic;

namespace CompositeDP.Components
{
    //متدهای عملیاتی اینجا میزاریم
    public interface ICategoryOpration
    {
        void Add(ICategoryComponent component);
        void Remove(ICategoryComponent component);
        List<ICategoryComponent> GetAll();
    }

}

