// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.HardwareToken
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System.Profile
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (ProfileHardwareTokenContract), 65536)]
  public sealed class HardwareToken : IHardwareToken
  {
    public extern IBuffer Id { [MethodImpl] get; }

    public extern IBuffer Signature { [MethodImpl] get; }

    public extern IBuffer Certificate { [MethodImpl] get; }
  }
}
