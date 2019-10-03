using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
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
       // WebView img;
        TextView txtNome;
        TextView txtDesc;
        ImageView test;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main2);
            // Create your application here

            string url = Intent.GetStringExtra("img");
            var imgbitmap = GetImageBitmapFromUrl(url);

           // img = FindViewById<WebView>(Resource.Id.webView);
            txtNome = FindViewById<TextView>(Resource.Id.textViewNome);
            txtDesc = FindViewById<TextView>(Resource.Id.textViewDescr);
            test = FindViewById<ImageView>(Resource.Id.imageView);

            // img.LoadUrl(url);
            test.SetImageBitmap(imgbitmap);
            txtNome.Text = Intent.GetStringExtra("nome");
            txtDesc.Text = Intent.GetStringExtra("desc");

        }

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;
            if (!(url == "null"))
                using (var webClient = new WebClient())
                {
                    var imageBytes = webClient.DownloadData(url);
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                    }
                }

            return imageBitmap;
        }
    }
}