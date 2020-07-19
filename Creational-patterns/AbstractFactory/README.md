## Abstract Factory

> Creates an instance of several families of classes

### Problem

If an **application is to be portable**, it needs to encapsulate platform dependencies. <br>
Too often, this encapsulation is not engineered in advance, and lots of #ifdef case statements with options for all currently supported platforms begin to procreate

### Theory

- Provide a level of indirection that abstracts the creation of families of related or dependent objects `without directly specifying their concrete classes`.
- The `"factory" object has the responsibility for providing creation services` for the entire platform family. Clients never create platform objects directly, they ask the `factory to do that for them`.
- This mechanism makes exchanging product families easy because the `specific class of the factory object appears only once in the application - where it is instantiated.` The application can wholesale `replace the entire family of products simply by instantiating a different concrete instance of the abstract factory`.
