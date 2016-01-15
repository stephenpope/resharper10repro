using Thing.Abstractions;

namespace Thing
{
    public class Thing : IDoSomething
    {
        public string DoThing()
        {
            return "Hello !";
        }
    }
}
