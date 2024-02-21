namespace TamplateMethodDP.Entity
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public UserViewModel(string name, bool isActive)
        {
            Name = name;
            IsActive = isActive;
        }


    }

}
