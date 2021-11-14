// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.ICredentialPickerResults
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials.UI
{
  [ExclusiveTo(typeof (CredentialPickerResults))]
  [Guid(424212890, 52272, 16652, 156, 56, 204, 8, 132, 197, 179, 215)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICredentialPickerResults
  {
    uint ErrorCode { get; }

    CredentialSaveOption CredentialSaveOption { get; }

    bool CredentialSaved { get; }

    IBuffer Credential { get; }

    string CredentialDomainName { get; }

    string CredentialUserName { get; }

    string CredentialPassword { get; }
  }
}
