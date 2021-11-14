// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsSignerInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1355817179, 7471, 19482, 181, 197, 208, 24, 143, 249, 31, 71)]
  [ExclusiveTo(typeof (CmsSignerInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICmsSignerInfo
  {
    Certificate Certificate { get; set; }

    string HashAlgorithmName { get; set; }

    CmsTimestampInfo TimestampInfo { get; }
  }
}
