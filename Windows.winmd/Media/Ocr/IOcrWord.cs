// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.IOcrWord
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Ocr
{
  [ExclusiveTo(typeof (OcrWord))]
  [Guid(1009403770, 23769, 13605, 186, 42, 35, 209, 224, 166, 138, 29)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOcrWord
  {
    Rect BoundingRect { get; }

    string Text { get; }
  }
}
