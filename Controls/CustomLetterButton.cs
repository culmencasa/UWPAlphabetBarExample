using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace App1.Controls
{
    public sealed class CustomLetterButton : Button
    {
        public CustomLetterButton()
        {
            this.DefaultStyleKey = typeof(CustomLetterButton);
        }

        public bool IsPressing
        {
            get
            {
                return (bool)GetValue(IsPressedProperty);
            }
            set
            {
                SetValue(IsPressedProperty, value);
            }
        }

        public static readonly DependencyProperty IsPressingProperty = DependencyProperty.Register("IsPressing", typeof(bool), typeof(CustomLetterButton), new PropertyMetadata(false));


        public DependencyObject Related
        {
            get
            {
                return (DependencyObject)GetValue(RelatedProperty);
            }
            set
            {
                SetValue(RelatedProperty, value);
            }
        }

        public static readonly DependencyProperty RelatedProperty =
          DependencyProperty.Register("Related", typeof(DependencyObject), typeof(CustomLetterButton), new PropertyMetadata(null));


        public Popup LetterPopup
        {
            get
            {
                return (Popup)GetValue(LetterPopupProperty);
            }
            set
            {
                SetValue(LetterPopupProperty, value);
            }
        }
        public static readonly DependencyProperty LetterPopupProperty =
          DependencyProperty.Register("LetterPopup", typeof(Popup), typeof(CustomLetterButton), new PropertyMetadata(null));


        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        public static readonly DependencyProperty TextProperty
            = DependencyProperty.Register("Text", typeof(string), typeof(CustomLetterButton), new PropertyMetadata(""));
    }
}
