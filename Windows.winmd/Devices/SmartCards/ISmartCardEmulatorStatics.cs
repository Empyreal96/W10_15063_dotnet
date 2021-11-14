// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardEmulatorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [ExclusiveTo(typeof (SmartCardEmulator))]
  [Guid(2057043019, 50387, 18767, 184, 162, 98, 21, 216, 30, 133, 178)]
  internal interface ISmartCardEmulatorStatics
  {
    [RemoteAsync]
    IAsyncOperation<SmartCardEmulator> GetDefaultAsync();
  }
}
