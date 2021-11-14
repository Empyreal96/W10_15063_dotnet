// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynProducerStoppedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(1362138992, 18743, 18733, 128, 128, 35, 100, 57, 152, 124, 235)]
  [ExclusiveTo(typeof (AllJoynProducerStoppedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynProducerStoppedEventArgs
  {
    int Status { get; }
  }
}
