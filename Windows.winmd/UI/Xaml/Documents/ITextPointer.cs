// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextPointer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(2892528289, 27201, 17407, 133, 30, 69, 52, 138, 162, 207, 123)]
  [ExclusiveTo(typeof (TextPointer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ITextPointer
  {
    DependencyObject Parent { get; }

    FrameworkElement VisualParent { get; }

    LogicalDirection LogicalDirection { get; }

    int Offset { get; }

    Rect GetCharacterRect(LogicalDirection direction);

    TextPointer GetPositionAtOffset(int offset, LogicalDirection direction);
  }
}
