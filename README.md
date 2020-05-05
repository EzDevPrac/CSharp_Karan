# C-Sharp Project Karan 
[![Build Status](https://dev.azure.com/karan1198kumar/MyCsharpProjectJKT/_apis/build/status/EzDevPrac.CSharp_Karan?branchName=master)](https://dev.azure.com/karan1198kumar/MyCsharpProjectJKT/_build/latest?definitionId=1&branchName=master)

# DESIGN PATTERN

## Prototype Design Pattern

1.  Prototype pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns
2.  Prototype design pattern is used to create a duplicate object or clone of the current object to enhance performance. This pattern    
    is used when the creation of an object is costly or complex.
3.  This pattern is particularly useful for creating lots of instances of an object, all of which share some or all of their values.
4.  Prototype pattern solves problem related with duplicating a class in C#. There are scenarios in our programs where we want to copy   
    any object and proceed independently with the copied object without affecting the original object.In C#, classes are reference type, so if you will copy the class object to another empty object and change the one object then it will also effect the other object, which is not desirable.    

**Difference between Shadow and Deep Cloning**

1.  The cloning falls under two categories: shallow and deep.
A shallow copy copies all reference types or value types, but it does not copy the objects that the references refer to. The references in the new object point to the same objects that the references in the original object points to.
(Only Parent Object is cloned here).
 
2.  In contrast, a deep copy of an object copies the elements and everything directly or indirectly referenced by the elements.
(Parent Object is cloned along with the containing objects)

**UML DIAGRAM**

[](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/UMl%20Diagram.png)

Participants in above UML diagram are:

**1.  IPrototype**: Interface that is used for the Prototypes (objects) to clone itself

**2.  ConcretePrototype1, ConcretePrototype2**: Implements IPrototype interface

**3.  Client:** Client class will make clones of different objects


**Code Snippet**

**1.  Prototype Interface**

[](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/Prototype.png)

**2.  Student Concrete Prototype**

[](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/Student.png)

**3.  Employee Concrete Prorotype**

[](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/Employee.png)

**4.  Client**

[](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/Client.png)

**Output**

[](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/Output.png)

Code for the above snippet is available in the following link.

https://github.com/EzDevPrac/CSharp_Karan/tree/master/PrototypePattern


## Itterator Design Pattern

1.  Iterator Design Pattern falls under Behavioral Pattern of Gang of Four (GOF) Design Patterns.
2.  Iterator Design Pattern provides a way to access the elements of a collection object in a sequential manner without 
    knowing its underlying structure.
3.  This pattern is commonly used in the menu systems of many applications such as Editor, IDE, etc.
4.  The idea is that we'll have a class (the "Iterator") which contains a reference to a corresponding aggregate object, and 
    that Iterator can traverse over its aggregate to retrieve individual objects.



**UML DIAGRAM**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/6061d7e5505e701c07d2a99c1cb2c3d7/Screenshot__132_.png)


The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.  Client**
This is the class that contains an object collection and uses the Next operation of the iterator to retrieve items from the aggregate in an appropriate sequence.

**2.  Iterator**
This is an interface that defines operations for accessing the collection elements in a sequence.

**3.  ConcreteIterator**
This is a class that implements the Iterator interface.

**4.  Aggregate**
This is an interface which defines an operation to create an iterator.

**5.  ConcreteAggregate**
This is a class that implements an Aggregate interface.

**Code Snippet**

1.  Aggregate Interface

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/c820e220b8b7ac7fa215612a3abc9e63/Aggregate.png)

2.  Collection Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/671298b35a66f87d321ecaa2f7024241/Collection.png)

3.  Concrete Aggregate

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/370fb64768d8e7c2ed206a71101ebac8/ConcreteAggregate.png)


4.  Iterttor

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/8325eb1b2b99eb7d9f3008e46500176f/Iterrator.png)


5.  Concrete Itterator

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/725fdd6ee640751b6e9ca1691bf7dd6d/ConcreteItterstor.png)


6.  Main Menu

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/9a03d871db36ef446e630ccbc75a09ea/MainMenu.png)


**OUTPUT**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/e704ef85fc1e56007443f5a86b4d54dc/output.png)


Link for the example code for the above code snippet

