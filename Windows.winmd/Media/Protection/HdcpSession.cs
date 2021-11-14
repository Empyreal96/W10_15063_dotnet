// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.HdcpSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [DualApiPartition(version = 167772162)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class HdcpSession : IHdcpSession, IClosable
  {
    [MethodImpl]
    public extern HdcpSession();

    [MethodImpl]
    public extern bool IsEffectiveProtectionAtLeast(HdcpProtection protection);

    [MethodImpl]
    public extern IReference<HdcpProtection> GetEffectiveProtection();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<HdcpSetProtectionResult> SetDesiredMinProtectionAsync(
      HdcpProtection protection);

    public extern event TypedEventHandler<HdcpSession, object> ProtectionChanged;

    [MethodImpl]
    public extern void Close();
  }
}
