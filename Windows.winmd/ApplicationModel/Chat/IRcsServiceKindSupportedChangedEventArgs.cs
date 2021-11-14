// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsServiceKindSupportedChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (RcsServiceKindSupportedChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4101939780, 59267, 18534, 179, 167, 78, 92, 207, 2, 48, 112)]
  internal interface IRcsServiceKindSupportedChangedEventArgs
  {
    RcsServiceKind ServiceKind { get; }
  }
}
