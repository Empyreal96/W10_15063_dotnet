// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IOperationCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (OperationCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3887018653, 1309, 20395, 177, 169, 71, 253, 119, 247, 10, 65)]
  internal interface IOperationCompletedEventArgs
  {
    DataPackageOperation Operation { get; }
  }
}
