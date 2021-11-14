// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataProviderRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataProviderRequest : IDataProviderRequest
  {
    public extern string FormatId { [MethodImpl] get; }

    public extern DateTime Deadline { [MethodImpl] get; }

    [MethodImpl]
    public extern DataProviderDeferral GetDeferral();

    [MethodImpl]
    public extern void SetData([HasVariant] object value);
  }
}
