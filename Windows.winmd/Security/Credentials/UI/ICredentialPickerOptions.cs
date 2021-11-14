// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.ICredentialPickerOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials.UI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2522483532, 38394, 18047, 153, 43, 11, 34, 229, 133, 155, 246)]
  [ExclusiveTo(typeof (CredentialPickerOptions))]
  internal interface ICredentialPickerOptions
  {
    string Caption { set; get; }

    string Message { set; get; }

    uint ErrorCode { set; get; }

    string TargetName { set; get; }

    AuthenticationProtocol AuthenticationProtocol { set; get; }

    string CustomAuthenticationProtocol { set; get; }

    IBuffer PreviousCredential { set; get; }

    bool AlwaysDisplayDialog { set; get; }

    bool CallerSavesCredential { set; get; }

    CredentialSaveOption CredentialSaveOption { set; get; }
  }
}
