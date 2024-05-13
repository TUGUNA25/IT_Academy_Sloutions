using solution;
using System.Linq.Expressions;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
            {
                new Student("nanuka", 20, Groups.C),
                new Student("nini", 18, Groups.A),
                new Student("Mate", 21, Groups.B),
                new Student("tekla", 20, Groups.C),
                new Student("Giorgi", 21, Groups.A)
            };

        // aq iwereba filtris kriteriumebi !!!!!!!!!!!!!!!!
        var filterss = new { Name = "nanuka", Age = 20 };
        List<Student> answerStudents = FilterStudents(students, filterss);
        foreach (var student in answerStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Group: {student.Group}");
        }
    }


    public static List<Student> FilterStudents(List<Student> students, object criteria)
    {
        var properties = criteria.GetType().GetProperties();
        var parameter = Expression.Parameter(typeof(Student), "student");
        var predicates = new List<Expression>();

        foreach (var property in properties)
        {
            var value = property.GetValue(criteria);
            var propertyExpression = Expression.Property(parameter, property.Name);
            var valueExpression = Expression.Constant(value);
            var equalExpression = Expression.Equal(propertyExpression, valueExpression);
            var lambda = Expression.Lambda<Func<Student, bool>>(equalExpression, parameter);
            predicates.Add(lambda.Body);
        }

        var combinedPredicate = predicates.Aggregate(Expression.And);
        var filter = Expression.Lambda<Func<Student, bool>>(combinedPredicate, parameter).Compile();

        return students.Where(filter).ToList();
    }
}
