// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListBoxFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1624112546, 12100, 17483, 156, 148, 184, 201, 253, 164, 111, 89)]
  [ExclusiveTo(typeof (ListBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListBoxFactory
  {
    ListBox CreateInstance(object outer, out object inner);
  }
}
