// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationPivot
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (ManipulationPivot))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(775436453, 59074, 18840, 130, 172, 24, 116, 139, 20, 22, 102)]
  internal interface IManipulationPivot
  {
    Point Center { get; set; }

    double Radius { get; set; }
  }
}
