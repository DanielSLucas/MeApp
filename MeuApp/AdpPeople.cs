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

namespace MeuApp
{
    class AdpPeople : BaseAdapter<ClassPerson>
    {
        private List<ClassPerson> itens;

        private Context contexto;

        //Contructor
        public AdpPeople (Context contexto, List<ClassPerson> itens)
        {
            this.itens = itens;
            this.contexto = contexto;

        }

        //------------------------------------------------------------------------------------
        public override ClassPerson this[int position]
        {
            get
            {
                return itens[position];
            }
        }

        //------------------------------------------------------------------------------------
        public override int Count
        {
            get
            {
                return itens.Count();
            }
        }

        //------------------------------------------------------------------------------------
        public override long GetItemId(int position)
        {
            return position;
        }

        //------------------------------------------------------------------------------------
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View linha = convertView;

            if (linha == null)
            {
                linha = LayoutInflater.From(contexto).Inflate(Resource.Layout.layout2, null, false);
            };

            // Buscar os Widgets
            TextView name = linha.FindViewById<TextView>(Resource.Id.textView1);

            name.Text = itens[position].nome.ToString();

            return linha;
            //CONTINUAR DAQUI!!
        }
    }
}