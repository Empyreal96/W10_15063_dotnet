// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.CredentialPickerOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials.UI
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CredentialPickerOptions : ICredentialPickerOptions
  {
    [MethodImpl]
    public extern CredentialPickerOptions();

    public extern string Caption { [MethodImpl] set; [MethodImpl] get; }

    public extern string Message { [MethodImpl] set; [MethodImpl] get; }

    public extern uint ErrorCode { [MethodImpl] set; [MethodImpl] get; }

    public extern string TargetName { [MethodImpl] set; [MethodImpl] get; }

    public extern AuthenticationProtocol AuthenticationProtocol { [MethodImpl] set; [MethodImpl] get; }

    public extern string CustomAuthenticationProtocol { [MethodImpl] set; [MethodImpl] get; }

    public extern IBuffer PreviousCredential { [MethodImpl] set; [MethodImpl] get; }

    public extern bool AlwaysDisplayDialog { [MethodImpl] set; [MethodImpl] get; }

    public extern bool CallerSavesCredential { [MethodImpl] set; [MethodImpl] get; }

    public extern CredentialSaveOption CredentialSaveOption { [MethodImpl] set; [MethodImpl] get; }
  }
}
