// Notice how we do not need to do `using` for the `Person` class - it is in the same namespace as the `Program` class.
namespace cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Person person = new("John Doe", 30, "Student");

      // print the person object
      Console.WriteLine(person.ToString());

      // update the person object
      person.SetName("Jane Doe");
      person.SetAge(25);
      person.SetEmploymentStatus("Unemployed");

      // print the updated person object
      Console.WriteLine(person.ToString());
    }
  }
}