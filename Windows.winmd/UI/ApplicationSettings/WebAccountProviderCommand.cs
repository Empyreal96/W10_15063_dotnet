// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.WebAccountProviderCommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IWebAccountProviderCommandFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.None)]
  public sealed class WebAccountProviderCommand : IWebAccountProviderCommand
  {
    [MethodImpl]
    public extern WebAccountProviderCommand(
      WebAccountProvider webAccountProvider,
      WebAccountProviderCommandInvokedHandler invoked);

    public extern WebAccountProvider WebAccountProvider { [MethodImpl] get; }

    public extern WebAccountProviderCommandInvokedHandler Invoked { [MethodImpl] get; }
  }
}
