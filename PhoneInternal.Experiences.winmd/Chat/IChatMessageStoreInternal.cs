// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Chat.IChatMessageStoreInternal
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Chat
{
  [Guid(3119292780, 6230, 18802, 131, 186, 164, 193, 22, 28, 102, 242)]
  [Version(100859904)]
  public interface IChatMessageStoreInternal
  {
    IAsyncAction DeleteMessageAlwaysAsync(string localMessageId);
  }
}
