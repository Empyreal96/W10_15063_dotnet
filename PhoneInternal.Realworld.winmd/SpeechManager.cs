// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Realworld.Speech.SpeechManager
// Assembly: PhoneInternal.Realworld, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: BB230F34-74A2-4E99-8FA1-8CEC24DFDAE5
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Realworld.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Realworld.Speech
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [Static(typeof (ISpeechManagerStatics), 100859904)]
  public static class SpeechManager
  {
    [MethodImpl]
    public static extern void PreInitialize();

    [MethodImpl]
    public static extern void UninitializeSpeechRecognition();

    [MethodImpl]
    public static extern void InvokeCortanaForExternalSpeechRecognition(string appId);

    public static extern bool IsCortanaEnabled { [MethodImpl] get; }
  }
}
