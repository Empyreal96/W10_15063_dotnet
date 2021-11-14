// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivot2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Pivot))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2341111392, 6741, 16668, 168, 45, 24, 153, 28, 63, 13, 111)]
  internal interface IPivot2
  {
    object LeftHeader { get; set; }

    DataTemplate LeftHeaderTemplate { get; set; }

    object RightHeader { get; set; }

    DataTemplate RightHeaderTemplate { get; set; }
  }
}
