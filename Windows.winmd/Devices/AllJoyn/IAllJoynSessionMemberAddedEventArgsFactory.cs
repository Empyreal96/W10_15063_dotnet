// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionMemberAddedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(874373970, 7475, 16545, 161, 211, 229, 119, 112, 32, 225, 241)]
  [ExclusiveTo(typeof (AllJoynSessionMemberAddedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynSessionMemberAddedEventArgsFactory
  {
    AllJoynSessionMemberAddedEventArgs Create(string uniqueName);
  }
}
