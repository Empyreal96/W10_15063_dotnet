// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppBar))]
  [Guid(2064630355, 34469, 19267, 152, 114, 11, 138, 98, 52, 183, 75)]
  [WebHostHidden]
  internal interface IAppBar
  {
    bool IsOpen { get; set; }

    bool IsSticky { get; set; }

    event EventHandler<object> Opened;

    event EventHandler<object> Closed;
  }
}
