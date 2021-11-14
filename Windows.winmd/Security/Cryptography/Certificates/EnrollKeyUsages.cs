// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.EnrollKeyUsages
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum EnrollKeyUsages : uint
  {
    None = 0,
    Decryption = 1,
    Signing = 2,
    KeyAgreement = 4,
    All = 16777215, // 0x00FFFFFF
  }
}
