//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{
//    using System;

  
//    public interface IImage
//    {
//        void Display();
//    }


//    public class RealImage : IImage
//    {
//        private readonly string _filename;

//        public RealImage(string filename)
//        {
//            _filename = filename;
//            LoadFromDisk();
//        }

//        private void LoadFromDisk()
//        {
//            Console.WriteLine($"Downloading {_filename} from disk...");
//        }

//        public void Display()
//        {
//            Console.WriteLine($"Displaying {_filename}...");
//        }
//    }


//    public class ImageProxy : IImage
//    {
//        private readonly string _filename;
//        private RealImage _image;

//        public ImageProxy(string filename)
//        {
//            _filename = filename;
//        }

//        public void Display()
//        {
//            if (_image == null)
//            {
//                _image = new RealImage(_filename);
//            }

//            _image.Display();
//        }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Displaying an image directly
//            IImage image = new RealImage("test.jpg");
//            image.Display();

//            // Displaying an image through a proxy
//            IImage imageProxy = new ImageProxy("test.jpg");
//            imageProxy.Display();
//        }
//    }

//}
