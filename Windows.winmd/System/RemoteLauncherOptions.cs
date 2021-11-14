// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteLauncherOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class RemoteLauncherOptions : IRemoteLauncherOptions
  {
    [MethodImpl]
    public extern RemoteLauncherOptions();

    public extern Uri FallbackUri { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> PreferredAppIds { [MethodImpl] get; }
  }
}
