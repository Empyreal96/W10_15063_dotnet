// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.WebAccountCommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100859904)]
  [DualApiPartition(version = 167772162)]
  [Activatable(typeof (IWebAccountCommandFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WebAccountCommand : IWebAccountCommand
  {
    [MethodImpl]
    public extern WebAccountCommand(
      WebAccount webAccount,
      WebAccountCommandInvokedHandler invoked,
      SupportedWebAccountActions actions);

    public extern WebAccount WebAccount { [MethodImpl] get; }

    public extern WebAccountCommandInvokedHandler Invoked { [MethodImpl] get; }

    public extern SupportedWebAccountActions Actions { [MethodImpl] get; }
  }
}
