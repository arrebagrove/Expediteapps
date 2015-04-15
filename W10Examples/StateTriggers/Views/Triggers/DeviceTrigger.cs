using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using StateTriggers.Services;
using static Windows.ApplicationModel.DesignMode;
using Windows.Graphics.Display;
using Windows.UI.Xaml.Navigation;

namespace StateTriggers.Views.Triggers
{
    public class DeviceTrigger : StateTriggerBase
    {
        #region Familiy
        public Families Family
        {
            get { return (Families)GetValue(FamilyProperty); }
            set { SetValue(FamilyProperty, value); }
        }
        public static readonly DependencyProperty FamilyProperty =
            DependencyProperty.Register("Family", typeof(Families), typeof(DeviceTrigger), new PropertyMetadata(Families.Desktop));
        #endregion

        #region Orientation
        public Orientations Orientation
        {
            get { return (Orientations)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientations), typeof(DeviceTrigger), new PropertyMetadata(Orientations.Portrait));
        #endregion

        public DeviceTrigger()
        {
            Initialize();
        }

        /// <summary>
        /// If we call SetTrigger in the Constructor, it won't affect to the UI, to make
        /// a call for the first time in the best place, it is in the Navigated Event of the Frame
        /// </summary>
        private void Initialize()
        {
            if (!DesignModeEnabled)
            {
                //Initial Trigger 
                NavigatedEventHandler framenavigated = null;
                framenavigated = (s, e) =>
                {
                    DeviceInformation.DisplayFrame.Navigated -= framenavigated;
                    SetTrigger();
                };
                DeviceInformation.DisplayFrame.Navigated += framenavigated;

                //Orientation Trigger
                DeviceInformation.DisplayInformation.OrientationChanged += (s, e) => SetTrigger();
            }
        }

        private void SetTrigger()
        {
            SetTriggerValue(Orientation == DeviceInformation.Orientation && Family == DeviceInformation.Family);
        }
    }
  
}
