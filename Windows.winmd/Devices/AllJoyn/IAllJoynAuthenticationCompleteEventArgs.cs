// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAuthenticationCompleteEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynAuthenticationCompleteEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2545184796, 5596, 19283, 182, 164, 125, 19, 67, 0, 215, 191)]
  internal interface IAllJoynAuthenticationCompleteEventArgs
  {
    AllJoynAuthenticationMechanism AuthenticationMechanism { get; }

    string PeerUniqueName { get; }

    bool Succeeded { get; }
  }
}
