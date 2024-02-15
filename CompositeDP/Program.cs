using System;

namespace CompositeDP
{
    public class Program
    {
        static void Main(string[] args)
        {

            var category = new Category("Electoronic", "This is Electronic");

            var categoryChaild1 = new CategoryChaild("Phone", "This is Phone");
            var categorycategoryChaild1 = new Category("Iphone", "This is Iphone");
            var categorycategoryChaild2 = new Category("SAmSung", "This is SAmSung");
            categoryChaild1.Add(categorycategoryChaild1);
            categoryChaild1.Add(categorycategoryChaild2);


            var categoryChaild2 = new CategoryChaild("Frize", "this is Frize");
            var categoryChaild3 = new CategoryChaild("Laptop", "This is Laptop");


            category.Add(categoryChaild1);
            category.Add(categoryChaild2);
            category.Add(categoryChaild3);
           


        }
    }

}

