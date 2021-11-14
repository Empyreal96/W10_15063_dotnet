// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.CommunicationBlockingAppSetAsActiveTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.CommunicationBlocking;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingContract")]
  [ContractVersion(typeof (CommunicationBlockingContract), 65536)]
  public sealed class CommunicationBlockingAppSetAsActiveTrigger : 
    IBackgroundTrigger,
    ICommunicationBlockingAppSetAsActiveTrigger
  {
    [MethodImpl]
    public extern CommunicationBlockingAppSetAsActiveTrigger();
  }
}
