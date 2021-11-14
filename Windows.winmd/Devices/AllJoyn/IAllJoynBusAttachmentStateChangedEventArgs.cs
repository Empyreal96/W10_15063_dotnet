// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusAttachmentStateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(3626923508, 49194, 16876, 168, 213, 234, 177, 85, 137, 83, 170)]
  [ExclusiveTo(typeof (AllJoynBusAttachmentStateChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynBusAttachmentStateChangedEventArgs
  {
    AllJoynBusAttachmentState State { get; }

    int Status { get; }
  }
}
