/**
 * A class representing a person.
 * @class Person
 * @constructor {string} name - The name of the person.
 * @constructor {number} age - The age of the person.
 * @constructor {string} employmentStatus - The employment status of the person.
 * 
 * @method getName - Returns the name of the person.
 * @method getAge - Returns the age of the person.
 * @method getEmployed - Returns the employment status of the person.
 * @method setName - Sets the name of the person.
 * @method setAge - Sets the age of the person.
 * @method setEmployed - Sets the employment status of the person.
 * @method toString - Returns a string representation of the person.
 */
export class Person {
  private name: string;
  private age: number;
  private employmentStatus: string;

  constructor(name: string, age: number, employmentStatus: string) {
    this.name = name;
    this.age = age;
    this.employmentStatus = employmentStatus;
  }

  getName(): string {
    return this.name;
  }

  getAge(): number {
    return this.age;
  }

  getEmployed(): string {
    return this.employmentStatus;
  }

  setName(name: string): void {
    this.name = name;
  }

  setAge(age: number): void {
    this.age = age;
  }

  setEmployed(employed: string): void {
    this.employmentStatus = employed;
  }

  toString(): string {
    return `Name: ${this.name}, Age: ${this.age}, Employed: ${this.employmentStatus}`;
  }
}