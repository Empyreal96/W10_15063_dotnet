// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Chat.IChatMessageInternal
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.ApplicationModel.Chat;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Chat
{
  [Version(100859904)]
  [Guid(297222497, 5625, 18976, 179, 233, 98, 82, 36, 63, 29, 19)]
  public interface IChatMessageInternal
  {
    string From { get; set; }

    bool IsForwardingDisabled { get; set; }

    bool IsIncoming { get; set; }

    bool IsRead { get; set; }

    DateTime LocalTimestamp { get; set; }

    DateTime NetworkTimestamp { get; set; }

    ChatMessageStatus Status { get; set; }

    IAsyncAction SaveAsync();
  }
}
