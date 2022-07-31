/*namespace cs_con_interfacedemo
{
    interface Idisplayname
    {
        void Displayname();
    }
    class Displayname1 : Idisplayname
    {
        public void Displayname()
        {

            Console.WriteLine("enter name in lowercase:");
            string name = Console.ReadLine();
            string name1 = name.ToUpper();
            Console.WriteLine("Name in uppercase:" + name1);

        }
    }
class class1 { 

 public static void Main(string[] args)
    {  
    Displayname1 obj=new Displayname1();
                obj.Displayname(); 

    }
}

}*//*
using System;

namespace s_con_interfacedemo
{
    abstract class Animal
    {
        
        public abstract void animalSound();
      
        public void sleep()
        {
            Console.WriteLine("Sound of the dpg sleep is:Zzz");
        }
    }

    
    class Dog : Animal
    {
        public override void animalSound()
        {
            
            Console.WriteLine("The dog says: bow bow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();  
            myDog.animalSound();
            myDog.sleep();
        }
    }
}*/
/*
//--prorperty using get set method
using System;

namespace s_con_interfacedemo
{
    class class1
    {
       private string Name="na";
        string Name1
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
    }
    class calss2 {
    public static void Main(string[] args)
        {
            class1 obj=new class1();
            obj.Name1;
        {

        }
        }
    }

}*//*
using System;
class IndexerCreation
{
    private string[] val = new string[3];

    public string this[int index]
    {
        get
        {
            return val[index];
        }
        set
        {
            val[index] = value;
        }
    }
}
class main
{
    public static void Main()
    {
        IndexerCreation i = new IndexerCreation();
        i[0] = "a";
        i[1] = "arunkumar";
        i[2] = "voligi";

        Console.Write("Printing values stored in objects used as arrays\n");
        Console.WriteLine("First value = {0}", i[0]);
        Console.WriteLine("Second value = {0}", i[1]);
        Console.WriteLine("Third value = {0}", i[2]);

    }
}*/
using System;
public class Address
{
    public string addressLine, city, state;
    public Address(string addressLine, string city, string state)
    {
        this.addressLine = addressLine;
        this.city = city;
        this.state = state;
    }
}
public class Employee
{
    public int id;
    public string name;
    public Address address; 
    public Employee(int id, string name, Address address)
    {
        this.id = id;
        this.name = name;
        this.address = address;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " +
          address.addressLine + " " + address.city + " " + address.state);
    }
}
public class TestAggregation
{
    public static void Main(string[] args)
    {
        Address a1 = new Address("H-21, road-2", "hyd", "ts");
        Employee e1 = new Employee(1, "arun", a1);
        e1.display();
    }
}