namespace Exercise1.Models
{
    public class App
    {
        public string Name { get; set; }
        public float Size { get; set; }

        public App(string name, float size){
            this.Name = name;
            this.Size = this.Size + size;
        }
    }
}