using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;

namespace MeuApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //Declaração de uma nova lista, "people", atrelada a classe "ClassPerson"
        List<ClassPerson> people;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            //Instaciando Elementos do layout
            ListView pessoas = FindViewById<ListView>(Resource.Id.listView);


            //preparação para criação de objetos "person" que farão parte da lista "people"
            people = new List<ClassPerson>();


            //Criação de objeto "newPerson" da classe "ClassPerson"
            ClassPerson newPerson = new ClassPerson();


            //Definição de propriedades do novo objeto
            newPerson.nome  = "Joker";
            newPerson.img   = "http://www.portalsacaso.com.br/wp-content/uploads/2018/01/1-17.jpg";
            newPerson.desc  = "Maior vilão do Batman";


            //Adição do objeto "newPerson" a lista "people"
            people.Add(newPerson);

            
            //redefinição de "newPerson" para criação de novo objeto
            newPerson = new ClassPerson();

        }
    }
}