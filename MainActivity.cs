using Android.App;
using Android.Widget;
using Android.OS;

namespace App4
{
    [Activity(Label = "App4", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button showPopupMenu = FindViewById<Button>(Resource.Id.popupButton);
            showPopupMenu.Click += delegate
            {
                //Toast.MakeText(this, "hello", ToastLength.Long).Show();
                PopupMenu menu = new PopupMenu(this.showPopupMenu);
                menu.Inflate(Resource.Menu.popup_menu);
                menu.MenuItemClick += (s1, e1) =>
                {
                    Toast.MakeText(this, e1.Item.TitleFormatted.ToString(), ToastLength.Long).Show();
                };
                menu.Show();  
            };


        }
    }
}

