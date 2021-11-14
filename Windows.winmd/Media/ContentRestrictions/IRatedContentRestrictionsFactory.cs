// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.IRatedContentRestrictionsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RatedContentRestrictions))]
  [Guid(4216007062, 50109, 18704, 150, 25, 151, 207, 208, 105, 77, 86)]
  internal interface IRatedContentRestrictionsFactory
  {
    RatedContentRestrictions CreateWithMaxAgeRating(uint maxAgeRating);
  }
}
