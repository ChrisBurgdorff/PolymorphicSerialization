// See https://aka.ms/new-console-template for more information
using SerializationTest;
using System.Text.Json;

Console.WriteLine("Hello, World!");

Zebra zebra = new Zebra();
zebra.Amount = 15;
zebra.Name = "Barry";

Hoof hoof = new Hoof();
hoof.NumberOfToes = 1;

zebra.Foot = hoof;

Zoo zoo = new Zoo();
zoo.NameOfZoo = "Bronx Zoo";
zoo.NumberOfAnimals = 15;
zoo.Animal = zebra;

JsonSerializerOptions options = new JsonSerializerOptions()
{
    Converters = { new TypeDiscriminatorConverter<IAnimal>(),
        new TypeDiscriminatorConverter<IFoot>()}
};

string serializedZoo = JsonSerializer.Serialize(zoo, options);
Console.WriteLine(serializedZoo);
