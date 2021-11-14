// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IGeneratorPositionHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2906691021, 24812, 17800, 141, 96, 57, 210, 144, 151, 164, 223)]
  [ExclusiveTo(typeof (GeneratorPositionHelper))]
  [WebHostHidden]
  internal interface IGeneratorPositionHelperStatics
  {
    GeneratorPosition FromIndexAndOffset(int index, int offset);
  }
}
