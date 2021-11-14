// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.PasswordCredential
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ICredentialFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PasswordCredential : IPasswordCredential
  {
    [MethodImpl]
    public extern PasswordCredential(string resource, string userName, string password);

    [MethodImpl]
    public extern PasswordCredential();

    public extern string Resource { [MethodImpl] get; [MethodImpl] set; }

    public extern string UserName { [MethodImpl] get; [MethodImpl] set; }

    public extern string Password { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void RetrievePassword();

    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
