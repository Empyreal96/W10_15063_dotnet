// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IPasswordCredential
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [Guid(1790019977, 50976, 16807, 166, 193, 254, 173, 179, 99, 41, 160)]
  [ExclusiveTo(typeof (PasswordCredential))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPasswordCredential
  {
    string Resource { get; set; }

    string UserName { get; set; }

    string Password { get; set; }

    void RetrievePassword();

    IPropertySet Properties { get; }
  }
}
