# code-kata-coffee-loyalty-program
Code kata to implement a loyality program for a coffee shop.

## Goal
- Make you think about your coding practices.
- Consider the trade-offs involved when performing everyday programming tasks like splitting a class or a method.

## Problem
Design and implement a loyalty program for a coffee shop. Customers collect one stamp per coffee; when they reach six stamps, 
they have one free coffee. The application exposes the following public operations:
- Create a customer.
- Create a stamp for a customer.
- List all stamps and free coffees for a customer.
- Redeem a free coffee.

If the customer reaches six stamps upon adding a new stamp, the application should create a free reward coffee.

### Notes/assumptions
- The app may hold state (customers, stamps, free coffees) in memory.
- Make reasonable assumptions for things like error handling (trying to add stamps to non-exiting customers, for example); that part is not that important.
- To ease testing, you can pre-load your application with customers, stamps and free coffees.

## Rules
- Follow SOLID principles
- Follow Clean Code and Clean Architecture principles
- Swagger support
- Create a `Dockerfile` and `docker-compose.yaml` to run the implementation and execute necessary tests

## Advanced Rules
- Api First approach
- Using Test driven development
- Advanced Clean Code
  - All methods have a maximum of three lines of code.
  - All classes have a maximum of two fields (excluding data classes and POJOs).
  - All classes have a maximum of ten lines of code (excluding imports).

## References
- [Medium: The best code kata ever (Miguel Pimenta)](https://medium.com/@migpimenta/the-best-code-kata-ever-61722511ebc)
