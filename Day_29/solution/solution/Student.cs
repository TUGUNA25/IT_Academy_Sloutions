namespace solution
{
    public enum Groups
    {
        A,
        B,
        C,
        D
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Groups Group { get; set; }

        public Student(string name, int age, Groups group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

    }


}
