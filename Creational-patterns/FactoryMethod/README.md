# Factory Method

> Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

## Problem

A framework needs to standardize the architectural model for a range of applications, but allow for `individual applications to define their own domain objects and provide for their instantiation`.

### Theory

- Factory Method makes a `design more customizable and only a little more complicated`. Other design patterns require new classes, whereas Factory Method only requires a new operation.
