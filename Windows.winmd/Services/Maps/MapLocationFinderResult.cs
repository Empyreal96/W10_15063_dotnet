// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapLocationFinderResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class MapLocationFinderResult : IMapLocationFinderResult
  {
    public extern IVectorView<MapLocation> Locations { [MethodImpl] get; }

    public extern MapLocationFinderStatus Status { [MethodImpl] get; }
  }
}
