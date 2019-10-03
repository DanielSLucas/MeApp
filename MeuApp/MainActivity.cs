using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;

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


            newPerson.nome = "Batman";
            newPerson.img = "https://i1.wp.com/trecobox.com.br/wp-content/uploads/2018/01/Batman-HQ.jpg?fit=1000%2C600&ssl=1";
            newPerson.desc = "Bruce Wayne ricasso durante o dia, vigilante durante a noite";

            people.Add(newPerson);

            newPerson = new ClassPerson();

        

            newPerson.nome = "Espantalho";
            newPerson.img = "https://s.aficionados.com.br/imagens/origem.jpg";
            newPerson.desc = "Espantalho, aquele que despesta os maiores medos dos outros";

            people.Add(newPerson);

            newPerson = new ClassPerson();


            AdpPeople adaptador = new AdpPeople(this, people);
            ListView lista = FindViewById<ListView>(Resource.Id.listView);
            lista.Adapter = adaptador;

            lista.ItemClick += Pessoas_ItemClick;
        }

        private void Pessoas_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            string nome     = people[e.Position].nome;
            string img      = people[e.Position].img;
            string desc     = people[e.Position].desc;

            var newWindow = new Intent(this, typeof(MainActivity2));

            newWindow.PutExtra("nome", nome);
            newWindow.PutExtra("img", img);
            newWindow.PutExtra("desc", desc);

            StartActivity(newWindow);

        }
    }
}