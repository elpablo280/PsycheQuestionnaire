namespace Psykheya
{
    public class User
    {
        public string LastName { get; set; }          // фамилия
        public string FirstName { get; set; }          // имя
        public string MiddleName { get; set; }         // отчество
        public string Group { get; set; }

        public User(string lastName, string firstName, string middleName, string group)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Group = group;
        }


    }
}
