var name = "Ewa";
var age = 33;
var sex = "kobieta";

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "kobieta" && age < 33)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age < 18 && sex != "kobieta")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Złe dane");
}