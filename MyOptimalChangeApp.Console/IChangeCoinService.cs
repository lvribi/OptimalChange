namespace MyCoinChange
{
    public interface IChangeCoinService
    {
        Change OptimalChange(long change);
    }
}
