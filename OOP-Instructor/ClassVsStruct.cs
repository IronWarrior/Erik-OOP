using System.Numerics;

class ClassVsStruct
{ 
    class MyClass
    {
        public int SomeValue;
    }

    // "structure"
    struct MyStruct
    {
        public int SomeValue;
    }

    class Material
    {
        public Color theColor;
    }

    struct Color
    {
        int r, g, b, a;
    }

    class User
    {
        string username, displayName, profileDescription;
        int cash;
    }

    struct Coordinate
    {
        int latitude, longitude;
    }

    class Pokemon
    {
        string name, type;
        List<string> abilities;
    }

    struct PokemonEntity
    {
        public Vector2 Position, Rotation;

        public Pokemon pokemon;
    }

    public static void Execute()
    {
        // an "instance" is an entity that has been created
        // in your program's "world",
        // whereas a class or struct is a template or concept of
        // how an object is defined.

        // Classes are "pass by REFERENCE", in that a new copy is
        // not created when they are assigned to new variables.

        // Structs are "pass by VALUE"; they are FULLY copied when
        // they are assigned to a new variable.

        // These rules also apply when passing them into functions.

        //MyStruct aClass = new MyStruct();

        //aClass.SomeValue = 5;

        //MyStruct bClass = aClass;

        //bClass.SomeValue = 3;

        //Console.WriteLine($"a:{aClass.SomeValue} b:{bClass.SomeValue}");

        //MyStruct b = new MyStruct();

        //MyClass a = new MyClass();
        //a.SomeValue = 5;

        //Modify(a);

        //Console.WriteLine(a.SomeValue);

        // a:3 b:3
        // a:5 b:3
    }

    private static void Modify(MyClass myClass)
    {
        myClass.SomeValue = 100000;
    }
}

