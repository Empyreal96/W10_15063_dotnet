// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.KnownRuimFilePaths
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IKnownRuimFilePathsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public static class KnownRuimFilePaths
  {
    public static extern IVectorView<uint> EFSpn { [MethodImpl] get; }

    public static extern IVectorView<uint> Gid1 { [MethodImpl] get; }

    public static extern IVectorView<uint> Gid2 { [MethodImpl] get; }
  }
}
