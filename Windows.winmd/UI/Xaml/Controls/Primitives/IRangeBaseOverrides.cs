// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IRangeBaseOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (RangeBase))]
  [Guid(1116843833, 32523, 19394, 153, 196, 6, 231, 6, 38, 130, 216)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRangeBaseOverrides
  {
    void OnMinimumChanged(double oldMinimum, double newMinimum);

    void OnMaximumChanged(double oldMaximum, double newMaximum);

    void OnValueChanged(double oldValue, double newValue);
  }
}
