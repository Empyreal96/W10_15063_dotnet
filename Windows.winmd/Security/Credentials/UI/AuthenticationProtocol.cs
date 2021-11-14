// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.AuthenticationProtocol
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AuthenticationProtocol
  {
    Basic,
    Digest,
    Ntlm,
    Kerberos,
    Negotiate,
    CredSsp,
    Custom,
  }
}
