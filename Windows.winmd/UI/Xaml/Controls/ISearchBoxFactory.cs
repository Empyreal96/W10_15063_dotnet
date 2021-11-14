// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBoxFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3446947693, 34437, 18100, 157, 221, 32, 47, 105, 65, 183, 1)]
  [ExclusiveTo(typeof (SearchBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISearchBoxFactory
  {
    SearchBox CreateInstance(object outer, out object inner);
  }
}
