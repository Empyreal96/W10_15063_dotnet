// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBox2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ComboBox))]
  [Guid(3926704017, 51766, 20397, 151, 42, 46, 83, 166, 113, 139, 159)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IComboBox2
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    string PlaceholderText { get; set; }
  }
}
