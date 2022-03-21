namespace Challenges.c8_dictionaries
{

    public class Subscriber
    {

        private string name;
        private string gender;
        private int age;

        public Subscriber(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetGender()
        {
            return gender;
        }

        public void SetGender(string gender)
        {
            this.gender = gender;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }



    }
}

