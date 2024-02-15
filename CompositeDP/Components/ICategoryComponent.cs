namespace CompositeDP.Components
{
    //فیبلد ها و متد های مشترک بین کتگوری و گتگوری چایلد را اینجا مینویسیم
    public abstract class ICategoryComponent
    {
        protected string Name;

        protected string Description;

        protected ICategoryComponent(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

}

