# Problems
- C# conventions: GetDescription should be called Speak or something, "Get" implies this should be a Property instead.

# To remember
- A child class does not have to override virtual methods from the parents whereas implementing an interface requires defining ALL of the interface members.

# Interfaces VS abstract classes
They are very similar. I could create the AnimalFarm project where Animal is abstract.

Both cannot be instanciated and require implementers / children to override / implement certain members.

There seem to be the indication of a subtle performance difference in that **interfaces are slower**.

Other differences being:
- An abstract class can have actual code / method implementations, interfaces only have signatures
- Inheritance (and thus abstract classes) conveys a special meaning - Only one base class can be inherited
- All interface members are public, abstract members can have the other accessibility flavors


# TODO
We can also override ToString at some point.
-> Find methods that do use ToString and expect it to be overriden.
-> We could just use a list of object in the Farm class and call ToString, that would be the ultimate generification.
  - Make a new Farm class that inherits from the other: we can just replace the instanciation in Program.cs.