https://github.com/EzDevPrac/CSharp_Karan/tree/master/IceCreamShopItterator


## Strategy Design Pattern

1.  Strategy Design Pattern falls under Behavioral Pattern.
2.  This pattern allows a client to choose an algorithm from a family of algorithms at run-time and gives it a simple way to 
    access it.
3.  Strategy Design Pattern involves the removal of an algorithm from its host class and putting it in a separate class. As 
    you know, there may be multiple strategies which are applicable for a given problem.

**UML diagram for the Strategy Design Pattern  is given Below**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/4dee4d9c7c262a115975a7b5ba38d11f/Screenshot__124_.png)

The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.  Context**
This is a class that contains a property to hold the reference of a Strategy object. This property will be set at run-time according to the algorithm that is required.

**2.  Strategy**
This is an interface that is used by the Context object to call the algorithm defined by a ConcreteStrategy.

**3.  ConcreteStrategyA/B**
These are classes that implement the Strategy interface.

**CODE SNIPPET**

1.  Strategy Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/619b1f1912fc03e467eb438d8aeb2327/Strategy.png)

2.  Concrete Strategy class for PhonePe

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/676c0e20b47ac8b27116ef1bad13dbe9/Concrete_phonepay.png)

3.  Concrete Strategy Class for Paytm

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/8d53b16ff8e82883c3bd40bcd6837b5b/Concrete_Paytm.png)

4.  Concrete Strategy Class for Google pay

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/862b865527d4d149a6bc78510c4d8baa/Concrete_google_pay.png)

5.  Context class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/09872efb4aab8f78a53a600ae2d0bd4e/Context.png)

6.  Main Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/ae909c1e9ec0bd42c37ad48fc85f525c/MainClass.png)

**INPUT AND OUTPUT**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/15aa9a5a1a5db79e2146cbcaf8dc625c/Output.png)

Code for the above code snippet is available in the following link
https://github.com/EzDevPrac/CSharp_Karan/tree/master/OnlinePaymentStrategyPattern



## Observer Design Pattern

**Observer Design Pattern**

1.  Observer design pattern should "Define a one-to-many dependency between objects so that when one object changes state, all 
    its dependents are notified and updated automatically"
2.  The two important key terms in the pattern are the Subject and the Observer.
    
    *  **Subject**: The Subject is the object which holds the value and takes responsibility in notifying the observers when 
                    the value is changed. The subject could be a database change, property change or so.
    *  **Observer**: The Observer is the object listening to the subject's change. Basically it will be having its own 
                     updating/calculating routine that runs when get notified.
3.  There will be only one Subject and multiple number of Observers.
4.  Observer Design Pattern falls under Behavioral Pattern

**UML diagram for the Observer Design Pattern**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/00059177a99f82531af196741aa499b6/Screenshot__116_.png)

The classes, interfaces, and objects in the above UML class diagram are as follows:

1.  **Subject**
This is a class that contains a private collection of the observers that are subscribed to a subject for notification by using Notify operation.

2.  **ConcreteSubject**
This is a class that maintains its own state. When a change is made to its state, the object calls the base class's Notify operation to indicate this to all of its observers.

3.  **Observer**
This is an interface which defines an operation Update, which is to be called when the subject's state changes.

4.  **ConcreteObserver**
This is a class that implements the Observer interface and examines the subject to determine which information has changed.

**Code Snippet**

1.  Subject Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/70ebedad15d1e2e46d8235bd0de54178/Subject.png)

2.  Concrete Subject Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/d38996ada1633e49824cd5577f7e55aa/ConcreteSubject.png)

3.  Observer Interface

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/d98b85f85fd669f4df709f4dec7a431e/Observer.png)

4.  Concrete Observer Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/55333be395abc0c2d2c80853cdc90c0b/ConcreteObserver.png)

5.  Main Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/949f0ee1c0f9f0cf1d0d43fbe006d444/MainClass.png)

**INPUT**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/ee3c95498bb2442225952001b9573bfe/Input.png)

**OUTPUT**
 
![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/a35de44573a8044d2b0367405e060313/Screenshot__118_.png)


Below Link is available for the above code Snippet
https://github.com/EzDevPrac/CSharp_Karan/tree/master/SportsShopObserverPattern

