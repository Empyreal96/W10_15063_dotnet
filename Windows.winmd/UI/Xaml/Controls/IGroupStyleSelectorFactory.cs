// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGroupStyleSelectorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3210153267, 45814, 18463, 164, 80, 200, 12, 41, 31, 178, 45)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GroupStyleSelector))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGroupStyleSelectorFactory
  {
    GroupStyleSelector CreateInstance(object outer, out object inner);
  }
}
