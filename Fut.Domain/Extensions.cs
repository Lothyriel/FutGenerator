namespace Fut.Domain
{
    public static class Extensions
    {
        public static List<T> Randomize<T>(this List<T> list)
        {
            return list.OrderBy(_ => Random.Shared.Next()).ToList();
        }
    }
}