// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.IRatedContentDescriptionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RatedContentDescription))]
  [Guid(775479138, 39824, 20390, 137, 193, 75, 141, 47, 251, 53, 115)]
  internal interface IRatedContentDescriptionFactory
  {
    RatedContentDescription Create(
      string id,
      string title,
      RatedContentCategory category);
  }
}
