// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.MacAlgorithmNames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IMacAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class MacAlgorithmNames
  {
    public static extern string HmacMd5 { [MethodImpl] get; }

    public static extern string HmacSha1 { [MethodImpl] get; }

    public static extern string HmacSha256 { [MethodImpl] get; }

    public static extern string HmacSha384 { [MethodImpl] get; }

    public static extern string HmacSha512 { [MethodImpl] get; }

    public static extern string AesCmac { [MethodImpl] get; }
  }
}
