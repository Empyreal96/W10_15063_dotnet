// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.CommunicationBlocking.ICommunicationBlockingAppManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.CommunicationBlocking
{
  [ExclusiveTo(typeof (CommunicationBlockingAppManager))]
  [ContractVersion(typeof (CommunicationBlockingContract), 131072)]
  [Guid(346459869, 60808, 17786, 163, 100, 163, 99, 77, 111, 22, 109)]
  internal interface ICommunicationBlockingAppManagerStatics2 : 
    ICommunicationBlockingAppManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<bool> RequestSetAsActiveBlockingAppAsync();
  }
}
