// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionJoinedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(2661243856, 46551, 18373, 141, 171, 176, 64, 204, 25, 40, 113)]
  [ExclusiveTo(typeof (AllJoynSessionJoinedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAllJoynSessionJoinedEventArgs
  {
    AllJoynSession Session { get; }
  }
}
