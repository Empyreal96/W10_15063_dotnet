// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsEndUserMessageAvailableEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RcsEndUserMessageAvailableEventArgs))]
  [Guid(759541249, 16265, 16874, 151, 2, 158, 158, 212, 17, 170, 152)]
  internal interface IRcsEndUserMessageAvailableEventArgs
  {
    bool IsMessageAvailable { get; }

    RcsEndUserMessage Message { get; }
  }
}
