// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebAccountMonitor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebAccountMonitor : IWebAccountMonitor
  {
    public extern event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> Updated;

    public extern event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> Removed;

    public extern event TypedEventHandler<WebAccountMonitor, object> DefaultSignInAccountChanged;
  }
}
