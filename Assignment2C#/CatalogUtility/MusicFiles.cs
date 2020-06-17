namespace CatalogUtility
{
    public class MusicFiles : Movies
    {
        private string Singer;

        private double Length;

        public double Length1 { get => Length; set => Length = value; }
        public string Singer1 { get => Singer; set => Singer = value; }

        public override void Play(){}

        public override void RetrieveInfo(){}
    }
}