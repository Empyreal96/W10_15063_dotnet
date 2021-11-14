// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Realworld.Speech.SpeechScenarios
// Assembly: PhoneInternal.Realworld, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: BB230F34-74A2-4E99-8FA1-8CEC24DFDAE5
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Realworld.winmd

using System;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Realworld.Speech
{
  [Version(100859904)]
  [Flags]
  public enum SpeechScenarios : uint
  {
    All = 0,
    VoiceCommand = 1,
    Alarms = 2,
    AudioSearch = 4,
    Calendar = 8,
    ContactNickname = 16, // 0x00000010
    Conversation = 32, // 0x00000020
    Dialer = 64, // 0x00000040
    Music = 128, // 0x00000080
    Notes = 256, // 0x00000100
    DeviceSearch = 512, // 0x00000200
    Reminder = 1024, // 0x00000400
    Settings = 2048, // 0x00000800
    Pronouncer = 4096, // 0x00001000
    StartMenu = 8192, // 0x00002000
    TextMessage = 16384, // 0x00004000
    Common = 32768, // 0x00008000
    Samples = 65536, // 0x00010000
    NonCortanaFind = 131072, // 0x00020000
    Conversation_CAT2 = 262144, // 0x00040000
    Conversation_CAT3 = 524288, // 0x00080000
    Invalid = 2147483648, // 0x80000000
  }
}
