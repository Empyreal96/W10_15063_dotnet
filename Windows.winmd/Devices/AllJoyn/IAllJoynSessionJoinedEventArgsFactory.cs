// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionJoinedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(1747244681, 54987, 19870, 160, 158, 53, 128, 104, 112, 177, 127)]
  [ExclusiveTo(typeof (AllJoynSessionJoinedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAllJoynSessionJoinedEventArgsFactory
  {
    AllJoynSessionJoinedEventArgs Create(AllJoynSession session);
  }
}
