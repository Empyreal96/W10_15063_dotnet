// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Collation.ICharacterGroupingsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Collation
{
  [ExclusiveTo(typeof (CharacterGroupings))]
  [Guid(2582290393, 34925, 17409, 159, 152, 105, 200, 45, 76, 47, 120)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ICharacterGroupingsFactory
  {
    CharacterGroupings Create(string language);
  }
}
