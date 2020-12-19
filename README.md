# AutoFixture Register Example


The Create methods are used to create auto generated variables and custom types using Reflection-based algorithm. In many cases, AutoFixture can automatically determine how to create an instance of a requested type, but in the case of, A required dependency or input is of a type that doesn't have a public constructor (such as an interface).

This is where AutoFixture would be unable to Create an instance because one or more of the dependent types don't have a public constructor in a situation where a class requires an interface instead of a concrete type, the Register method can be used to specify a custom delegate function that can create an instance that is compatible with that type taht is a concrete implementation of an interface.  

# Abstract Types

```C#
     fixture.Register<IMyInterface>(() => new FakeMyInterface());
     
```

In such cases, you could argue that AutoFixture acts as its own micro-Container, but that is not the general purpose to act as DI Container.
