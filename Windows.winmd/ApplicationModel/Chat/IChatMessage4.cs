// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessage4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(756304655, 53951, 17932, 170, 104, 109, 63, 132, 131, 201, 191)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ChatMessage))]
  internal interface IChatMessage4 : IChatMessage
  {
    string SyncId { get; set; }
  }
}
