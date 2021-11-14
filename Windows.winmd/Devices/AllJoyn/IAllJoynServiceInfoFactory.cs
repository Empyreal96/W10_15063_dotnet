// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynServiceInfoFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1971444413, 65027, 20299, 148, 164, 240, 47, 220, 189, 17, 184)]
  [ExclusiveTo(typeof (AllJoynServiceInfo))]
  internal interface IAllJoynServiceInfoFactory
  {
    AllJoynServiceInfo Create(
      string uniqueName,
      string objectPath,
      ushort sessionPort);
  }
}
