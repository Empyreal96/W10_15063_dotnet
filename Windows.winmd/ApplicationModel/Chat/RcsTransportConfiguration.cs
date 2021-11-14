// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsTransportConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RcsTransportConfiguration : IRcsTransportConfiguration
  {
    public extern int MaxAttachmentCount { [MethodImpl] get; }

    public extern int MaxMessageSizeInKilobytes { [MethodImpl] get; }

    public extern int MaxGroupMessageSizeInKilobytes { [MethodImpl] get; }

    public extern int MaxRecipientCount { [MethodImpl] get; }

    public extern int MaxFileSizeInKilobytes { [MethodImpl] get; }

    public extern int WarningFileSizeInKilobytes { [MethodImpl] get; }
  }
}
