// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynWatcherStoppedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(2274338216, 11600, 18401, 144, 74, 32, 191, 13, 72, 199, 130)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynWatcherStoppedEventArgs))]
  internal interface IAllJoynWatcherStoppedEventArgsFactory
  {
    AllJoynWatcherStoppedEventArgs Create(int status);
  }
}
