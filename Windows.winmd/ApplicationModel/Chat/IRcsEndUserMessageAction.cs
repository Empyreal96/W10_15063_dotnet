// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsEndUserMessageAction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (RcsEndUserMessageAction))]
  [Guid(2453112631, 39746, 18131, 157, 94, 60, 27, 45, 174, 124, 184)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRcsEndUserMessageAction
  {
    string Label { get; }
  }
}
