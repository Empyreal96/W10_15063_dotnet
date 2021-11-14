// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(810930632, 57169, 17364, 178, 59, 14, 16, 55, 70, 122, 9)]
  [ExclusiveTo(typeof (RadialController))]
  internal interface IRadialController
  {
    RadialControllerMenu Menu { get; }

    double RotationResolutionInDegrees { get; set; }

    bool UseAutomaticHapticFeedback { get; set; }

    event TypedEventHandler<RadialController, RadialControllerScreenContactStartedEventArgs> ScreenContactStarted;

    event TypedEventHandler<RadialController, object> ScreenContactEnded;

    event TypedEventHandler<RadialController, RadialControllerScreenContactContinuedEventArgs> ScreenContactContinued;

    event TypedEventHandler<RadialController, object> ControlLost;

    event TypedEventHandler<RadialController, RadialControllerRotationChangedEventArgs> RotationChanged;

    event TypedEventHandler<RadialController, RadialControllerButtonClickedEventArgs> ButtonClicked;

    event TypedEventHandler<RadialController, RadialControllerControlAcquiredEventArgs> ControlAcquired;
  }
}
