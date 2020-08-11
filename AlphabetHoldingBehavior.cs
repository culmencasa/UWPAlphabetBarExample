using App1.Controls;
using App1.ViewModels;
using Microsoft.Xaml.Interactivity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace App1
{

    public class AlphabetHoldingBehavior : Behavior<CustomLetterButton>
    {

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.Tapped += AssociatedObject_Tapped;


            AssociatedObject.AddHandler(Button.PointerEnteredEvent, new PointerEventHandler(AssociatedObject_PointerEntered), true);
            AssociatedObject.AddHandler(Button.PointerPressedEvent, new PointerEventHandler(AssociatedObject_PointerPressed), true);
            AssociatedObject.AddHandler(Button.PointerExitedEvent, new PointerEventHandler(AssociatedObject_PointerExited), true);
            AssociatedObject.AddHandler(Button.PointerReleasedEvent, new PointerEventHandler(AssociatedObject_PointerReleased), true);
        }




        private void AssociatedObject_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (!AssociatedObject.LetterPopup.IsOpen)
            {
                AssociatedObject.LetterPopup.IsOpen = true;
            }

            var frame = (Frame)Window.Current.Content;
            var page = (MainPage)frame.Content;

            #region 换算item项目所在的客户端坐标

            // 这是鼠标位置，我需要的是控件位置
            //var position = e.GetCurrentPoint(sender as CustomLetterButton).Position; 
            //Debug.WriteLine($"({position.X},{position.Y})");

            GeneralTransform gt = AssociatedObject.TransformToVisual(page);
            var positionInPage = gt.TransformPoint(new Point(0, 0)); // 正确

            // 减去窗体屏幕位置，不准
            //var pointerPosition = Windows.UI.Core.CoreWindow.GetForCurrentThread().PointerPosition;
            //var x = pointerPosition.X - Window.Current.Bounds.X;
            //var y = pointerPosition.Y - Window.Current.Bounds.Y;

            Debug.WriteLine($"({positionInPage.X},{positionInPage.Y})");

            AssociatedObject.LetterPopup.VerticalOffset = positionInPage.Y - AssociatedObject.LetterPopup.Width / 2;

            #endregion

            var dx = AssociatedObject.LetterPopup.DataContext as MainViewModel;
            dx.FilteringLetter = AssociatedObject.Text;

            

        }

        private void AssociatedObject_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            AssociatedObject.Background = new SolidColorBrush(Colors.Transparent);

            AssociatedObject.ReleasePointerCaptures();

        }


        private void AssociatedObject_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            var temp = e.GetCurrentPoint(sender as Button);

            //if (temp.Properties.IsLeftButtonPressed)
            //{

            //}
            AssociatedObject.IsPressing = true; // 这个字段基本废了
        }

        private void AssociatedObject_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            AssociatedObject_Tapped(sender, null);

            AssociatedObject.IsPressing = false;
            AssociatedObject.LetterPopup.IsOpen = false;
        }

        private void AssociatedObject_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var text = AssociatedObject.Content?.ToString();

            if (AssociatedObject.Related != null)
            {
                var listbox = (ListView)AssociatedObject.Related;

                var groups = (System.Collections.ObjectModel.ObservableCollection<Models.AlbumGroup>)listbox.ItemsSource;

                listbox.SelectedItem = groups.FirstOrDefault(p => p.Name.ToLower() == text.ToLower());


                listbox.UpdateLayout();
                listbox.ScrollIntoView(listbox.SelectedItem);
            }

        }

        private async void AssociatedObject_Holding(object sender, HoldingRoutedEventArgs e)
        {

            if (sender is Button control)
            {
                await control.Dispatcher.RunIdleAsync((handler) =>
                {
                    control.Background = new SolidColorBrush(Colors.Red);
                });
            }
        }





        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.Holding -= AssociatedObject_Holding;
        }
    }
}
