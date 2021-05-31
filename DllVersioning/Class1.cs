using System.Reflection;

namespace DllVersioning
{
    public class Class1
    {
        public string GetVersionNumber()
        {
            return Assembly.GetExecutingAssembly().FullName;
        }
    }
}
