// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarOverrides3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppBar))]
  [WebHostHidden]
  [Guid(1093385160, 20944, 19273, 171, 98, 163, 221, 107, 220, 178, 152)]
  internal interface IAppBarOverrides3
  {
    void OnClosing(object e);

    void OnOpening(object e);
  }
}