## Decorator Design Pattern

1.  A Decorator is a structural design pattern that allows us to extend the behavior of objects by placing these objects into 
    a special wrapper class. 
2.  The structure of this pattern consists of a Component class and a Concrete Component class from one part and a Decorator 
    class and a Concrete Decorator class on the other side. The Concrete Decorator class is going to add additional behavior 
    to our Concrete Component.
3.  Decorator pattern provides an alternative way to inheritance for modifying the behavior of an object.

**UML Diagram of the structure of the Decorator Design Pattern**


![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/a1cd09f4f686b36c1a0dcc67e3bdb857/Screenshot__108_.png)

The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.  Component**
     
This is an interface containing members that will be implemented by ConcreteClass and Decorator.

**2.  ConcreteComponent**

This is a class which implements the Component interface.

**3.  Decorator**

This is an abstract class which implements the Component interface and contains the reference to a Component instance. This class also acts as base class for all decorators for components.

**4.  ConcreteDecorator**

This is a class which inherits from Decorator class and provides a decorator for components.

**Code Snippet**

**1.  Component Interface**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/301c78936f4fdb9cd5048a22d795a8be/Component.png)

**2.  Concrete Component**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/fc9fd9e0df15408770b43fb0ddcff876/ConcreteComponent.png)

**3.  Decorator Class**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/61be91c748587fc837151860d9394ac2/Decorator.png)

**4. Concrete Decorator**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/fc5ed004271e5aa66b3ae41ca8f3dd7b/ConcreteDecorator.png)

**5.  Main Class**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/744ca6480b184c0fd6511233fe3df362/Screenshot__113_.png)

**INPUT**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/46bd0ab368f93078a735722dd2aae5bf/input.png)

**OUTPUT**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/73632082a378f659d333ec363128f96f/Output.png)

Code for the Above snippet is available in the following link

https://github.com/EzDevPrac/CSharp_Karan/tree/master/DecoratorPattern






## Singleton Design Pattern

1.  Ensures a class has only one instance and provides a global point of access to it.
2.  A singleton is a class that only allows a single instance of itself to be created and usually gives simple access to that 
    instance.
3.  Most commonly, singletons don't allow any parameters to be specified when creating the instance since the second request 
    of an instance with a different parameter could be problematic! (If the same instance should be accessed for all requests 
    with the same parameter then the factory pattern is more appropriate.)

**Implementation Singleton Pattern in your code**

There are many ways to implement a Singleton Pattern in C#.
1.  No Thread Safe Singleton.
2.  Thread-Safety Singleton.
3.  Thread-Safety Singleton using Double-Check Locking.
4.  Thread-Safe Singleton without using locks and no lazy instantiation.
5.  Fully lazy instantiation.


1. **No Thread Safe Singleton**
 
Explanation of the following code:
1.  The following code is not thread-safe.
2.  Two different threads could both have evaluated the test (if instance == null) and found it to be true, then both create 
    instances, which violates the singleton pattern.

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/17684ce5caeb237f5ac71ce431910a4e/Screenshot__95_.png)
![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/c65977e658dd95ac6dcc76212c6b4f60/Screenshot__94_.png)

So,the application will give you the following output.

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/804d45bc6e122017278167dc3633432d/Screenshot__96_.png)

2.  **Thread Safety Singleton**
 
Here, within the main method, we use Parallel.Invoke method to invoke multiple methods parallelly, This concept is introduced in .NET Framework 4.0. 

So in our example, we are using the Parallel.Invoke method to access the GetInstance property parallelly, means at the same time multiple threads are accessing the GetInstance property. The below code is not Thread-safe because the way we code here two different threads can evaluate the condition if (instance == null) at the same time and both the threads found it to be true and they both will create the instances, which violates the singleton design pattern.

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/8fb691befb8bf10ec009af6d0821877f/Screenshot__98_.png)

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/772ccd23bdb5e3b419cf1655e4e56765/Screenshot__97_.png)

So,the application will give you the following output.

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/d1d9cec28bde50098ca0cbbb148d12d6/Screenshot__99_.png)


3.  **Thread-Safety Singleton using Double-Check Locking**.

