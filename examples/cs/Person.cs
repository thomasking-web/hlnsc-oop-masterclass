
class Person
{
  public string Name { get; set; }
  public int Age { get; set; }
  public string EmploymentStatus { get; set; }

  public Person(string name, int age, string employmentStatus)
  {
    Name = name;
    Age = age;
    EmploymentStatus = employmentStatus;
  }

  // define getters
  public string GetName()
  {
    return Name;
  }

  public int GetAge()
  {
    return Age;
  }

  public string GetEmploymentStatus()
  {
    return EmploymentStatus;
  }

  // define setters
  public void SetName(string name)
  {
    Name = name;
  }

  public void SetAge(int age)
  {
    Age = age;
  }

  public void SetEmploymentStatus(string employmentStatus)
  {
    EmploymentStatus = employmentStatus;
  }

  // overwrite the `ToString` method
  public override string ToString()
  {
    return $"Name: {Name}, Age: {Age}, Employment Status: {EmploymentStatus}";
  }
}