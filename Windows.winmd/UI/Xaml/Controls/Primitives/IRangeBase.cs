// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IRangeBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(4194315290, 18766, 18127, 145, 212, 225, 74, 141, 121, 134, 117)]
  [ExclusiveTo(typeof (RangeBase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IRangeBase
  {
    double Minimum { get; set; }

    double Maximum { get; set; }

    double SmallChange { get; set; }

    double LargeChange { get; set; }

    double Value { get; set; }

    event RangeBaseValueChangedEventHandler ValueChanged;
  }
}
