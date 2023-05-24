//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{
//    abstract class Component
//    {
//        protected string name;

//        public Component(string name)
//        {
//            this.name = name;
//        }

//        public abstract void Add(Component component);
//        public abstract void Remove(Component component);
//        public abstract void Display(int depth);
//    }

//    class Element : Component
//    {
//        public Element(string name) : base(name)
//        {
//        }
//        public override void Add(Component component)
//        {
//            Console.WriteLine("Cannot add to a leaf");
//        }
//        public override void Remove(Component component)
//        {
//            Console.WriteLine("Cannot remove from a leaf");
//        }
//        public override void Display(int depth)
//        {
//            Console.WriteLine(new String('-', depth) + name);
//        }
//    }

//    class Composite : Component
//    {
//        private List<Component> children = new List<Component>();

//        public Composite(string name) : base(name)
//        {
//        }

//        public override void Add(Component component)
//        {
//            children.Add(component);
//        }

//        public override void Remove(Component component)
//        {
//            children.Remove(component);
//        }

//        public override void Display(int depth)
//        {
//            Console.WriteLine(new String('-', depth) + name);

//            foreach (Component component in children)
//            {
//                component.Display(depth + 2);
//            }
//        }
//    }

//    public class Programm
//    {
//      public static void Main(string[] args) 
//        {
//            Composite RootFolder = new Composite("Root Folder");
//            RootFolder.Add(new Element("File A"));
//            RootFolder.Add(new Element("File B"));

//            Composite Folder1 = new Composite("Folder 1");
//            Folder1.Add(new Element("File C"));
//            Folder1.Add(new Element("File D"));

//            RootFolder.Add(Folder1);

//            Composite Folder2 = new Composite("Folder 2");
//            Folder2.Add(new Element("File E"));
//            Folder2.Add(new Element("File F"));
            

//            Folder1.Add(Folder2);

//            RootFolder.Display(0);


//        }
//    }



//}
