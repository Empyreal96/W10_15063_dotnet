// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionListConstraintFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechRecognitionListConstraint))]
  [Guid(1089719751, 22058, 17002, 159, 59, 59, 78, 40, 43, 225, 213)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechRecognitionListConstraintFactory
  {
    SpeechRecognitionListConstraint Create(IIterable<string> commands);

    SpeechRecognitionListConstraint CreateWithTag(
      IIterable<string> commands,
      string tag);
  }
}
