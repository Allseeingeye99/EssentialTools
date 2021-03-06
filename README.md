![build](https://img.shields.io/badge/build-passing-36E700?style=plastic&logo=appveyor)
![license](https://img.shields.io/badge/license-Mit-green?style=plastic)
![Ninject](https://img.shields.io/badge/Ninject-v3.0.1.10-D54AEB?style=plastic&logo=github)
![.Net](https://img.shields.io/badge/.Net-passing-2035EB?style=plastic&logo=github)
![Nuget](https://img.shields.io/badge/nuget-2.3.0-36D5E7?style=plastic&logo=)


# Essential Tools
___
## Description
___
This project was created when adding a unit test, or it will be installed automatically when using the ***MVC*** project template. A test fixture is a ***C #*** class that defines a set of test methods, one for each behavior that needs to be tested. A test project can contain many classes of test fixtures.
A class named ***AdminController*** was also created, which defines a ***ChangeLoginName*** method that allows imaginary users to change their passwords. For this demo, the classes are created in a new ***Visual Studio*** project called ***TestingDemo:***
___
## Technologies

- ASP.NET MVC 5
- C#
___
## Functionality Ninject:
 - #### Dependency Chain Recognition
  In the case of a request for a component that has its own dependencies (for example, constructor parameters), the container will satisfy those dependencies as well. Thus, if the constructor of the ***MyEmailSender*** class requires an implementation of the ***INetworkTransport*** interface, then the ***DI*** container will create an instance of the standard implementation of this interface, pass it to the ***MyEmailSender*** constructor, and return the result as a standard ***IEmailSender*** implementation.
  - #### Object lifecycle management
  If a component is requested more than once, should the same or a completely new instance be issued each time? A good ***DI*** container allows you to configure the lifecycle of a component by providing a choice of predefined options: single instance (same instance in all cases), short-lived instance (new instance in each case), instance per stream, instance per ***HTTP*** request, an instance from the pool, etc.
  - #### Configuring constructor parameter values
  Writing your own ***DI*** container is a great way to understand how ***C #*** and ***.NET*** handle types and reflection. Building a robust, robust, and high-performance DI container is difficult and requires you to choose a tested package to use.
  ___
  ### Adding Ninject to a Visual Studio Project

  Install-Package ***Ninject -version 3.0.1.10***

  Install-Package ***Ninject.Web.Common -version 3.0.0.7***

  Install-Package ***Ninject.MVC3 -Version 3.0.0.6***
___
 ### Scope Methods in Ninject


 |Method              |                     Description 
 |--------------------|------------------------------------------------------------------
 |***InTransientScope()***  |  Same as not specifying a scope and creates a new object for each       recognized dependency|                                                           
 |***InSingletonScope()***  |  Creates a single instance that is shared throughout the application. The core Ninject will instantiate if the InSingletonScope () method is used, or the instance can be provided via the ToConstant () method  
 |***InThreadScope()***    |  Creates a single instance that is used to recognize the dependencies of objects requested in a single thread 
 |***InRequestScope()***   |  Creates a single instance that is used to recognize the dependencies of objects requested in a single HTTP request
 
 ___
 ### Testing
 - ***Unit testing***
  The goal in this section is to write a unit test for the functionality provided by the ChangeLoginName () method of the AdminController class:
  - ***Using Test Driven Development and Workflow Type (red-green-refactor)***
  C???????????????????????????? ???????????????????????????????????? ????????????????:
  -  Determine that the application needs to add a new functionality or method.
  -  Create a test that verifies the behavior of the new functionality after it has been implemented.
  -  Run the test and get a "red light".
  -  Write code that implements the new functionality.
  -  Run the test again and adjust the code until there is a green light.
  -  If necessary, refactor the code - for example, reorganize operators, rename variables, etc.
  - Run a test to make sure refactoring did not change the behavior of the additions.
  
 - ***Integration testing***
 For web applications, the most common approach to integration testing is UI automation. This term refers to the emulation or automation of a web browser in order to explore the entire technology stack of an application by reproducing actions that a user would have to perform, such as clicks on buttons, following links, and submitting forms.
 Two of the most well-known open source browser automation tools available to .NET developers are:
 - ***SeleniumHQ***, which consists of a "server-side" Java application that can send automation commands to Internet Explorer browsers. Firefox, Safari and Opera, as well as clients for .NET, Python, Ruby, and several other platforms, allowing you to write test scripts in the language of your choice. Selenium technology is powerful and mature; the only drawback is the need to run its Java server.
 - ***WatiN*** is a .NET library that can send automation commands to Internet Explorer and Firefox browsers. Its API offers a smaller set of features than Selenium, but it allows you to conveniently work with the most common scenarios, and is also easy to install. All you need is a link to a single dynamic link library.
 - Integration testing serves as an ideal complement to unit testing. While unit testing is well suited for testing the behavior of individual components on a server, integration testing allows you to create tests that are client-centric by re-creating user actions.
