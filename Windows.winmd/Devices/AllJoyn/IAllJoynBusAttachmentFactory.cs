// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusAttachmentFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynBusAttachment))]
  [Guid(1680798116, 44421, 19935, 144, 174, 96, 68, 82, 178, 34, 136)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynBusAttachmentFactory
  {
    AllJoynBusAttachment Create(string connectionSpecification);
  }
}
