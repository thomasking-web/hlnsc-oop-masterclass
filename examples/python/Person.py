class Person:
  """
  A class representing a person.

  Attributes:
    name (str): The name of the person.
    age (int): The age of the person.
    employment_status (str): The employment status of the person.

  Methods:
    get_name(): Returns the name of the person.
    get_age(): Returns the age of the person.
    get_employed(): Returns the employment status of the person.
    set_name(name): Sets the name of the person.
    set_age(age): Sets the age of the person.
    set_employed(employed): Sets the employment status of the person.

  Overrides:
    __str__(): Returns a string representation of the person.
  """

  def __init__(self, name, age, employment_status):
    self.name = name
    self.age = age
    self.employment_status = employment_status

  def get_name(self):
    return self.name

  def get_age(self):
    return self.age

  def get_employed(self):
    return self.employed

  def set_name(self, name):
    self.name = name

  def set_age(self, age):
    self.age = age

  def set_employed(self, employed):
    self.employment_status = employed

  def __str__(self) -> str:
    return f"Name: {self.name}, Age: {self.age}, Employed: {self.employment_status}"  
