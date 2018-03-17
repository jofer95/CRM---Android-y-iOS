using System;
using System.IO;
using ejmeplo1.Repositorios;
using UIKit;

namespace ejmeplo1.iOS
{
    public partial class ViewController : UIViewController
    {
        //Variable donde se generará la Base de datos a guardar la información.
        public static String path;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            path= Path.Combine(libFolder, "crm.db3");
            //Creando las tablas e inicializando
            SQLiteContactoRepository repositorio = new SQLiteContactoRepository(path);
            repositorio.Inicializar();


            // Perform any additional setup after loading the view, typically from a nib.
            //Button.AccessibilityIdentifier = "myButton";
            btnCrearCliente.TouchUpInside += delegate
            {
                
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
