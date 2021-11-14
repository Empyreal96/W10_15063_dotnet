// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsEndUserMessageManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(810856026, 19743, 19289, 148, 51, 18, 108, 115, 78, 134, 166)]
  [ExclusiveTo(typeof (RcsEndUserMessageManager))]
  internal interface IRcsEndUserMessageManager
  {
    event TypedEventHandler<RcsEndUserMessageManager, RcsEndUserMessageAvailableEventArgs> MessageAvailableChanged;
  }
}
