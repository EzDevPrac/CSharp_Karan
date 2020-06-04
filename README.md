# C-Sharp Project Karan 
[![Build Status](https://dev.azure.com/karan1198kumar/MyCsharpProjectJKT/_apis/build/status/EzDevPrac.CSharp_Karan?branchName=master)](https://dev.azure.com/karan1198kumar/MyCsharpProjectJKT/_build/latest?definitionId=1&branchName=master)

# Web API

API is some kind of interface which has a set of funtions that allows programmers to acess specific features or data of an application,OS or other services. or we can also say it as a set of subroutine defination , protocols and tools for building software and application.

**Web API** is an API over the web which can be accessed using HTTP protocol.

**Model** : Set of classes that represents the data that the application manages.

**REST API's**

1.  Representational state transfer Application Progrgramming Interface.
2.  API that uses http request to GET/PUT/POST/DELETE etc .
3.  REST technology is generally preferred over the Simple object Access Protocol(SOAP),it uses less bandwidth.
4.  Its Stateless( i.e there is nomrecord of the previous interaction and each interaction request has to be handled based entirely on the 
    information  that comes with it ).
5.  **SOAP**: Developer handwrite the XML document with Remote Procedure Call(RPC) in the body.They than specify the end point and post 
    their SOAP envelop the endpoint.
6.  Rest API tend to deliver JSON or XML data.

**Some of the main HTTP Methods of the RESt API**
1.  GET : Get all the required data(GET/API/ToDOItem or GET/API/ToDoItem/{Id}(get data based on id)).
2.  POSt: Add new data(POST/API/todoItem.)
3.  PUT : Update an existing item(PUT/API/ToDoItem/{Id}).
4.  DELETE: Delete an Item(DELETE/API/ToDoItem/{id}).  

Code for the above Code snippet is available in the following link
https://github.com/EzDevPrac/CSharp_Karan/tree/master/WebApiDemo



# Dependency Injection
1.  It is a software design pattern which enables the developement of loosely coupled code
2.  Three types of DI's
    -->Constructor injection
    -->Setter Injection
    -->Method Injection
3.  High level modules should not depend on low level module,Both should depend on abstraction.
4.  Abstraction should not depend upon details.details should depend upon abstarction.

**Code Snippent**

1.  Module Builder Class Which registers the dependencies

```C Sharp
using System;
using Autofac;

namespace DependencyInjection
{
    public class ModuleBuilder : Module
    {
       protected override void Load(ContainerBuilder builder)
       {
        builder.RegisterType<ConsoleNotification>().As<INotificationService>();
        builder.RegisterType<UserService>().AsSelf();
       }

    }
}

```
2.  Notification Sevice Interface

```C Sharp
using System;

namespace DependencyInjection
{
    public interface INotificationService
    {
    void NotifyUserChange(string User);
    }
}
```
3.  Console notification class which implements the Notification Service

```C Sharp
using System;

namespace DependencyInjection
{
    public class ConsoleNotification : INotificationService
    {

     public void NotifyUserChange(string NewUser)
     {
         Console.WriteLine("User Name has been changed to  " + NewUser);

     }   
    }
}
```

4.  User Service Class

```C Sharp

using System;

namespace DependencyInjection
{
    public class UserService
    {
       private INotificationService _INotificationService;

       public UserService(INotificationService notifcationService)
       {
           _INotificationService = notifcationService;
       }
        public void ChangeUserName(User OldUserName, string newUserName)
        {
           OldUserName.UserName = newUserName;
           _INotificationService.NotifyUserChange(OldUserName.UserName);

        }
    
        
    }
}

```

5.  User Class which is independent

```C Sharp

using System;

namespace DependencyInjection
{
    public class User
    {
        public string UserName{get;set;}
        public User(string userName )
        {
               UserName = userName;
               }
        }
}

```
6.  Main Class which shows how the dependency injection is done

```C Sharp

using System;
using Autofac;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var ContainerBuilder = new ContainerBuilder();
            ContainerBuilder.RegisterModule<ModuleBuilder>();
            var container = ContainerBuilder.Build();
            var notificationService = container.Resolve<INotificationService>();
            var UserService = container.Resolve<UserService>();
              
            var user1 = new User("Karan");
            UserService.ChangeUserName(user1,"Karan Kumar");
         }
    }
}

```
Working code for the above snippet is available in the following link

https://github.com/EzDevPrac/CSharp_Karan/tree/master/DependencyInjection



# DESIGN PATTERN

## Adapter Design Pattern

1.  Adapter design pattern falls under structural design pattern category of Gang of four (GoF) design patterns.
2.  Adapter design pattern enables a system to use classes of another system that is incompatible with each other.
3.  Adapter design pattern allows a system to use classes whose interfaces are mutually incompatible. Adapter design pattern provides    
    the bridge or connection between these mutually incompatible interfaces. This pattern is useful for off-the-self code, toolkits and libraries.

**UML DIAGRAM**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/AdapterDesignPattern/UML.png)
Client and Adaptee classes are incompatible with each other. Client calls ITarget interface to achieve functionality of Adaptee class.

Participants in above UML diagram are:

**1.  Client:** This is the class which is incompatible with Adaptee class but wants to use Adaptee class code

**2.  ITarget:** The interface that client class uses to achieve Adaptee class functionality.

**3.  Adapter:** This class implements ITarget interface; this class also calls Adaptee class functionality inside.

**4.  Adaptee:** This is the class which Client class want to use.

**Code Snippet**

**1.  Target Interface**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/AdapterDesignPattern/Target.png)

