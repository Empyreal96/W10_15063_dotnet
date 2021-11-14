// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.NetworkInterfaceInfo
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace Microsoft.Phone.Net.NetworkInformation
{
  public sealed class NetworkInterfaceInfo
  {
    internal string m_UnderlyingInterfaceName;
    internal string m_PublicInterfaceName;
    internal string m_Description;
    internal ConnectState m_InterfaceState;
    internal NetworkInterfaceType m_InterfaceType;
    internal NetworkInterfaceSubType m_InterfaceSubtype;
    internal int m_Bandwidth;
    internal NetworkCharacteristics m_Characteristics;

    internal NetworkInterfaceInfo()
    {
    }

    public string InterfaceName => this.m_PublicInterfaceName;

    public string Description => this.m_Description;

    public ConnectState InterfaceState => this.m_InterfaceState;

    public NetworkInterfaceType InterfaceType => this.m_InterfaceType;

    public NetworkInterfaceSubType InterfaceSubtype => this.m_InterfaceSubtype;

    public int Bandwidth => this.m_Bandwidth;

    public NetworkCharacteristics Characteristics => this.m_Characteristics;

    internal bool IsSoftwareLoopback { get; set; }
  }
}
