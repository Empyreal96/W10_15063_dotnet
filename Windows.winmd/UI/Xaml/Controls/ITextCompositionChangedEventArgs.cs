// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextCompositionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextCompositionChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3116884210, 20663, 17437, 153, 12, 104, 85, 62, 46, 5, 107)]
  [WebHostHidden]
  internal interface ITextCompositionChangedEventArgs
  {
    int StartIndex { get; }

    int Length { get; }
  }
}