**2.  Adapter Class**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/AdapterDesignPattern/Adapter.png)

**3.  Adaptee Class**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/AdapterDesignPattern/Adaptee.png)


**4.  Client Class**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/AdapterDesignPattern/Client.png)


**5. Main Class**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/AdapterDesignPattern/MainCalss.png)


**Output**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/AdapterDesignPattern/output.png)


Code for the above Code snippet is available in the following link
https://github.com/EzDevPrac/CSharp_Karan/tree/master/AdapterDesignPatttern


## Proxy Design Pattern

1.  Proxy Design pattern falls under Structural Pattern of Gang of Four (GOF) Design Patterns
2.  The proxy design pattern is used to provide a surrogate object, which references to other objects. 
3.  The proxy pattern involves a class, called proxy class, which represents the functionality of another class.


**UML Diagram**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Proxy%20Pattern/UML.png)

The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.  Subject**
This is an interface having members that will be implemented by RealSubject and Proxy class.

**2.  RealSubject**
This is a class which we want to use more efficiently by using proxy class.

**3.  Proxy**
This is a class which holds the instance of RealSubject class and can access RealSubject class members as required.


**There are various kinds of proxies, some of them are as follows:**

1.  Virtual proxies: Hand over the creation of an object to another object

2.  Authentication proxies: Checks the access permissions for a request

3.  Remote proxies: Encodes requests and send them across a network

4.  Smart proxies: Change requests before sending them across a network


**Code Snippet**

1.  Bank Interface

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Proxy%20Pattern/IBank.png)

2.  Bank Class That Implements  Bank

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Proxy%20Pattern/Bank1.png)

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Proxy%20Pattern/Bank2.png)

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Proxy%20Pattern/Bank3.png)

3.  Atm Class(Proxy)

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Proxy%20Pattern/Atm.png)

4.  Client Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Proxy%20Pattern/Client.png)

**OUTPUT**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Proxy%20Pattern/output.png)


Code for the above code snippet is available in the following link

https://github.com/EzDevPrac/CSharp_Karan/tree/master/ProxyDesignPattern


## Abstract Factory Design Pattern

1.  The Abstract Factory Pattern is a creational Gang of Four (GoF) design pattern
2.  The Abstract Factory Pattern is used when you want to return several related classes of objects, each of which can return several   
    different objects on request
3.  Abstract Factory patterns act a super-factory which creates other factories. This pattern is also called a Factory of factories. In  
    Abstract Factory pattern an interface is responsible for creating a set of related objects, or dependent objects without specifying their concrete classes.

**UML Diagram**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Uml.png)


The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.  AbstractFactory**
This is an interface which is used to create abstract product

**2.  ConcreteFactory**
This is a class which implements the AbstractFactory interface to create concrete products.

**3.  AbstractProduct**
This is an interface which declares a type of product.

**4.  ConcreteProduct**
This is a class which implements the AbstractProduct interface to create a product.

**5.  Client**
This is a class which uses AbstractFactory and AbstractProduct interfaces to create a family of related objects.


**Code Snippet**

1.  Abstract Factory

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Vehicle%20Factory.png)

2.  Concrete Abstract Factory for BMW Vehicles

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Bmw%20Vehicles.png)

