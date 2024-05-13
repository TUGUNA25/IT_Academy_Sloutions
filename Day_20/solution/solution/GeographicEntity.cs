namespace solution
{
    abstract class GeographicEntity
    {
        public string Name;

        public GeographicEntity(string name)
        {
            Name = name;
        }

        public abstract void ShowInstance();

    }
}
