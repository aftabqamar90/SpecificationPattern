
#region GENERATE USER
using SpecificationPattern.Model;
using SpecificationPattern.Specification;

List<User> users = new List<User>();
users.Add(new User { Id = 1, Name = "John Doe", Age = 30, Gender = "Male" });
users.Add(new User { Id = 2, Name = "Jane Doe", Age = 25, Gender = "Female" });
users.Add(new User { Id = 3, Name = "Peter Smith", Age = 40, Gender = "" });
users.Add(new User { Id = 4, Name = "Mary Jones", Age = 35, Gender = "Female" });
users.Add(new User { Id = 5, Name = "David Brown", Age = 20, Gender = "Male" });
users.Add(new User { Id = 6, Name = "Susan White", Age = 50, Gender = "Female" });
users.Add(new User { Id = 7, Name = "Michael Black", Age = 38, Gender = "Male" });
users.Add(new User { Id = 8, Name = "Sarah Green", Age = 27, Gender = "Female" });
users.Add(new User { Id = 9, Name = "William Blue", Age = 42, Gender = "" });
#endregion


#region EXPRESSION
var nameExpression = new ExpressionSpecification<User>(ee => ee.Name == "John Doe");
var ageExpression = new ExpressionSpecification<User>(ee => ee.Age == 20);
var genderExpression = new ExpressionSpecification<User>(ee => ee.Gender == "Male");
var notExpression = new ExpressionSpecification<User>(ee => ee.Age > 20);
#endregion

#region RESULTS
//var nameResult = users.FindAll(ee => nameExpression.IsSatisfiedBy(ee));
//var ageResult = users.FindAll(ee => ageExpression.IsSatisfiedBy(ee));
//var andSpecification = nameExpression.And(ageExpression);
//var andResult = users.Where(ee => andSpecification.IsSatisfiedBy(ee));
//var genderResult = users.FindAll(ee => genderExpression.IsSatisfiedBy(ee));
#endregion


//var orSpecification = nameExpression.Or(ageExpression);
//var orResult = users.Where(ee => orSpecification.IsSatisfiedBy(ee)).ToList();

var notSpecification = genderExpression.And(nameExpression).Not(notExpression);
var notResult = users.FindAll(ee => notSpecification.IsSatisfiedBy(ee));


#region USER SPECIFICATION
/// THIS SPECIFICAITON IS SPECIAL FOR USER MODEL ONLY
var userSpecification = new UserSpecification();
foreach (var item in users)
{
    if (userSpecification.IsSatisfiedBy(item))
    {
        Console.WriteLine($"{item.Id} {item.Name} {item.Age}");
    }
}

#endregion



Console.ReadLine();
//Console.WriteLine(andSpecification.Name);

