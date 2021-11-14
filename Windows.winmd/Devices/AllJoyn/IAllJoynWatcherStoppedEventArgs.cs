// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynWatcherStoppedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynWatcherStoppedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3388776507, 28701, 19112, 151, 221, 162, 187, 10, 143, 95, 163)]
  internal interface IAllJoynWatcherStoppedEventArgs
  {
    int Status { get; }
  }
}
