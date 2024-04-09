Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);  

Dog neighboursDog = new Dog("Good girl");

Console.WriteLine($"My dog name is {myDog.Name} and my neighbour dog name is {neighboursDog.Name}");

myDog.Rename("Bad Boy");
while (myDog.LevelOfHappinness != 5)
{
    myDog.Bark();
}
myDog.WagTail();


class Dog
{
    private string _name;  
    private int _levelOfHappiness = 0;

    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }
    //getter
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHappinness 
    {
        get { return _levelOfHappiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }
    public void Bark()
    {
        Console.WriteLine("Woof-woof");
        _levelOfHappiness++;
    }
    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle");
    }
}
