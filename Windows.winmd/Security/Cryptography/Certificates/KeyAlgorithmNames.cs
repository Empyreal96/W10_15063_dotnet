// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.KeyAlgorithmNames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IKeyAlgorithmNamesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKeyAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class KeyAlgorithmNames
  {
    public static extern string Ecdsa { [MethodImpl] get; }

    public static extern string Ecdh { [MethodImpl] get; }

    public static extern string Rsa { [MethodImpl] get; }

    public static extern string Dsa { [MethodImpl] get; }

    public static extern string Ecdh256 { [MethodImpl] get; }

    public static extern string Ecdh384 { [MethodImpl] get; }

    public static extern string Ecdh521 { [MethodImpl] get; }

    public static extern string Ecdsa256 { [MethodImpl] get; }

    public static extern string Ecdsa384 { [MethodImpl] get; }

    public static extern string Ecdsa521 { [MethodImpl] get; }
  }
}
