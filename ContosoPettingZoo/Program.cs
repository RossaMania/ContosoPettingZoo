// - There will be three visiting schools
//     - School A has six visiting groups (the default number)
//     - School B has three visiting groups
//     - School C has two visiting groups

// - For each visiting school, perform the following tasks
//     - Randomize the animals
//     - Assign the animals to the correct number of groups
//     - Print the school name
//     - Print the animal groups

using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

void RandomizeAnimals()
{

Random random = new Random();

for (int i = 0; i < pettingZoo.Length; i++)
{
    int r = random.Next(i, pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
}

}

// string[,] group = AssignGroup();

Console.WriteLine("School A");

// PrintGroup(group);