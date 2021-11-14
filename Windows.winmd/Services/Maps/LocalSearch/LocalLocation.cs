// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.LocalLocation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (LocalSearchContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class LocalLocation : ILocalLocation, ILocalLocation2
  {
    public extern MapAddress Address { [MethodImpl] get; }

    public extern string Identifier { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern Geopoint Point { [MethodImpl] get; }

    public extern string PhoneNumber { [MethodImpl] get; }

    public extern string DataAttribution { [MethodImpl] get; }

    public extern string Category { [MethodImpl] get; }

    public extern LocalLocationRatingInfo RatingInfo { [MethodImpl] get; }

    public extern IVectorView<LocalLocationHoursOfOperationItem> HoursOfOperation { [MethodImpl] get; }
  }
}
