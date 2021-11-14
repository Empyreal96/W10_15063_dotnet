// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynServiceInfoStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynServiceInfo))]
  [Guid(1450727178, 24634, 18940, 183, 80, 14, 241, 54, 9, 33, 60)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAllJoynServiceInfoStatics
  {
    [RemoteAsync]
    IAsyncOperation<AllJoynServiceInfo> FromIdAsync(string deviceId);
  }
}
