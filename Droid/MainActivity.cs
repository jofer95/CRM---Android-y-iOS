using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;
using ejmeplo1.Repositorios;
using ejmeplo1.Enumeradores;

namespace ejmeplo1.Droid
{
    //Etiqueta de la barra para mostrar el titulo e icono.
    [Activity(Label = "Menu principal", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //Variable donde se generará la Base de datos a guardar la información.
        public static String path = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "crm.db3");

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Asignar el Layout a utilizar.
            SetContentView(Resource.Layout.Main);
            //Creando las tablas e inicializando
            SQLiteContactoRepository repositorio = new SQLiteContactoRepository(path);
            repositorio.Inicializar();

            //Referencias a componentes para utilizarlos
            Button btnAddContacto = FindViewById<Button>(Resource.Id.btnAddContacto);
            Button btnClientesPotenciales = FindViewById<Button>(Resource.Id.btnClientesPotenciales);
            Button btnClientes = FindViewById<Button>(Resource.Id.btnClientes);
            Button btnClientesProspectos = FindViewById<Button>(Resource.Id.btnClientesProspectos);
            Button btnClientesDescartados = FindViewById<Button>(Resource.Id.btnClientesDescartados);

            //Evento click de cada boton
            btnAddContacto.Click += delegate {
                //Seleccionar la actividad a abrir.
                var activityAddContacto = new Intent(this, typeof(AddContacto));
                //Informacion a enviar a la otra pantalla
                activityAddContacto.PutExtra("MyData", "");
                //Abrir
                StartActivity(activityAddContacto);                
            };

            btnClientesPotenciales.Click += delegate {
                var activityListaClientes = new Intent(this, typeof(ListaDeClientesActivity));
                activityListaClientes.PutExtra("MyData", "1");
                StartActivity(activityListaClientes);
            };
            btnClientes.Click += delegate {
                var activityListaClientes = new Intent(this, typeof(ListaDeClientesActivity));
                activityListaClientes.PutExtra("MyData", "3");
                StartActivity(activityListaClientes);
            };
            btnClientesProspectos.Click += delegate {
                var activityListaClientes = new Intent(this, typeof(ListaDeClientesActivity));
                activityListaClientes.PutExtra("MyData", "2");
                StartActivity(activityListaClientes);
            };
            btnClientesDescartados.Click += delegate {
                var activityListaClientes = new Intent(this, typeof(ListaDeClientesActivity));
                activityListaClientes.PutExtra("MyData", "0");
                StartActivity(activityListaClientes);
            };
        }
    }
}

