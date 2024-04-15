using TeacherWriteBySabir.Exceptions;


namespace TeacherWriteBySabir.Models
{
    internal class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (CheckName(value))
                {

                    _name = value;

                }
            }
        }
        public Person(string name)
        {
            Name = name;
        }
        static bool CheckName(string name)
        {
            if (name.Length < 3 || name.Length > 25)
            {
                throw new WrongInputException("Sehv deyer");
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    throw new WrongInputException("Sehv olcule deyer");
                }
            }
            return true;
        }
    }
}