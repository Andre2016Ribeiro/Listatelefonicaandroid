using Android.Widget;

namespace Listatelefonicaandroid
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Spinner spinner1, spinner2;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            addItemsOnSpinner1();

            addItemsOnSpinner2();

       
        }
        string[] lineOfContents = File.ReadAllLines("lista telefonica.txt");
        string[] lineOfContentstelemovel = File.ReadAllLines("telemoveis.txt");



        public void addItemsOnSpinner1()
        {
            spinner1 = (Spinner)FindViewById(Resource.Id.spinner1);
            List<String> list = new List<String>();



            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                list.Add(tokens[2] + "  -  " + tokens[3]);
            }
            ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(this,
            Android.Resource.Layout.SimpleSpinnerItem, list);  //simple_spinner_item
            dataAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);//simple_spinner_dropdown_item

            spinner1.Adapter = dataAdapter;
        }


    

        public void addItemsOnSpinner2()
        {
        spinner2 = (Spinner)FindViewById(Resource.Id.spinner2);
        List<String> list2 = new List<String>();


        
            foreach (var line in lineOfContentstelemovel)
            {
                string[] tokenstelemovel = line.Split(',');
                list2.Add(tokenstelemovel[2] + "  -  " + tokenstelemovel[3]);

            }

            ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(this,
            Android.Resource.Layout.SimpleSpinnerItem, list2);  //simple_spinner_item
        dataAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);//simple_spinner_dropdown_item

        spinner2.Adapter = dataAdapter;
        }
    }
}