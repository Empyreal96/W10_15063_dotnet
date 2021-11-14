// Decompiled with JetBrains decompiler
// Type: Windows.Networking.HostName
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHostNameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IHostNameFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HostName : IHostName, IStringable
  {
    [MethodImpl]
    public extern HostName(string hostName);

    public extern IPInformation IPInformation { [MethodImpl] get; }

    public extern string RawName { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern string CanonicalName { [MethodImpl] get; }

    public extern HostNameType Type { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IsEqual(HostName hostName);

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern int Compare(string value1, string value2);
  }
}
