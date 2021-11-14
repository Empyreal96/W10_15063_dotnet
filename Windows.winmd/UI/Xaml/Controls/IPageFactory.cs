// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Page))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3751889324, 6217, 17502, 147, 124, 64, 169, 89, 12, 192, 118)]
  [WebHostHidden]
  internal interface IPageFactory
  {
    Page CreateInstance(object outer, out object inner);
  }
}
