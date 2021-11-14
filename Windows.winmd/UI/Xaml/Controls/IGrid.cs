// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGrid
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4245701728, 11797, 19363, 139, 143, 250, 105, 58, 65, 97, 233)]
  [ExclusiveTo(typeof (Grid))]
  internal interface IGrid
  {
    RowDefinitionCollection RowDefinitions { get; }

    ColumnDefinitionCollection ColumnDefinitions { get; }
  }
}
