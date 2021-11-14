// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionMemberRemovedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynSessionMemberRemovedEventArgs))]
  [Guid(3302184424, 17080, 19303, 183, 87, 208, 207, 202, 213, 146, 128)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynSessionMemberRemovedEventArgsFactory
  {
    AllJoynSessionMemberRemovedEventArgs Create(
      string uniqueName);
  }
}
