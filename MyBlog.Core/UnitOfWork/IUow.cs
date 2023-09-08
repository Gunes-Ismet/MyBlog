namespace MyBlog.Core.UnitOfWork
{
    public interface IUow
    {
        Task CommitAsync();
        void Commit();
    }
}
