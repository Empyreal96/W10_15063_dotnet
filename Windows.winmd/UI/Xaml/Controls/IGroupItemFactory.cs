// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGroupItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3651261758, 45536, 17177, 152, 8, 122, 158, 136, 126, 19, 176)]
  [ExclusiveTo(typeof (GroupItem))]
  [WebHostHidden]
  internal interface IGroupItemFactory
  {
    GroupItem CreateInstance(object outer, out object inner);
  }
}
