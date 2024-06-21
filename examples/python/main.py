import Person # import the person module

# A main function should always exist when mimicing OOP in Python - this is the entry point of the program  
def main():
  # Create a new person object
  person = Person.Person("John Doe", 30, "Student")

  # Print the person object
  print(str(person))

  # Update the person object
  person.set_name("Jane Doe")
  person.set_age(25)
  person.set_employed("Unemployed")

  # Print the updated person object
  print(str(person))

main() # Call the main function