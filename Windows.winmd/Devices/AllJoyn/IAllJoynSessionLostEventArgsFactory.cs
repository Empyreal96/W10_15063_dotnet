// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionLostEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(331087154, 54004, 18889, 152, 14, 40, 5, 225, 53, 134, 177)]
  [ExclusiveTo(typeof (AllJoynSessionLostEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynSessionLostEventArgsFactory
  {
    AllJoynSessionLostEventArgs Create(AllJoynSessionLostReason reason);
  }
}
