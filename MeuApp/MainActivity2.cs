using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace MeuApp
{
    [Activity(Label = "MainActivity2")]
    public class MainActivity2 : Activity
    {
        WebView img;
        TextView txtNome;
        TextView txtDesc;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main2);
            // Create your application here

            string url = Intent.GetStringExtra("img");

            img = FindViewById<WebView>(Resource.Id.webView);
            txtNome = FindViewById<TextView>(Resource.Id.textViewNome);
            txtDesc = FindViewById<TextView>(Resource.Id.textViewDescr);

            img.LoadUrl(url);
            txtNome.Text = Intent.GetStringExtra("nome");
            txtDesc.Text = Intent.GetStringExtra("desc");
            
            


        }
    }
}