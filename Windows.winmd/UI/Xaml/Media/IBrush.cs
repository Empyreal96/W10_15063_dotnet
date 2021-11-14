// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(2282136353, 7686, 16940, 161, 204, 1, 105, 101, 89, 224, 33)]
  [ExclusiveTo(typeof (Brush))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBrush
  {
    double Opacity { get; set; }

    Transform Transform { get; set; }

    Transform RelativeTransform { get; set; }
  }
}
