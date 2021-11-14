// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVariableSizedWrapGrid
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2628061127, 9161, 20225, 184, 15, 190, 92, 33, 238, 244, 116)]
  [ExclusiveTo(typeof (VariableSizedWrapGrid))]
  internal interface IVariableSizedWrapGrid
  {
    double ItemHeight { get; set; }

    double ItemWidth { get; set; }

    Orientation Orientation { get; set; }

    HorizontalAlignment HorizontalChildrenAlignment { get; set; }

    VerticalAlignment VerticalChildrenAlignment { get; set; }

    int MaximumRowsOrColumns { get; set; }
  }
}
