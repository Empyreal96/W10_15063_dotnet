// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Radios.IRadio
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Radios
{
  [Guid(622926047, 45886, 16746, 135, 95, 28, 243, 138, 226, 216, 62)]
  [ExclusiveTo(typeof (Radio))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRadio
  {
    [RemoteAsync]
    IAsyncOperation<RadioAccessStatus> SetStateAsync(
      RadioState value);

    event TypedEventHandler<Radio, object> StateChanged;

    RadioState State { get; }

    string Name { get; }

    RadioKind Kind { get; }
  }
}
