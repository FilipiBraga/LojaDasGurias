namespace LojaDasGurias.IoC.Assembly
{
    public class AssemblyInfo
    {
        public static IEnumerable<System.Reflection.Assembly> GetAssemblies()
        {
            return new System.Reflection.Assembly[]
            {
                System.Reflection.Assembly.Load("LojaDasGurias.Api"),
                System.Reflection.Assembly.Load("LojaDasGurias.Application"),
                System.Reflection.Assembly.Load("LojaDasGurias.Domain"),
                System.Reflection.Assembly.Load("LojaDasGurias.IoC"),
                System.Reflection.Assembly.Load("LojaDasGurias.Infrastructure")
            };
        }
    }
}
