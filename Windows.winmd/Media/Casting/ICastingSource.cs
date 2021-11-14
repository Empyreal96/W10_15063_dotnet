// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [Guid(4096387698, 13415, 18406, 160, 39, 82, 41, 35, 233, 215, 39)]
  [ExclusiveTo(typeof (CastingSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICastingSource
  {
    Uri PreferredSourceUri { get; set; }
  }
}
