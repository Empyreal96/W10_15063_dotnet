// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageValidationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessageValidationResult : IChatMessageValidationResult
  {
    public extern IReference<uint> MaxPartCount { [MethodImpl] get; }

    public extern IReference<uint> PartCount { [MethodImpl] get; }

    public extern IReference<uint> RemainingCharacterCountInPart { [MethodImpl] get; }

    public extern ChatMessageValidationStatus Status { [MethodImpl] get; }
  }
}
