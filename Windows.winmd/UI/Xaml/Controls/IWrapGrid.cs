// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWrapGrid
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (WrapGrid))]
  [Guid(89266059, 30055, 18370, 189, 92, 173, 131, 148, 200, 40, 186)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWrapGrid
  {
    double ItemWidth { get; set; }

    double ItemHeight { get; set; }

    Orientation Orientation { get; set; }

    HorizontalAlignment HorizontalChildrenAlignment { get; set; }

    VerticalAlignment VerticalChildrenAlignment { get; set; }

    int MaximumRowsOrColumns { get; set; }
  }
}
