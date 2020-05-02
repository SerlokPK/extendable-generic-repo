namespace extendable_generic_repo.Models.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
