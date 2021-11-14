// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.MapsApplicationContext
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps
{
  public sealed class MapsApplicationContext
  {
    private const string DefaultApplicationId = "windowsphonedefaultappid";
    private const string DefaultAuthenticationToken = "Kly8Iip1ejSlCujfzW7UhA";
    private static readonly MapsApplicationContext instance = new MapsApplicationContext();
    private string applicationId = string.Empty;
    private string authenticationToken = string.Empty;

    private MapsApplicationContext()
    {
      if (!QuirksMode.ShouldMapsUseDefaultCredentials())
        return;
      Marshal.ThrowExceptionForHR(Shim.MapsSettings_SetApplicationId("windowsphonedefaultappid"));
      Marshal.ThrowExceptionForHR(Shim.MapsSettings_SetApplicationCode("Kly8Iip1ejSlCujfzW7UhA"));
    }

    public string ApplicationId
    {
      get => this.applicationId;
      set
      {
        if (value == null)
          value = string.Empty;
        if (value == this.applicationId)
          return;
        this.applicationId = value;
        Marshal.ThrowExceptionForHR(Shim.MapsSettings_SetApplicationId(this.applicationId));
      }
    }

    public string AuthenticationToken
    {
      get => this.authenticationToken;
      set
      {
        if (value == null)
          value = string.Empty;
        if (value == this.authenticationToken)
          return;
        this.authenticationToken = value;
        Marshal.ThrowExceptionForHR(Shim.MapsSettings_SetApplicationCode(this.authenticationToken));
      }
    }

    internal static MapsApplicationContext Instance => MapsApplicationContext.instance;
  }
}
