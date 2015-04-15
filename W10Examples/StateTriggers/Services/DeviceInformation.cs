using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Windows.ApplicationModel.Resources.Core.ResourceContext;
using static Windows.ApplicationModel.DesignMode;
using Windows.Graphics.Display;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace StateTriggers.Services
{
    #region Enums
    public enum Families
    {
        Mobile,
        Desktop
    }

    public enum Orientations
    {
        Portrait,
        Landscape
    }

    public class DeviceInformation
    {
        public static Orientations Orientation =>
            DisplayInformation.GetForCurrentView().CurrentOrientation.ToString().Contains("Landscape") ? Orientations.Landscape : Orientations.Portrait;

        public static Families Family =>
             GetForCurrentView().QualifierValues["DeviceFamily"] == "Mobile" ? Families.Mobile : Families.Desktop;

        public static DisplayInformation DisplayInformation =>
            DisplayInformation.GetForCurrentView();

        public static Frame DisplayFrame =>
                Window.Current.Content == null ? null : Window.Current.Content as Frame;
}
    #endregion
}
