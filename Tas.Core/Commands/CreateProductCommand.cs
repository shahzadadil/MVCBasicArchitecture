namespace Tas.Core.Commands
{
    public class CreateProductCommand : ICommand
    {
        public CreateProductCommand(string name, double price, int username)
        {
            Name = name;
            Price = price;
            Username = username;
        }

        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Username { get; private set; }
    }
}
