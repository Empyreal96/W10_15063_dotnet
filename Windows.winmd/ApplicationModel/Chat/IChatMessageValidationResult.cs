// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageValidationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageValidationResult))]
  [Guid(636041731, 10476, 22665, 86, 155, 126, 72, 107, 18, 111, 24)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageValidationResult
  {
    IReference<uint> MaxPartCount { get; }

    IReference<uint> PartCount { get; }

    IReference<uint> RemainingCharacterCountInPart { get; }

    ChatMessageValidationStatus Status { get; }
  }
}
