Reflection:

1. Why did you use inheritance?
	- I used the inheritance so that the objects that share the common characteristics can reuse the code and polymorphism

2. Why did you use interface?
	- I used the interfaces to represent what an object can do, like how cars can drive and airplane fly. This allows different classes to share the same capabilities.

3. Could Helicopter inherit from both Vehicle and Airplane? Why or why not?
	- No they cannot, since C# doesn't support multiple inheritance classes

4.Why can Helicopter implement both IFLyable and IDriveable?
	- A class can be implemented by multiple interfaces in C#. This allows the helicopter to have both flying and driving while inheriting form only one base class.

5. If a Submarine can both sail and dive, how would you design it?
	- I would create a Submarine.cs that inherits from the Vehicle and create a new interface named IDiveable and implement both ISailable and IDivable interface to the Submarine class.
