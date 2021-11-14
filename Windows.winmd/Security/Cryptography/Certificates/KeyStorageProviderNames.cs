// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.KeyStorageProviderNames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Static(typeof (IKeyStorageProviderNamesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IKeyStorageProviderNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class KeyStorageProviderNames
  {
    public static extern string PassportKeyStorageProvider { [MethodImpl] get; }

    public static extern string SoftwareKeyStorageProvider { [MethodImpl] get; }

    public static extern string SmartcardKeyStorageProvider { [MethodImpl] get; }

    public static extern string PlatformKeyStorageProvider { [MethodImpl] get; }
  }
}
