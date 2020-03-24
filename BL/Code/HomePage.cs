using System;
using System.Collections.Generic;
using BL.Model;
using Xamarin.Forms;

namespace BL.Code
{
    public class HomePage : ContentPage
    {
        public IList<ImgDetail> Banners { get; private set; }
        public HomePage()
        {
            
            // Create the CarouselView.
            CarouselView carouselView = new CarouselView
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    StackLayout rootStackLayout = new StackLayout();

                    Frame frame = new Frame
                    {
                        HasShadow = true,
                        BorderColor = Color.Gray,
                        Margin = new Thickness(0),
                        HeightRequest = 300,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    };

                    StackLayout stackLayout = new StackLayout();

                    Label nameLabel = new Label
                    {
                        FontAttributes = FontAttributes.Bold,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    };
                    nameLabel.SetBinding(Label.TextProperty, "Name");

                    Image image = new Image
                    {
                        Aspect = Aspect.AspectFill,
                        HeightRequest = 150,
                        WidthRequest = 150,
                        HorizontalOptions = LayoutOptions.Center
                    };
                    image.SetBinding(Image.SourceProperty, "ImageUrl");

                    Label locationLabel = new Label
                    {
                        HorizontalOptions = LayoutOptions.Center
                    };
                    locationLabel.SetBinding(Label.TextProperty, "Location");

                    Label detailsLabel = new Label
                    {
                        FontAttributes = FontAttributes.Italic,
                        HorizontalOptions = LayoutOptions.Center,
                        MaxLines = 5,
                        LineBreakMode = LineBreakMode.TailTruncation
                    };
                    detailsLabel.SetBinding(Label.TextProperty, "Details");

                    stackLayout.Children.Add(nameLabel);
                    stackLayout.Children.Add(image);
                    stackLayout.Children.Add(locationLabel);
                    stackLayout.Children.Add(detailsLabel);

                    frame.Content = stackLayout;
                    rootStackLayout.Children.Add(frame);

                    return rootStackLayout;
                })
            };
            carouselView.SetBinding(ItemsView.ItemsSourceProperty, "banners");

            //配置页面内容
            Title = "首页";

            Content = new StackLayout
            {
                Margin = new Thickness(15),
                Children = {
                    carouselView
                }
            };
            CreateMonkeyCollection();
            BindingContext = this;
        }

        void CreateMonkeyCollection()
        {
            Banners = new List<ImgDetail>();
            Banners.Add(new ImgDetail
            {
                Name = "第一张banner",
                Location = "Africa & Asia",
                Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                ImageUrl = "/banner/1.jpeg"
            }); ;
            Banners.Add(new ImgDetail
            {
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });
            Banners.Add(new ImgDetail
            {
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });
            Banners.Add(new ImgDetail
            {
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });
            //throw new NotImplementedException();
        }
    }
}

