// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAcceptSessionJoinerEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynAcceptSessionJoinerEventArgs))]
  [Guid(3024313280, 24901, 17054, 132, 219, 213, 191, 231, 114, 177, 79)]
  internal interface IAllJoynAcceptSessionJoinerEventArgsFactory
  {
    AllJoynAcceptSessionJoinerEventArgs Create(
      string uniqueName,
      ushort sessionPort,
      AllJoynTrafficType trafficType,
      byte proximity,
      IAllJoynAcceptSessionJoiner acceptSessionJoiner);
  }
}
