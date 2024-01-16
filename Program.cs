namespace GA_FieldsProperties_JuanHernandez
{
    internal class Program
    {
        // Juan Hernandez
        // Guided Assignment: Fields and Properties
        // 01/15/2024
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