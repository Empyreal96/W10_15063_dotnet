// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextPhoneme
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (TextPhoneme))]
  [Guid(2472715274, 39802, 17769, 148, 207, 216, 79, 47, 56, 207, 155)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ITextPhoneme
  {
    string DisplayText { get; }

    string ReadingText { get; }
  }
}
