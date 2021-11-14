// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynProducerStoppedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(1448253793, 45593, 19822, 159, 120, 250, 63, 153, 250, 143, 229)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynProducerStoppedEventArgs))]
  internal interface IAllJoynProducerStoppedEventArgsFactory
  {
    AllJoynProducerStoppedEventArgs Create(int status);
  }
}
