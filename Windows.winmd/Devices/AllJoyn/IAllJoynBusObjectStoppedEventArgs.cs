// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusObjectStoppedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3725598997, 61326, 19778, 185, 59, 162, 174, 116, 81, 151, 102)]
  [ExclusiveTo(typeof (AllJoynBusObjectStoppedEventArgs))]
  internal interface IAllJoynBusObjectStoppedEventArgs
  {
    int Status { get; }
  }
}
