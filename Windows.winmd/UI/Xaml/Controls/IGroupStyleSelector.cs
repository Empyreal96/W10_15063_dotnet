// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGroupStyleSelector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (GroupStyleSelector))]
  [Guid(1843007902, 39540, 18319, 163, 57, 91, 181, 45, 230, 197, 30)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGroupStyleSelector
  {
    GroupStyle SelectGroupStyle(object group, uint level);
  }
}
