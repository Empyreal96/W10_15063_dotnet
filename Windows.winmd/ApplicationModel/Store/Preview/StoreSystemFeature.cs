// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StoreSystemFeature
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum StoreSystemFeature
  {
    ArchitectureX86,
    ArchitectureX64,
    ArchitectureArm,
    DirectX9,
    DirectX10,
    DirectX11,
    D3D12HardwareFL11,
    D3D12HardwareFL12,
    Memory300MB,
    Memory750MB,
    Memory1GB,
    Memory2GB,
    CameraFront,
    CameraRear,
    Gyroscope,
    Hover,
    Magnetometer,
    Nfc,
    Resolution720P,
    ResolutionWvga,
    ResolutionWvgaOr720P,
    ResolutionWxga,
    ResolutionWvgaOrWxga,
    ResolutionWxgaOr720P,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory4GB,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory6GB,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory8GB,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory12GB,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory16GB,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory20GB,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] VideoMemory2GB,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] VideoMemory4GB,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] VideoMemory6GB,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] VideoMemory1GB,
  }
}
