// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBar3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2552954911, 29998, 20090, 176, 85, 84, 128, 44, 158, 167, 73)]
  [ExclusiveTo(typeof (AppBar))]
  internal interface IAppBar3
  {
    AppBarTemplateSettings TemplateSettings { get; }

    event EventHandler<object> Opening;

    event EventHandler<object> Closing;
  }
}
