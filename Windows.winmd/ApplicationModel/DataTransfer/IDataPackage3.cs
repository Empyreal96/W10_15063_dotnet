// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackage3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataPackage))]
  [Guid(2297634653, 30843, 19762, 150, 90, 169, 131, 129, 5, 160, 86)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IDataPackage3
  {
    event TypedEventHandler<DataPackage, ShareCompletedEventArgs> ShareCompleted;
  }
}
