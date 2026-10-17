
 IReadOnlyDictionary & SortedDictionary

what is each one :
1- IReadOnlyDictionary: is an interface in C# that represents a read-only collection of key-value pairs. It provides methods to access the values by their keys, but does not allow modification of the collection (no adding, removing, or updating elements). It is useful when you want to expose a dictionary-like structure without allowing the consumer to change its contents.
2- SortedDictionary: is a concrete implementation of the IDictionary<TKey, TValue> interface in C#. It represents a collection of key-value pairs that are sorted by the keys. The keys are stored in a sorted order, and the collection allows for adding, removing, and updating elements. It is useful when you need to maintain a sorted order of elements based on their keys.

how Is IReadOnlyDictionary Different From Dictionary  :
IReadOnlyDictionary is a read-only interface, meaning you can only read the elements but cannot modify them.
Dictionary is a concrete class that allows both reading and writing operations on the collection.

 How is SortedDictionary different from Dictionary in ordering and in lookup speed : 
 SortedDictionary maintains the elements in a sorted order based on the keys, while Dictionary does not guarantee any specific order of elements.

 when would you choose it : 
 i would choose SortedDictionary when i need to maintain a sorted order of elements based on their keys and when i want to provide a read-only view of the collection 
 and i would choose Dictionary when i don't need to sorted order of elements.


 Pick the Collection

  Find a student by national ID — thousands of times a day : 
  Collection : Dictionary
  Why : Because Dictionary provides O(1) average time complexity for lookups, making it efficient for frequent searches by key.

  Keep the tags of a course. The same tag must never be stored twice :
  Collection : HashSet
  Why : Because HashSet automatically handles uniqueness and provides O(1) average time complexity for adding and checking for existence, making it ideal for storing unique tags.

  Keep a student's grades in the order they were entered. The same grade can appear more than once :
  Collection : List
  Why : Because List maintains the order of elements and allows duplicates, making it suitable for storing grades in the order they were entered.

  A public method returns the course price list. Callers can read prices but must not add or change any :
  Collection : IReadOnlyDictionary
  Why : Because IReadOnlyDictionary provides a read-only view of the collection, allowing callers to access the prices without being able to modify them.

  A timetable keyed by session start time. Sessions are added at any moment, and it must always print in time order :
  Collection : SortedDictionary
  Why : Because SortedDictionary maintains the elements in a sorted order based on the keys (session start time), ensuring that the timetable is always printed in the correct order regardless of when sessions are added.

  A method returns results that the caller only loops over once — and may stop early :
  Collection : IEnumerable
  Why : Because IEnumerable allows for deferred execution and can be iterated over one element at a time, making it efficient for scenarios where the caller may stop early and does not need to store all results in memory.