// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynAboutData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AllJoynAboutData : IAllJoynAboutData
  {
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern string DefaultAppName { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, string> AppNames { [MethodImpl] get; }

    public extern IReference<global::Windows.Foundation.DateTime> DateOfManufacture { [MethodImpl] get; [MethodImpl] set; }

    public extern string DefaultDescription { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, string> Descriptions { [MethodImpl] get; }

    public extern string DefaultManufacturer { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, string> Manufacturers { [MethodImpl] get; }

    public extern string ModelNumber { [MethodImpl] get; [MethodImpl] set; }

    public extern string SoftwareVersion { [MethodImpl] get; [MethodImpl] set; }

    public extern global::Windows.Foundation.Uri SupportUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid AppId { [MethodImpl] get; [MethodImpl] set; }
  }
}
