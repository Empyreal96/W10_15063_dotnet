// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplication
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (CoreApplication))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(179107748, 24093, 18911, 128, 52, 251, 106, 104, 188, 94, 209)]
  internal interface ICoreApplication
  {
    string Id { get; }

    event EventHandler<SuspendingEventArgs> Suspending;

    event EventHandler<object> Resuming;

    IPropertySet Properties { get; }

    CoreApplicationView GetCurrentView();

    void Run(IFrameworkViewSource viewSource);

    void RunWithActivationFactories(IGetActivationFactory activationFactoryCallback);
  }
}
