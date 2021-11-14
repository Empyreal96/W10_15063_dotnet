// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextCompositionEndedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1189301682, 30656, 16405, 142, 180, 146, 238, 253, 252, 89, 20)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextCompositionEndedEventArgs))]
  internal interface ITextCompositionEndedEventArgs
  {
    int StartIndex { get; }

    int Length { get; }
  }
}
