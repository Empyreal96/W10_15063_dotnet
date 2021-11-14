// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Realworld.Speech.ISpeechManagerStatics
// Assembly: PhoneInternal.Realworld, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: BB230F34-74A2-4E99-8FA1-8CEC24DFDAE5
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Realworld.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Realworld.Speech
{
  [Version(100859904)]
  [ExclusiveTo(typeof (SpeechManager))]
  [Guid(2124931642, 30803, 17337, 176, 21, 31, 183, 232, 249, 227, 226)]
  internal interface ISpeechManagerStatics
  {
    void PreInitialize();

    void UninitializeSpeechRecognition();

    void InvokeCortanaForExternalSpeechRecognition(string appId);

    bool IsCortanaEnabled { get; }
  }
}
