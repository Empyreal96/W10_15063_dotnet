﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageTransportConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.ApplicationModel.Chat
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessageTransportConfiguration : IChatMessageTransportConfiguration
  {
    public extern int MaxAttachmentCount { [MethodImpl] get; }

    public extern int MaxMessageSizeInKilobytes { [MethodImpl] get; }

    public extern int MaxRecipientCount { [MethodImpl] get; }

    public extern MediaEncodingProfile SupportedVideoFormat { [MethodImpl] get; }

    public extern IMapView<string, object> ExtendedProperties { [MethodImpl] get; }
  }
}
