public interface ISpecification<in T>
{
    bool IsSatisfied(T t);
}