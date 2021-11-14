// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.CredentialPicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICredentialPickerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class CredentialPicker
  {
    [Overload("PickWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<CredentialPickerResults> PickAsync(
      CredentialPickerOptions options);

    [RemoteAsync]
    [Overload("PickWithMessageAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<CredentialPickerResults> PickAsync(
      string targetName,
      string message);

    [Overload("PickWithCaptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CredentialPickerResults> PickAsync(
      string targetName,
      string message,
      string caption);
  }
}
