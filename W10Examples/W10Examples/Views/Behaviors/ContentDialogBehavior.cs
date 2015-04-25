using Microsoft.Xaml.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace W10Examples.Views.Behaviors
{
    public class ContentDialogBehavior : DependencyObject, IBehavior
    {
        #region DataTemplate
        public DataTemplate DataTemplate
        {
            get { return (DataTemplate)GetValue(DataTemplateProperty); }
            set { SetValue(DataTemplateProperty, value); }
        }

        public static readonly DependencyProperty DataTemplateProperty =
            DependencyProperty.Register(nameof(DataTemplate), typeof(DataTemplate), typeof(ContentDialogBehavior), new PropertyMetadata(new DataTemplate()));
        #endregion

        #region ContentDialog
        public ContentDialog ContentDialog
        {
            get { return (ContentDialog)GetValue(ContentDialogProperty); }
            set { SetValue(ContentDialogProperty, value); }
        }
        public static readonly DependencyProperty ContentDialogProperty =
            DependencyProperty.Register(nameof(ContentDialog), typeof(ContentDialog), typeof(ContentDialogBehavior), new PropertyMetadata(null));
        #endregion

        #region IBehavior
        public DependencyObject AssociatedObject { get; private set; }

        public void Attach(DependencyObject associatedObject)
        {
            AssociatedObject = associatedObject;

            (associatedObject as FrameworkElement).Tapped += async (s, e) =>
            {
                if (ContentDialog != null && DataTemplate != null)
                {
                    ContentDialog.DataContext = (AssociatedObject as FrameworkElement).DataContext;
                    ContentDialog.ContentTemplate = DataTemplate;
                    var result = await ContentDialog.ShowAsync();
                }
            };
        }

        public void Detach()
        {
        }
        #endregion
    }
}
