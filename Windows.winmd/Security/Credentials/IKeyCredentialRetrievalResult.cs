// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IKeyCredentialRetrievalResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [Guid(1489860355, 36231, 16969, 155, 88, 246, 89, 140, 201, 100, 78)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyCredentialRetrievalResult))]
  internal interface IKeyCredentialRetrievalResult
  {
    KeyCredential Credential { get; }

    KeyCredentialStatus Status { get; }
  }
}
