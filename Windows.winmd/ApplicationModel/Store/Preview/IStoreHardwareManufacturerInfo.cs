// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStoreHardwareManufacturerInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StoreHardwareManufacturerInfo))]
  [Guid(4069710856, 50772, 17324, 162, 31, 52, 128, 28, 157, 51, 136)]
  internal interface IStoreHardwareManufacturerInfo
  {
    string HardwareManufacturerId { get; }

    string StoreContentModifierId { get; }

    string ModelName { get; }

    string ManufacturerName { get; }
  }
}
