// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynCredentialsRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1787290446, 45161, 19328, 158, 26, 65, 188, 131, 124, 101, 210)]
  [ExclusiveTo(typeof (AllJoynCredentialsRequestedEventArgs))]
  internal interface IAllJoynCredentialsRequestedEventArgs
  {
    ushort AttemptCount { get; }

    AllJoynCredentials Credentials { get; }

    string PeerUniqueName { get; }

    string RequestedUserName { get; }

    Deferral GetDeferral();
  }
}