In the Double-checked locking mechanism, first, we will check whether the instance is created or not. If not then only we will synchronize the method as shown below.

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/7d994e8346b4c9a2dcfa2d95b25957e7/Screenshot__101_.png)

So,the application will give you the following output.

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/cf3a5d8c2aeb75cec3b4c1ec3c1a49c4/Screenshot__102_.png)

The below code is implemented using a singleton design pattern.
## Code Snippet

1.Singleton calculate Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/a86a92eea79c43eaa38a58bd0a919f89/Screenshot__106_.png)

2.Main Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/ba73e607ed85392e52b66c25593dfeec/Screenshot__105_.png)

Output of the above Code

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/ee4a55264eee10b0309ed4e22f299a49/Screenshot__103_.png)

Below the link for the working code for the above example is available

https://github.com/EzDevPrac/CSharp_Karan/tree/master/SingletonDesignPattern/CalculatorUsingSingleton






## FACTORY DESIGN PATTERN

1. Design patterns are all about reusable solutions for a common problem.
2. The 23 group of four are the foundation for the entire pattern
3. They are classified into 3 groups
     i) Creational
    ii) Structural
   iii) Behavioural
4. Factory pattern comes under the creational group.
   *  Factory method is a design pattern which defines interface for creating an object but lets
      the class that implementing the interface decide which class to instantiate
   *  Interfaces cannot have variables/fields , they can only have properties or methods.
   *  It provides the client with a simple way to create the object.

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/f7b5bf059d0970cb403b07a3abab7196/Screenshot__40_.png)

  1. Product: Define the interface of the object the factory method creates.
  2. Concrete Product: This is a class that implements the product interface
  3. Creator: An abstract class and it declares the factory methods which returns a object of
     type product.
  4. Concrete Creator: Implements the creator class and overrides the factory methods
  
 **Code Snippet**
1.  Product Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/f27fe9d985a6fd4e4fdfb4a6aaf62e7e/1.png)

2.  Concrete Product Class for Platinum card:

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/01ddd633bb0614cb1316f32c9c9ce4f3/2.png)

3.  Concrete Product Class for Titanium Card:

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/66a87ee8fed2b6a921df088ceabaac13/3.png)

4.  Creator Class 

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/e44271f429667d6bb703c382d88d226e/4.png)

5.  Concrete Creator class for the platinum card:

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/ac664f169b1eb66364092713a926fc61/5.png)

6.  Concrete Creator class for the Titanium Card

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/46328d8ac785d60ec77f807fa0bd9221/6.png)

7.  Driver Class for the program:

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/c07c44293ed72a8d6b9f071037825d9c/7.png)

**Input**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/671dbceab5b537339a35d5760ad251e3/8.png)

**Output**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/a55b05ae26edc20bf486138ab5af4200/9.png)

**Code Flow for the above given example**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/b1c3d79e48abbef4bf68135b77a9b823/Screenshot__41_.png)

**Below link is available for the Git to get the sample code**

https://github.com/EzDevPrac/CSharp_Karan/tree/master/CreditCard








## BUILDER DESIGN PATTERN:
*  This also falls under the category of creational design pattern.
*  This pattern is used to build complex object by using a step by step approach.
*  The main idea is **“Separate the construction of complex object from its representation so that the same construction 
    process can create different representation”.**


 
![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/e16472033e9f346c5c7336e173cbf45c/Builder_Pattern_Design.png)

1.  **Builder**: this is an interface which is used to define all the steps required to the product
2.  **Concrete Builder**: This is a class which implements the builder interface to create a complex product.
3.  **Product**: this is a class which defines the part of the complex object which are to be generated by the builder pattern
4.  **Director**: This is a class that is used to construct object using the builder interface.

**Code Snippet**

1.  Toy Builder Interface

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/6e9be32e53f72b46fc18a0519a342359/1.png)

2.  Product Class 

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/08ad58d6d976d09927cd9cafa08b4206/2.png)

3.  Concrete Builder for the Toy A 

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/aa1b44d85b4da2b91dc7e8831cc5f0bf/3.png)

4.  Concrete Builder for the Toy B

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/cb1b1414f3e845d44e17c4e1895d75ca/4.png)

5.  Director Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/b7d08a0e980845b5c1e38babea1f6c60/5.png)

