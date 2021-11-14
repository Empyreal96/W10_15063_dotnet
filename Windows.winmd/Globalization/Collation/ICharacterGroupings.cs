// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Collation.ICharacterGroupings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Collation
{
  [ExclusiveTo(typeof (CharacterGroupings))]
  [Guid(3100772981, 54479, 16469, 128, 229, 206, 22, 156, 34, 100, 150)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICharacterGroupings : 
    IVectorView<CharacterGrouping>,
    IIterable<CharacterGrouping>
  {
    string Lookup(string text);
  }
}
