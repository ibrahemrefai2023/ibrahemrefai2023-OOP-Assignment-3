# Part 02 — answers

---

## Reports

- What was the problem?
- there are many methods in 3 classes that are doing the same thing but in different ways, which makes it difficult to add new report formats without modifying the existing code.
- What did you change?
- i am used  Template Method pattern, implemented with an abstract class to solve the problem, and created a base class for the report exporters that contains the common logic and abstract methods for the specific report formats. Each report exporter class inherits from the base class and implements the specific logic for its format.
- Why did you choose that approach?
- Template Method pattern

---

## Enrollment

- What was the problem?
- if i want to use all the enrollment methods it lead to make an objects of the enrollment class and call the methods, which is not a good approach because it will lead to tight coupling between the classes and make it difficult to change the implementation of the enrollment methods without affecting the classes that use them.
- What did you change?
- I used the Facade design pattern to solve the problem, by creating a new class that acts as a facade for the enrollment methods.
- Why did you choose that approach?
- to use the Facade design pattern to provide a simplified interface for the enrollment methods.
