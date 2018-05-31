# SOLIDAsARock

Open/Closed principle of SOLID
The Open/Closed principle of SOLID states that software entities (classes, modules, functions, etc) should be open for extension, 
but closed for modification. Meaning that when you are extending software, you should not have to go digging around in its 
internals just to change its behaviour. You should be able to extend it by adding to it with new functionality w/o needing to 
change existing code, and this can be achieved by relying on abstractions...interfaces & abstract based classes.

                          ******************************************************

In my example, the business initally asks for the area of a rectangle. Easy enough. Create a class that calculates the area 
of a rectangle. Later on, the business decides that they need to know the area of a circle as well, so you add an if/else 
statement to your existing class, and capture the area of each of these shapes. However, this does not follow the open/closed 
principle which states that code is open to extension, but closed to modification (of the original code). By having the area of 
two different shapes calculated in one class, you have modified the existing logic of the code.

In order to resolve this, I created an abstract class called "Shape". Then I created a separate class each for Rectangle and 
Circle; each of these implements the Shape class. The Rectangle class now has the logic to calculate the area for a rectangle, 
and the Circle class has the logic to calculate the area for a circle. Now, the AreaCalculator class calls on the Shape class 
which is implemented by each of the various shape classes (circle, rectangle) to calculate and output the area of each specific 
shape type.

                          *****************************************************

Files you will need to open to see my examples: Shape.cs, Circle.cs, Rectangle.cs, AreaCalculator.cs

From <https://github.com/Aimzilla/SOLIDAsARock> 
