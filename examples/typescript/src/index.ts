// import the Person class from the Person module
import { Person } from './Person';

// A main function should always exist when mimicing OOP in TypeScript - this is the entry point of the program
function main(): void {
  // Create a new person object
  const person = new Person("John Doe", 30, "Student");

  // Print the person object
  console.log(person.toString());

  // Update the person object
  person.setName("Jane Doe");
  person.setAge(25);
  person.setEmployed("Unemployed");

  // Print the updated person object
  console.log(person.toString());
}

main(); // Call the main function
