// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.MarshaledAddress
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Services
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  internal struct MarshaledAddress
  {
    [MarshalAs(UnmanagedType.LPWStr)]
    public string BuildingName;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string BuildingFloor;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string BuildingRoom;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string BuildingZone;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string HouseNumber;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string Street;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string Neighborhood;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string Township;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string District;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string City;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string County;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string Province;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string State;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string StateCode;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string Country;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string CountryCode;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string PostalCode;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string Continent;
  }
}
