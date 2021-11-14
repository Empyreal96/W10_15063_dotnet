// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.CredentialPickerResults
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials.UI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CredentialPickerResults : ICredentialPickerResults
  {
    public extern uint ErrorCode { [MethodImpl] get; }

    public extern CredentialSaveOption CredentialSaveOption { [MethodImpl] get; }

    public extern bool CredentialSaved { [MethodImpl] get; }

    public extern IBuffer Credential { [MethodImpl] get; }

    public extern string CredentialDomainName { [MethodImpl] get; }

    public extern string CredentialUserName { [MethodImpl] get; }

    public extern string CredentialPassword { [MethodImpl] get; }
  }
}
