namespace Challenges
{

//public enum Gender
//    {
//        male,
//        female,
//        other
//    }

public class Subscriber
{

        private string _name;
        private int _age;
        private string _gender;
        private long _dateSubscribed;
 

    public Subscriber(string name, string gender, int age, long dateSubscribed)
    {
            Name = name;
            Gender = gender;
            Age = age;
            DateSubscribed = dateSubscribed;
    }

        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public long DateSubscribed { get; set; }
}
}

