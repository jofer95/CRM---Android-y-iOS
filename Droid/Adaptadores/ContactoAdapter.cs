using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ejmeplo1.Droid.Adaptadores
{
    public class ContactoAdapter : BaseAdapter<Contacto>
    {
        private Activity context;
        private List<Contacto> items;

        public ContactoAdapter(Activity context, List<Contacto> items)
        {
            this.context = context;
            this.items = items;
        }

        public override Contacto this[int position]
        {
            get
            {
                return items[position];
            }
        }

        public override int Count
        {
            get
            {
                return items.Count();
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.itemCliente, null);
            view.FindViewById<TextView>(Resource.Id.tvNombreCompleto).Text = item.ApellidoPaterno + " " + item.ApellidoMaterno + " " + item.Nombre;
            view.FindViewById<TextView>(Resource.Id.tvCorreo).Text = item.Correo;
            view.FindViewById<TextView>(Resource.Id.tvTelefono).Text = item.Telefono;
            view.FindViewById<TextView>(Resource.Id.tvEstatus).Text = item.TipoCliente.ToString();
            return view;
        }
    }
}