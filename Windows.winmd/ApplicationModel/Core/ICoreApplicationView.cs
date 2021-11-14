// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplicationView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (CoreApplicationView))]
  [Guid(1670099675, 17693, 18017, 176, 153, 65, 79, 52, 255, 185, 241)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreApplicationView
  {
    CoreWindow CoreWindow { get; }

    event TypedEventHandler<CoreApplicationView, IActivatedEventArgs> Activated;

    bool IsMain { get; }

    bool IsHosted { get; }
  }
}
