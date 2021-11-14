// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.ManagedCallType
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

namespace Microsoft.Xna.Framework
{
  internal enum ManagedCallType
  {
    NoManagedCall = 1,
    RunUnitTestDelegate = 2,
    AsyncOperationCompleted = 3,
    Media_ActiveSongChanged = 4,
    Media_PlayStateChanged = 5,
    Net_WriteLeaderboards = 6,
    System_DeviceChanged = 7,
    System_DownloadCompleted = 8,
    CaptureBufferReady = 9,
    PlaybackBufferNeeded = 10, // 0x0000000A
  }
}
