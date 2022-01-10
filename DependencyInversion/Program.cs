//High Level components should not depend on low level components 

Console.WriteLine("Hello, World!");
var parent = new Person { Name = "John" };
var child1 = new Person { Name = "Chris" };
var child2 = new Person { Name = "Matt" };

// low-level module
var relationships = new Person.Relationships();
relationships.AddParentAndChild(parent, child1);
relationships.AddParentAndChild(parent, child2);

var research = new Person.Research(relationships);