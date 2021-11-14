// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailIrmInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Activatable(typeof (IEmailIrmInfoFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailIrmInfo : IEmailIrmInfo
  {
    [MethodImpl]
    public extern EmailIrmInfo(DateTime expiration, EmailIrmTemplate irmTemplate);

    [MethodImpl]
    public extern EmailIrmInfo();

    public extern bool CanEdit { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanExtractData { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanForward { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanModifyRecipientsOnResponse { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanPrintData { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanRemoveIrmOnResponse { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanReply { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanReplyAll { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime ExpirationDate { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsIrmOriginator { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsProgramaticAccessAllowed { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailIrmTemplate Template { [MethodImpl] get; [MethodImpl] set; }
  }
}
