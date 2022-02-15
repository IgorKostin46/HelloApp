using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label label1 = new Label()
            {
                Text = "Костин Игорь Александрович",
                FontSize = 16,
                TextColor = Color.Maroon
            };
            Label label2 = new Label()
            {
                Text = "Группа: ПКС-31",
                FontSize = 16,
                TextColor = Color.Black
            };

            Label label3 = new Label()
            {
                Text = "Я увлекаюсь машинами, автозвуком и музыкой в целом.",
                FontSize = 16,
                TextColor = Color.Maroon
            };

            Image1.Source = ImageSource.FromResource("HelloApp.Images.monkey_k.jpg");

            StackLayout stackLayout = new StackLayout()
            {
                Children = { label1, label2, Image1, label3 }
            };
            stackLayout.Spacing = 8;
            this.Content = stackLayout;
            

        }

    }
}


