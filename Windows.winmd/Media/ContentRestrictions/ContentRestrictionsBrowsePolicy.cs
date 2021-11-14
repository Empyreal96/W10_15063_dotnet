// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.ContentRestrictionsBrowsePolicy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContentRestrictionsBrowsePolicy : IContentRestrictionsBrowsePolicy
  {
    public extern string GeographicRegion { [MethodImpl] get; }

    public extern IReference<uint> MaxBrowsableAgeRating { [MethodImpl] get; }

    public extern IReference<uint> PreferredAgeRating { [MethodImpl] get; }
  }
}
