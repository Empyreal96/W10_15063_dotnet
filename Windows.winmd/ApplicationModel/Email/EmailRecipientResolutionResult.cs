// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailRecipientResolutionResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class EmailRecipientResolutionResult : 
    IEmailRecipientResolutionResult,
    IEmailRecipientResolutionResult2
  {
    [MethodImpl]
    public extern EmailRecipientResolutionResult();

    public extern EmailRecipientResolutionStatus Status { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<Certificate> PublicKeys { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetPublicKeys(IIterable<Certificate> value);
  }
}
