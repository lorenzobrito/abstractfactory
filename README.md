# abstractfactory
Simple example of abstract factory
 The definion of abstract factory says 
 
 "Provide an interface for creating families of related or dependent objects without specifying their concrete classes."
 
 
 In my own words, I can say, it help you to identify how the object are going to interact each other, also give you to indentify
 where to put the property, also decouple the "how the object realted each other".
 
     The classes and objects participating in this pattern are:

AbstractFactory  ContinentFactory
-declares an interface for operations that create abstract products

ConcreteFactory   (AmericaFactory, EuropeanFactory)
-implements the operations to create concrete product objects
AbstractProduct   (Product, RegionCLient)
-declares an interface for a type of product object
Product  (AmericaMovies, AmericaRegion,EuropaRegion,EuropeanMovies)
-defines a product object to be created by the corresponding concrete factory
-implements the AbstractProduct interface
Client  (DeliveryCenter)
uses interfaces declared by AbstractFactory and AbstractProduct classes

 
