// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum KeyCredentialStatus
  {
    Success,
    UnknownError,
    NotFound,
    UserCanceled,
    UserPrefersPassword,
    CredentialAlreadyExists,
    SecurityDeviceLocked,
  }
}
