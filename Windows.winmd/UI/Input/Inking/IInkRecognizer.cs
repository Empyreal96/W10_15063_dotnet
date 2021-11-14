// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkRecognizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(125619875, 36941, 17450, 177, 81, 170, 202, 54, 49, 196, 59)]
  [ExclusiveTo(typeof (InkRecognizer))]
  internal interface IInkRecognizer
  {
    string Name { get; }
  }
}
