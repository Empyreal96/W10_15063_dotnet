// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplication
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Application))]
  [Guid(1958240673, 29831, 18089, 154, 110, 199, 139, 81, 39, 38, 197)]
  internal interface IApplication
  {
    ResourceDictionary Resources { get; set; }

    DebugSettings DebugSettings { get; }

    ApplicationTheme RequestedTheme { get; set; }

    event UnhandledExceptionEventHandler UnhandledException;

    event SuspendingEventHandler Suspending;

    event EventHandler<object> Resuming;

    void Exit();
  }
}
