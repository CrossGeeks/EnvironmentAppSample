using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnvironmentAppSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            #if DEV
                    BackgroundColor = Color.LightGray;
                    enviromentLabel.Text = "DEV";
            #else
                    BackgroundColor = Color.LightBlue;
                    enviromentLabel.Text = "PROD";
            #endif
        }
    }
}
