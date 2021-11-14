// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ICommunicationBlockingAppSetAsActiveTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.CommunicationBlocking;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (CommunicationBlockingAppSetAsActiveTrigger))]
  [ContractVersion(typeof (CommunicationBlockingContract), 65536)]
  [Guid(4220646026, 5797, 18541, 151, 76, 120, 53, 168, 71, 123, 226)]
  internal interface ICommunicationBlockingAppSetAsActiveTrigger : IBackgroundTrigger
  {
  }
}
