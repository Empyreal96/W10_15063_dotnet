// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocatorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(3077452608, 42946, 13851, 187, 130, 86, 233, 59, 137, 177, 187)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialLocator))]
  internal interface ISpatialLocatorStatics
  {
    SpatialLocator GetDefault();
  }
}
