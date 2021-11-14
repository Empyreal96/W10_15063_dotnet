// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SetVersionRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SetVersionRequest : ISetVersionRequest
  {
    public extern uint CurrentVersion { [MethodImpl] get; }

    public extern uint DesiredVersion { [MethodImpl] get; }

    [MethodImpl]
    public extern SetVersionDeferral GetDeferral();
  }
}
