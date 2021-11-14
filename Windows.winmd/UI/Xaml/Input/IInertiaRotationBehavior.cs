// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IInertiaRotationBehavior
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (InertiaRotationBehavior))]
  [Guid(1112341294, 48125, 17957, 174, 120, 32, 198, 91, 241, 239, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IInertiaRotationBehavior
  {
    double DesiredDeceleration { get; set; }

    double DesiredRotation { get; set; }
  }
}
