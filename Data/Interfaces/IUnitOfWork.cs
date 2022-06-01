namespace unit_of_work.Data.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();

        void Rollback();
    }
}