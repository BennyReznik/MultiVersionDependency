using DllVersioning;

namespace SecondDependency
{
    public class Class2
    {
        private readonly Class1 _c1 = new Class1();

        public string GetAnotherVersion()
        {
            return _c1.GetVersionNumber();
        }
    }
}
