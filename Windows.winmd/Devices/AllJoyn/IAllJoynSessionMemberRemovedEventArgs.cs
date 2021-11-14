// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionMemberRemovedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynSessionMemberRemovedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1083842975, 43594, 18579, 180, 48, 186, 161, 182, 60, 98, 25)]
  internal interface IAllJoynSessionMemberRemovedEventArgs
  {
    string UniqueName { get; }
  }
}
