// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.SpeechRecognizerInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpeechRecognizerInformation : ISpeechRecognizerInformation
  {
    public extern string DisplayName { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern string Language { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }
  }
}
