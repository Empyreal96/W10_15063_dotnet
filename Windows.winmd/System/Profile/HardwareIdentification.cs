// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.HardwareIdentification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System.Profile
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [Static(typeof (IHardwareIdentificationStatics), 65536, "Windows.System.Profile.ProfileHardwareTokenContract")]
  [ContractVersion(typeof (ProfileHardwareTokenContract), 65536)]
  public static class HardwareIdentification
  {
    [MethodImpl]
    public static extern HardwareToken GetPackageSpecificToken(IBuffer nonce);
  }
}
