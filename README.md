# LAB 05 - I Built A Zoo
This project holds a a console app which instantiates several different types of animals built using inheritance and implementation.  This project serves as an exercise to show how different properties and methods can be pieced together using the 4 Object Oriented Principles.

## Visual
![zoodigitaldrawing](https://user-images.githubusercontent.com/25948479/46995592-3b357680-d0ce-11e8-8980-360f382c9122.png)

## OOP

### Inheritance
Inheritance is when a derived class takes on the properties and methods of the parent class. Newly formed classes are called child classes, and the classes that child classes are derived from are called parent classes.

*The Mammalia class inherits properties from the Animalia class* 

### Abstraction
Abstract classes serve as templates to be used for derived classes to use and set methods and properties or continue to pass them onto other derived classes.

*All classes with exception to the last level of animal concrete classes are abstract (i.e. - Animalia, Reptilia, Placental, etc.)*

### Polymorphism
We can override virtual methods and properties though they have already been set in the parent class.  This also lets us classify objects from their parent classes.

*The Platypus class overrides the properties and methods from its Monotreme parent class*

### Encapsulation
Encapsulation is the process of protecting blocks of code, whether they be properties or methods from other classes. Examples of encapsulation are Public, private, and protected.

Public - Everyone has access
Private - Only the class has access to it
Protected - the class and any of it's derived children have access.

*All classes are public here since the lineage is direct and none of the properties need to be hidden from another class*

### Interface
Interfaces are similar to abstract classes in that they serve as a sort of template for classes to pull from.  The difference is that interfaces are impletemented and tell us what a class can do whereas an inheritance from an abstract class tell us what a class has.  A class can inherit from only on abstract class but can implement from multiple interfaces.

## Authors & Contributors
Danul De Leon worked on this code.
Amanda Iverson at Code Fellows for providing demo visualizations.