namespace Challenges.c8_dictionaries
{

    public class Subscriber
    {

        private string _name;
        private string _gender;
        private int _age;

        public Subscriber(string name, string gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}

