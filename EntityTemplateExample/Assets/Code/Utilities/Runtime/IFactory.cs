namespace Code.Utilities.Runtime
{
    public interface IFactory<in TIn, out TOut>
    {
        TOut Create(TIn data);
    }
}