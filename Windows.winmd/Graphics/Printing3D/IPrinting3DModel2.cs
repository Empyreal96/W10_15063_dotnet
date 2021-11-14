// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DModel2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 196608)]
  [ExclusiveTo(typeof (Printing3DModel))]
  [Guid(3374344647, 51265, 18419, 168, 78, 161, 73, 253, 8, 182, 87)]
  internal interface IPrinting3DModel2
  {
    [Overload("TryPartialRepairAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryPartialRepairAsync();

    [RemoteAsync]
    [Overload("TryPartialRepairWithTimeAsync")]
    IAsyncOperation<bool> TryPartialRepairAsync(TimeSpan maxWaitTime);

    [Overload("TryReduceFacesAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<bool, double> TryReduceFacesAsync();

    [Overload("TryReduceFacesWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<bool, double> TryReduceFacesAsync(
      Printing3DFaceReductionOptions printing3DFaceReductionOptions);

    [RemoteAsync]
    [Overload("TryReduceFacesWithOptionsAndTimeAsync")]
    IAsyncOperationWithProgress<bool, double> TryReduceFacesAsync(
      Printing3DFaceReductionOptions printing3DFaceReductionOptions,
      TimeSpan maxWait);

    [RemoteAsync]
    IAsyncOperationWithProgress<bool, double> RepairWithProgressAsync();
  }
}
