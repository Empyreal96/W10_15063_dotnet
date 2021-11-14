// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialRetrievalResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class KeyCredentialRetrievalResult : IKeyCredentialRetrievalResult
  {
    public extern KeyCredential Credential { [MethodImpl] get; }

    public extern KeyCredentialStatus Status { [MethodImpl] get; }
  }
}
