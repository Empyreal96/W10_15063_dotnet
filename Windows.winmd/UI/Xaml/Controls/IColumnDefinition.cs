// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IColumnDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(4159812137, 61476, 18047, 151, 10, 126, 112, 86, 21, 219, 123)]
  [ExclusiveTo(typeof (ColumnDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IColumnDefinition
  {
    GridLength Width { get; set; }

    double MaxWidth { get; set; }

    double MinWidth { get; set; }

    double ActualWidth { get; }
  }
}
