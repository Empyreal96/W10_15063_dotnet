// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.KeySize
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum KeySize
  {
    Invalid = 0,
    Rsa2048 = 2048, // 0x00000800
    Rsa4096 = 4096, // 0x00001000
  }
}
