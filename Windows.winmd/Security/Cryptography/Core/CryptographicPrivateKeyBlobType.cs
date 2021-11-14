// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.CryptographicPrivateKeyBlobType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CryptographicPrivateKeyBlobType
  {
    Pkcs8RawPrivateKeyInfo,
    Pkcs1RsaPrivateKey,
    BCryptPrivateKey,
    Capi1PrivateKey,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] BCryptEccFullPrivateKey,
  }
}
