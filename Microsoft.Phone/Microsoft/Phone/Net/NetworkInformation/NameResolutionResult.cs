// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.NameResolutionResult
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Net;

namespace Microsoft.Phone.Net.NetworkInformation
{
  public sealed class NameResolutionResult
  {
    internal NetworkError errorCode;
    internal string hostname;
    internal IPEndPoint[] ipEndPoints;
    internal NetworkInterfaceInfo netInterface;
    internal object callbackContext;

    public NetworkError NetworkErrorCode => this.errorCode;

    public string HostName => this.hostname;

    public IPEndPoint[] IPEndPoints => this.ipEndPoints;

    public NetworkInterfaceInfo NetworkInterface => this.netInterface;

    public object AsyncState => this.callbackContext;
  }
}