6.  Main Class for the program

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/06dd027bb4147864e0a21117daad09c5/6.png)

**Output for the Code**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/414094ff110353c75830b40a7287b8be/7.png)


![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/784d4387951758f3cd71e2f606472b83/BuilderDesign_MYExample.png)


Example code link for the above prototype is given below.
https://github.com/EzDevPrac/CSharp_Karan/tree/master/BuilderPattern









## Command Design Pattern:


It falls under behavioral patter.
It is commonly used in the menu system of many applications such as Editor,IDE etc
In this pattern a request is wrapped under an object as a command and passed to invoker object . The invoker object pass the 
    command to the appropriate object which can handle it and that object executes the command.
*  UML diagram:

   ![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/af33d393607865a5993377b32246cf0e/Command_Uml.png)
1.  Client Class --> Creates and executes the command object
2.  Invoker  --> Asks the command to carry out the action
3.  Command --> This is an interface which specifies the execute operation
4.  Concrete Command --> Class that implements the execute operation by invoking on the receiver
5.  Receiver class --> Class that performs the Action Associated with the Request

**Code Snippet**

1.  command Interface

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/0e1abbf5b46023639111642731511d23/1.png)

2.  The invoker Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/504536550a3570313d48308759bc593b/2.png)

3.   The Reciever Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/1a6f0531798e3c80a4624bd42b44e273/3.png)

4.   Concrete Command for addition

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/cecb15fffd0d9571613fc275e9a5a471/4.png)


5.   Concrete Command for Subtraction

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/eb291df7b9bd61b809cda070fb09f42f/5.png)


6.   Driver Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/06dd027bb4147864e0a21117daad09c5/6.png)


**Input And Output**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/414094ff110353c75830b40a7287b8be/7.png)


![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/784d4387951758f3cd71e2f606472b83/BuilderDesign_MYExample.png)


**A working Prototype of the code is available in the following link**

 https://github.com/EzDevPrac/CSharp_Karan/tree/master/CommandPattern


## Facade Design Pattern

1.  Facade design pattern falls under the structural pattern of GOF.
2.  The Facade design pattern is particularly used when a system is very complex or difficult to understand because the system 
    has a large number of interdependent classes
3.  Facade pattern hides the complexities of the system and provides an interface to the client using which the client can 
    access the system.
4.  This pattern involves a single wrapper class which contains a set of members which are required by the client. These 
    members access the system on behalf of the facade client and hide the implementation details.
5.  The facade design pattern is particularly used when a system is very complex or difficult to understand because the system 
    has a large number of interdependent classes or its source code is unavailable.

**UML Diagram**


![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/4c5587d422918685353b89920bbe8ef7/Screenshot__89_.png)

The classes, interfaces, and objects in the above UML class diagram are as follows:


**Complex System**
A library of subsystems.

**SubsystemA, SubsystemB, SubsystemC**
These are classes within a complex system and offer detailed operations.

**Façade**
This is a wrapper class which wrapper class which contains a set of members which are required by the client.

**Client**
This is a class which calls the high-level operations in the Façade.

**Code Snippet**

1.  Subsystem Class for System Ram

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/ff0403e94749fe96201251b27d7e1702/Ram.png)

2.  Subsystem Class for System Processor

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/5fd729ac33ecab017a8ff6aa6c933417/Processor.png)

3.  Subsystem Class for System Capacity

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/73ecbd8afcf6edc994c66ea2835fa628/Capacity.png)

4.  Subsystem Class for the System Graphics

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/10aca8df2245daff5d9e38a7be4ed5aa/graphics.png)

5.  Subsystem Class for the System USB configuration

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/b137dba2c45fd2711813ca8115a1ba42/UAB.png)

6.  The Facade Class to create the System

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/8fd398e4bc6cbaf8da120cbc47f662ab/Facade.png)

7. The Main client Class

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/e17db8896aea446dd1e8594033058c33/Client.png)


**Input**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/3deaaff461e17ae9cd6f6279192c4bec/input.png)

**Output**

![](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/ffaa26d92cad6703fefe42b990fef013/output.png)

Below is the link for the working prototype of the above example

https://github.com/EzDevPrac/CSharp_Karan/tree/master/SystemConfigFacade






                                                                                     
 

