// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynServiceInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynServiceInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1287553545, 47422, 16770, 153, 155, 221, 208, 0, 249, 197, 117)]
  internal interface IAllJoynServiceInfo
  {
    string UniqueName { get; }

    string ObjectPath { get; }

    ushort SessionPort { get; }
  }
}
