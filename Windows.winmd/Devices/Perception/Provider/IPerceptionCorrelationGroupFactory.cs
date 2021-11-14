// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionCorrelationGroupFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [Deprecated("PerceptionCorrelationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionCorrelationGroup))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2113806472, 25567, 18669, 131, 177, 74, 184, 41, 19, 41, 149)]
  internal interface IPerceptionCorrelationGroupFactory
  {
    [Deprecated("PerceptionCorrelationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionCorrelationGroup Create(
      IIterable<PerceptionCorrelation> relativeLocations);
  }
}
