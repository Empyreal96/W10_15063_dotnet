// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4026787042, 31503, 20298, 151, 13, 174, 138, 14, 170, 155, 112)]
  internal interface IAppBarOverrides
  {
    void OnClosed(object e);

    void OnOpened(object e);
  }
}
