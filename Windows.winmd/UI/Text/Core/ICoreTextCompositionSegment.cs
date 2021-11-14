// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextCompositionSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextCompositionSegment))]
  [Guid(2003594201, 20141, 19879, 143, 71, 58, 136, 181, 35, 204, 52)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreTextCompositionSegment
  {
    string PreconversionString { get; }

    CoreTextRange Range { get; }
  }
}
