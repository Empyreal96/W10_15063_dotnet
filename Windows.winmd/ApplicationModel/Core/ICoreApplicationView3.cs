// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplicationView3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (CoreApplicationView))]
  [Guid(132899251, 42191, 17744, 171, 112, 176, 126, 133, 51, 11, 200)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ICoreApplicationView3
  {
    bool IsComponent { get; }

    CoreApplicationViewTitleBar TitleBar { get; }

    event TypedEventHandler<CoreApplicationView, HostedViewClosingEventArgs> HostedViewClosing;
  }
}
