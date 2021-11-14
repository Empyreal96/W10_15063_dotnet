// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsStackPanel2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4008627632, 180, 17716, 147, 123, 86, 49, 139, 41, 62, 146)]
  [ExclusiveTo(typeof (ItemsStackPanel))]
  [WebHostHidden]
  internal interface IItemsStackPanel2
  {
    bool AreStickyGroupHeadersEnabled { get; set; }
  }
}
