// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBoxItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ComboBoxItem))]
  [Guid(2415913063, 55628, 20103, 143, 196, 110, 188, 214, 60, 90, 194)]
  internal interface IComboBoxItemFactory
  {
    ComboBoxItem CreateInstance(object outer, out object inner);
  }
}
