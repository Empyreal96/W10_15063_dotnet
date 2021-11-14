// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StoreHardwareManufacturerInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StoreHardwareManufacturerInfo : IStoreHardwareManufacturerInfo
  {
    public extern string HardwareManufacturerId { [MethodImpl] get; }

    public extern string StoreContentModifierId { [MethodImpl] get; }

    public extern string ModelName { [MethodImpl] get; }

    public extern string ManufacturerName { [MethodImpl] get; }
  }
}
