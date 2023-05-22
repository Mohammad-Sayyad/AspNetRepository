namespace AspNetRepository.Repository
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
