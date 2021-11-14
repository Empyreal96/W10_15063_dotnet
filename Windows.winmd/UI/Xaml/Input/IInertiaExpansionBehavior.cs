// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IInertiaExpansionBehavior
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(1964869605, 36162, 17605, 150, 94, 60, 211, 12, 201, 214, 247)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InertiaExpansionBehavior))]
  [WebHostHidden]
  internal interface IInertiaExpansionBehavior
  {
    double DesiredDeceleration { get; set; }

    double DesiredExpansion { get; set; }
  }
}
