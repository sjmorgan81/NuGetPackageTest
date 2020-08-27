namespace NuGetPackageTest
{
    public static class Foo
    {
        public static int Add(int a, int b)
        {
            System.Console.WriteLine($"Adding {a} + {b}...");
            return a + b;
        }
    }
}