3.  Concrete Abstract Factory for Ducati Vehicales

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Ducati%20Vehicle.png)

4.  Vehicle Client

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/VehicleClient.png)

5.  Abstract Product For Two Wheelers

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Two%20Wheeler.png)

6.  Concrete Product for Regular Two Wheelers

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Reagular%20Bike.png)

7.  Concrete Product for Sports Two Wheelers

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Sports%20Bike.png)

8.  Abstact Product For Four Wheelers

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Four%20Wheeler.png)

9.  Concrete Product for Sports Four Wheelers

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Sports%20car.png)

10.  Concrete Product for Regular Four Wheelers

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Reagular%20car.png)

11.  Main Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/Main%20Class.png)


**OUTPUT**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Abstract%20factory/output.png)

Code for the above code snippet is avaikable in the following link

https://github.com/EzDevPrac/CSharp_Karan/tree/master/AbstractDesignPattern



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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/UMl%20Diagram.png)
Participants in above UML diagram are:

**1.  IPrototype**: Interface that is used for the Prototypes (objects) to clone itself

**2.  ConcretePrototype1, ConcretePrototype2**: Implements IPrototype interface

**3.  Client:** Client class will make clones of different objects


**Code Snippet**

**1.  Prototype Interface**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/Prototype.png)

**2.  Student Concrete Prototype**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/Student.png)

**3.  Employee Concrete Prorotype**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/Employee.png)

**4.  Client**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/Client.png)

**Output**


![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Prototype%20Pattern/Output.png)

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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Iterator%20Pattern/Screenshot%20(132).png)

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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Iterator%20Pattern/Aggregate.png)

2.  Collection Class

![]()

3.  Concrete Aggregate

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Iterator%20Pattern/ConcreteAggregate.png)

4.  Iterttor

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Iterator%20Pattern/Iterrator.png)


5.  Concrete Itterator

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Iterator%20Pattern/ConcreteItterstor.png)


6.  Main Menu

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Iterator%20Pattern/MainMenu.png)


**OUTPUT**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Iterator%20Pattern/output.png)


Link for the example code for the above code snippet

https://github.com/EzDevPrac/CSharp_Karan/tree/master/IceCreamShopItteratorPattern


## Strategy Design Pattern

1.  Strategy Design Pattern falls under Behavioral Pattern.
2.  This pattern allows a client to choose an algorithm from a family of algorithms at run-time and gives it a simple   
    way to access it.
3.  Strategy Design Pattern involves the removal of an algorithm from its host class and putting it in a separate 
    class. As you know, there may be multiple strategies which are applicable for a given problem.

**UML diagram for the Strategy Design Pattern  is given Below**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Strategy%20Pattern/Screenshot%20(124).png)

The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.  Context**
This is a class that contains a property to hold the reference of a Strategy object. This property will be set at run-time according to the algorithm that is required.

**2.  Strategy**
This is an interface that is used by the Context object to call the algorithm defined by a ConcreteStrategy.

**3.  ConcreteStrategyA/B**
These are classes that implement the Strategy interface.

**CODE SNIPPET**

1.  Strategy Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Strategy%20Pattern/Strategy.png)

2.  Concrete Strategy class for PhonePe

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Strategy%20Pattern/Concrete%20phonepay.png)

3.  Concrete Strategy Class for Paytm

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Strategy%20Pattern/Concrete%20Paytm.png)

4.  Concrete Strategy Class for Google pay

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Strategy%20Pattern/Concrete%20google%20pay.png)

5.  Context class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Strategy%20Pattern/Context.png)

6.  Main Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Strategy%20Pattern/MainClass.png)

**INPUT AND OUTPUT**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Strategy%20Pattern/Output.png)

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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Observer%20Pattern/Screenshot%20(116).png)

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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Observer%20Pattern/Subject.png)

2.  Concrete Subject Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Observer%20Pattern/ConcreteSubject.png)

3.  Observer Interface

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Observer%20Pattern/Observer.png)

4.  Concrete Observer Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Observer%20Pattern/ConcreteObserver.png)

5.  Main Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Observer%20Pattern/MainClass.png)

**INPUT**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Observer%20Pattern/Input.png)

**OUTPUT**
 
![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Observer%20Pattern/Screenshot%20(118).png)


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


![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Decorator%20pattern/Screenshot%20(108).png)

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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Decorator%20pattern/Component.png)

**2.  Concrete Component**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Decorator%20pattern/ConcreteComponent.png)

