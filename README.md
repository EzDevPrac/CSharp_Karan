# C-Sharp Project Karan 
[![Build Status](https://dev.azure.com/karan1198kumar/MyCsharpProjectJKT/_apis/build/status/EzDevPrac.CSharp_Karan?branchName=master)](https://dev.azure.com/karan1198kumar/MyCsharpProjectJKT/_build/latest?definitionId=1&branchName=master)

**FACTORY DESIGN PATTERN**

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

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/f7b5bf059d0970cb403b07a3abab7196/Screenshot__40_.png)

  1. Product: Define the interface of the object the factory method creates.
  2. Concrete Product: This is a class that implements the product interface
  3. Creator: An abstract class and it declares the factory methods which returns a object of
     type product.
  4. Concrete Creator: Implements the creator class and overrides the factory methods

