using Inheritance;
// TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
Bird bird1=new Bird();
bird1.CanFly=true;
bird1.Species = "Crow";
bird1.Weight = 2;
bird1.HasTeeth = true;
bird1.Color = "black";
bird1.EatsBugs = false;
bird1.IsAlive = true;
Console.WriteLine("These are characteristics of this bird:");

Console.WriteLine($" {bird1.Species}-{bird1.HasTeeth}-{bird1.Weight}-{bird1.Color}-{bird1.Song}{bird1.CanFly}{bird1.EatsBugs}{bird1.IsAlive}");

Reptiles reptile1=new Reptiles();
reptile1.Species = "Gator";
reptile1.Weight = 300;
reptile1.IsAlive=true;
reptile1.HasTeeth = true;
reptile1.ScaleColor = "green";
reptile1.Length = 6;
reptile1.IsDinosaur = true;
reptile1.NumberOfLegs = 4;


Console.WriteLine("These are characteristics of this monstrosity:");

Console.WriteLine($"{reptile1.Species} {reptile1.HasTeeth} {reptile1.Weight}" +
    $" {reptile1.Length} {reptile1.IsAlive} {reptile1.NumberOfLegs}" +
    $" {reptile1.ScaleColor} {reptile1.IsDinosaur} ");