**3.  Decorator Class**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Decorator%20pattern/Decorator.png)

**4. Concrete Decorator**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Decorator%20pattern/ConcreteDecorator.png)

**5.  Main Class**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Decorator%20pattern/Screenshot%20(113).png)

**INPUT**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Decorator%20pattern/input.png)

**OUTPUT**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Decorator%20pattern/Output.png)

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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/NoThreadSafe/Screenshot%20(95).png)

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/NoThreadSafe/Screenshot%20(94).png)

So,the application will give you the following output.

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/NoThreadSafe/Screenshot%20(96).png)

2.  **Thread Safety Singleton**
 
Here, within the main method, we use Parallel.Invoke method to invoke multiple methods parallelly, This concept is introduced in .NET Framework 4.0. 

So in our example, we are using the Parallel.Invoke method to access the GetInstance property parallelly, means at the same time multiple threads are accessing the GetInstance property. The below code is not Thread-safe because the way we code here two different threads can evaluate the condition if (instance == null) at the same time and both the threads found it to be true and they both will create the instances, which violates the singleton design pattern.

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/ThreadSafe/Screenshot%20(98).png)

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/ThreadSafe/Screenshot%20(97).png)

So,the application will give you the following output.

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/ThreadSafe/Screenshot%20(99).png)


3.  **Thread-Safety Singleton using Double-Check Locking**.

In the Double-checked locking mechanism, first, we will check whether the instance is created or not. If not then only we will synchronize the method as shown below.

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/ThreadSafeWithDoubleCheckLock/Screenshot%20(101).png)

So,the application will give you the following output.

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/ThreadSafeWithDoubleCheckLock/Screenshot%20(102).png)

The below code is implemented using a singleton design pattern.

## Code Snippet

1.Singleton calculate Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/Calculator/Screenshot%20(106).png)

2.Main Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/Calculator/Screenshot%20(105).png)

Output of the above Code

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Singleton/Calculator/Screenshot%20(103).png)

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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Credit%20card/1.png)

2.  Concrete Product Class for Platinum card:

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Credit%20card/2.png)

3.  Concrete Product Class for Titanium Card:

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Credit%20card/3.png)

4.  Creator Class 

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Credit%20card/4.png)

5.  Concrete Creator class for the platinum card:

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Credit%20card/5.png)

6.  Concrete Creator class for the Titanium Card

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Credit%20card/6.png)

7.  Driver Class for the program:

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Credit%20card/7.png)

**Input**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Credit%20card/8.png)

**Output**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Credit%20card/9.png)

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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Builder%20Design/1.png)

2.  Product Class 

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Builder%20Design/2.png)

3.  Concrete Builder for the Toy A 

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Builder%20Design/3.png)

4.  Concrete Builder for the Toy B

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Builder%20Design/4.png)

5.  Director Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Builder%20Design/5.png)

6.  Main Class for the program

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Builder%20Design/6.png)

**Output for the Code**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Builder%20Design/7.png)


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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Command%20Pattern/1.png)

2.  The invoker Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Command%20Pattern/2.png)

3.   The Reciever Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Command%20Pattern/3.png)

4.   Concrete Command for addition

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Command%20Pattern/4.png)


5.   Concrete Command for Subtraction

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Command%20Pattern/5.png)


6.   Driver Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Command%20Pattern/6.png)


**Input And Output**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Command%20Pattern/input.png)


![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/Command%20Pattern/output.png)

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


![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/facade%20Pattern/Screenshot%20(89).png)

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

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/facade%20Pattern/Ram.png)

2.  Subsystem Class for System Processor

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/facade%20Pattern/Processor.png)

3.  Subsystem Class for System Capacity

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/facade%20Pattern/Capacity.png)

4.  Subsystem Class for the System Graphics

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/facade%20Pattern/graphics.png)

5.  Subsystem Class for the System USB configuration

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/facade%20Pattern/UAB.png)

6.  The Facade Class to create the System

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/facade%20Pattern/Facade.png)

7. The Main client Class

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/facade%20Pattern/Client.png)


**Input**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/facade%20Pattern/input.png)

**Output**

![](https://github.com/KaranKumar1927/Code-ScreenShots/blob/master/Code%20ScreenShots/facade%20Pattern/output.png)

Below is the link for the working prototype of the above example

https://github.com/EzDevPrac/CSharp_Karan/tree/master/SystemConfigFacade






                                                                                     
 

