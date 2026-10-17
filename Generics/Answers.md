
Step 2 — A store for courses

 what is the same between the two stores ?
 The similarity between the two stores is that they both have same methods (add , remove, getbyid, getall).

 what is different ?
 The difference between the two stores is that they have a different datatype for methods and lists.


 Step 3 — One class for both

 In Main Method :
 when you try to use the generic type Store<T> without specifying a type argument, you will encounter the error message: 
 Using the generic type Store<T> requires 1 type arguments
 Explaination: This error occurs because Store<T> is a generic class that requires a specific type to be provided when it is used.'.

 In Store<T> class :
 when you try to use the generic type Store<T> without specifying a type argument, you will encounter the error message:
 T does not contain a definition for 'Id' and no accessible extension method Id accepting a first argument of type T could be found (are you missing a using directive or an assembly reference?
 Explaination : This error occurs because the generic type parameter T does not have a constraint that ensures it has an Id property.

 Step 7 — Prove it in Main

  new Store<string>()        Must NOT compile:
  Explanation: This will not compile because the generic type parameter T is constrained to types that have an Id property, and string does not have an Id property.