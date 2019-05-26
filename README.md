# Abstract Factory
Simple example of abstract factory
 The definion of abstract factory says 
 
 "Provide an interface for creating families of related or dependent objects without specifying their concrete classes."
 
 
 In my own words, I can say, it help you to identify how the object are going to interact each other, also give you to indentify
 where to put the property, also decouple the "how the object realted each other".
 
     The classes and objects participating in this pattern are:

AbstractFactory  ContinentFactory
<br>
-declares an interface for operations that create abstract products
<br>
ConcreteFactory   (AmericaFactory, EuropeanFactory)
<br>
-implements the operations to create concrete product objects
<br>
AbstractProduct   (Product, RegionCLient)
<br>
-declares an interface for a type of product object
<br>
Product  (AmericaMovies, AmericaRegion,EuropaRegion,EuropeanMovies)
<br>
-defines a product object to be created by the corresponding concrete factory
<br>
-implements the AbstractProduct interface
<br>
Client  (DeliveryCenter)
<br>
uses interfaces declared by AbstractFactory and AbstractProduct classes

 
