// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Collation.ICharacterGrouping
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Collation
{
  [Guid(4209467835, 32861, 19376, 149, 187, 193, 247, 195, 232, 235, 142)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CharacterGrouping))]
  internal interface ICharacterGrouping
  {
    string First { get; }

    string Label { get; }
  }
}
