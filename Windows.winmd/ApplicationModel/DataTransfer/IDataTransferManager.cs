// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataTransferManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataTransferManager))]
  [Guid(2781539995, 34568, 18897, 141, 54, 103, 210, 90, 141, 160, 12)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataTransferManager
  {
    event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> DataRequested;

    event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> TargetApplicationChosen;
  }
}
