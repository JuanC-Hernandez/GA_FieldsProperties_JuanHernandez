namespace GA_FieldsProperties_JuanHernandez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car reserved_space1 = new Car();

            reserved_space1.Brand = "Toyota";

            Console.WriteLine(reserved_space1.Brand);

            Console.WriteLine(reserved_space1.ReadOnlyBrand);

            reserved_space1.WriteOnlyBrand = "Honda";

            Console.WriteLine(reserved_space1.Brand);
        }
    }
}