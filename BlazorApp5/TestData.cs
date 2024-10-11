namespace BlazorApp5
{
    public class TestData(int id, string name)
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
    }
}
