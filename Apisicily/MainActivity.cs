using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;



namespace Apisicily
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            // Affichage du logo
            ImageView logoImageView = FindViewById<ImageView>(Resource.Id.logoImageView);
            logoImageView.SetImageResource(Resource.Drawable.sicily_lines_logo);

            // Affichage du titre de l'activité
            TextView titleTextView = FindViewById<TextView>(Resource.Id.titleTextView);
            titleTextView.Text = "Écran d'accueil";

            // Bouton d'authentification
            Button authButton = FindViewById<Button>(Resource.Id.authButton);
            authButton.Click += (sender, e) =>
            {
                // Redirection vers l'écran d'authentification
                StartActivity(typeof(AuthentificationActivity));
            };

            // Bouton de navigation
            Button navigationButton = FindViewById<Button>(Resource.Id.navigationButton);
            navigationButton.Click += (sender, e) =>
            {
                // Redirection vers l'écran de navigation
                StartActivity(typeof(NavigationActivity));
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
