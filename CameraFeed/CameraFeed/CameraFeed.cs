using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;
using Xamarin.Forms;

namespace CameraFeed
{
    public class CameraFeed : ContentPage
    {
        public static readonly BindableProperty CameraOptionsProperty = BindableProperty.Create(
                propertyName: "CameraOptions",
                returnType: typeof(CameraOptions),
                declaringType: typeof(CameraFeed),
                defaultValue: CameraOptions.Rear
            );

        public CameraOptions CameraOption
        {
            get { return (CameraOptions)GetValue(CameraOptionsProperty); }
            set { SetValue(CameraOptionsProperty, value); }
        }

        public void ProcessPhoto(object image)
        {
            
        }
    }
}
