// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DModel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  public sealed class Printing3DModel : IPrinting3DModel, IPrinting3DModel2
  {
    [MethodImpl]
    public extern Printing3DModel();

    public extern Printing3DModelUnit Unit { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<Printing3DModelTexture> Textures { [MethodImpl] get; }

    public extern IVector<Printing3DMesh> Meshes { [MethodImpl] get; }

    public extern IVector<Printing3DComponent> Components { [MethodImpl] get; }

    public extern Printing3DMaterial Material { [MethodImpl] get; [MethodImpl] set; }

    public extern Printing3DComponent Build { [MethodImpl] get; [MethodImpl] set; }

    public extern string Version { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> RequiredExtensions { [MethodImpl] get; }

    public extern IMap<string, string> Metadata { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RepairAsync();

    [MethodImpl]
    public extern Printing3DModel Clone();

    [RemoteAsync]
    [Overload("TryPartialRepairAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryPartialRepairAsync();

    [Overload("TryPartialRepairWithTimeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryPartialRepairAsync(TimeSpan maxWaitTime);

    [Overload("TryReduceFacesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<bool, double> TryReduceFacesAsync();

    [Overload("TryReduceFacesWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<bool, double> TryReduceFacesAsync(
      Printing3DFaceReductionOptions printing3DFaceReductionOptions);

    [Overload("TryReduceFacesWithOptionsAndTimeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<bool, double> TryReduceFacesAsync(
      Printing3DFaceReductionOptions printing3DFaceReductionOptions,
      TimeSpan maxWait);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<bool, double> RepairWithProgressAsync();
  }
}
