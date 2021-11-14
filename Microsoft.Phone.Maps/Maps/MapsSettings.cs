// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.MapsSettings
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Device.Location;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps
{
  public static class MapsSettings
  {
    public static MapsApplicationContext ApplicationContext => MapsApplicationContext.Instance;

    public static bool IsMapsDisabled => Shim.MapsSettings_IsMapsDisabled();

    internal static GeoCoordinate DefaultCenter
    {
      get
      {
        double latitude;
        double longitude;
        Marshal.ThrowExceptionForHR(Shim.MapsSettings_GetDefaultCenter(out latitude, out longitude));
        return new GeoCoordinate(latitude, longitude);
      }
    }

    internal static MosConnectivityStatus MosConnectivityStatus
    {
      get
      {
        MosConnectivityStatus status;
        Marshal.ThrowExceptionForHR(Shim.MapsSettings_GetMosConnectivityStatus(out status));
        return status;
      }
      set => Marshal.ThrowExceptionForHR(Shim.MapsSettings_SetMosConnectivityStatus(value));
    }
  }
}
