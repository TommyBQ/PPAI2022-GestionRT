namespace PPAIGestionRecursosTecno2022
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> Insert(T entity);
        List<T> Update(T entity);
        List<T> Delete(int id);
    }
}
