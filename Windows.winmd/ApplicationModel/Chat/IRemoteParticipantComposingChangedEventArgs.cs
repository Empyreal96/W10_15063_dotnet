// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRemoteParticipantComposingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(515917223, 53193, 17865, 152, 118, 68, 159, 43, 193, 128, 245)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RemoteParticipantComposingChangedEventArgs))]
  internal interface IRemoteParticipantComposingChangedEventArgs
  {
    string TransportId { get; }

    string ParticipantAddress { get; }

    bool IsComposing { get; }
  }
}
