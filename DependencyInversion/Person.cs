public class Person
{
    public string Name { get; set; }

    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    public class Relationships : IRelationshipBrowser // low-level
    {
        private List<(Person, Relationship, Person)> relations = new();

        public List<(Person, Relationship, Person)> Relations => relations;

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations
                .Where(x => x.Item1.Name == name
                            && x.Item2 == Relationship.Parent).Select(r => r.Item3);
        }

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }
    }

    public class Research
    {
        public Research(Relationships relationships)
        {
            // high-level: find all of john's children
            //var relations = relationships.Relations;
            //foreach (var r in relations
            //  .Where(x => x.Item1.Name == "John"
            //              && x.Item2 == Relationship.Parent))
            //{
            //  WriteLine($"John has a child called {r.Item3.Name}");
            //}
        }

        public Research(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {p.Name}");
            }
        }
    }
}