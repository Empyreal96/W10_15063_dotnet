// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAcceptSessionJoinerEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynAcceptSessionJoinerEventArgs))]
  [Guid(1325093733, 16010, 16983, 143, 16, 83, 156, 224, 213, 108, 15)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynAcceptSessionJoinerEventArgs
  {
    string UniqueName { get; }

    ushort SessionPort { get; }

    AllJoynTrafficType TrafficType { get; }

    bool SamePhysicalNode { get; }

    bool SameNetwork { get; }

    void Accept();
  }
}
