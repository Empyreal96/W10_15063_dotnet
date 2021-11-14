// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionLostEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynSessionLostEventArgs))]
  [Guid(3882263690, 35768, 18772, 174, 103, 210, 250, 67, 209, 249, 107)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynSessionLostEventArgs
  {
    AllJoynSessionLostReason Reason { get; }
  }
}
