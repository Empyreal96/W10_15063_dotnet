// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(989820860, 14793, 19921, 173, 45, 57, 100, 221, 157, 64, 63)]
  [ExclusiveTo(typeof (ChatCapabilities))]
  internal interface IChatCapabilities
  {
    bool IsOnline { get; }

    bool IsChatCapable { get; }

    bool IsFileTransferCapable { get; }

    bool IsGeoLocationPushCapable { get; }

    bool IsIntegratedMessagingCapable { get; }
  }
}
