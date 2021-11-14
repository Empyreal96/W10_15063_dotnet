// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.ICredentialPickerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2855951475, 51690, 18306, 153, 251, 230, 215, 233, 56, 225, 45)]
  [ExclusiveTo(typeof (CredentialPicker))]
  internal interface ICredentialPickerStatics
  {
    [Overload("PickWithOptionsAsync")]
    IAsyncOperation<CredentialPickerResults> PickAsync(
      CredentialPickerOptions options);

    [Overload("PickWithMessageAsync")]
    [RemoteAsync]
    IAsyncOperation<CredentialPickerResults> PickAsync(
      string targetName,
      string message);

    [Overload("PickWithCaptionAsync")]
    [RemoteAsync]
    IAsyncOperation<CredentialPickerResults> PickAsync(
      string targetName,
      string message,
      string caption);
  }
}
