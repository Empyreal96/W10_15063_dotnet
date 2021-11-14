// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataTransferManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataTransferManager))]
  [Guid(816741745, 35752, 19458, 142, 63, 221, 178, 59, 56, 135, 21)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IDataTransferManager2
  {
    event TypedEventHandler<DataTransferManager, ShareProvidersRequestedEventArgs> ShareProvidersRequested;
  }
}
