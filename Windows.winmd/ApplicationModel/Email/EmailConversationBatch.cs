// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailConversationBatch
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailConversationBatch : IEmailConversationBatch
  {
    public extern IVectorView<EmailConversation> Conversations { [MethodImpl] get; }

    public extern EmailBatchStatus Status { [MethodImpl] get; }
  }
}
