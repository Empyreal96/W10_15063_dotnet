// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.ProtectionCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class ProtectionCapabilities : IProtectionCapabilities
  {
    [MethodImpl]
    public extern ProtectionCapabilities();

    [MethodImpl]
    public extern ProtectionCapabilityResult IsTypeSupported(
      string type,
      string keySystem);
  }
}
