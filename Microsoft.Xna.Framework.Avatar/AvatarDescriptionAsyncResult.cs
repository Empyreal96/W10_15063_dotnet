// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AvatarDescriptionAsyncResult
// Assembly: Microsoft.Xna.Framework.Avatar, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8518E295-C4D7-45FF-B025-9F2E181C471E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFB9E~1.DLL

using System;
using System.Threading;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class AvatarDescriptionAsyncResult : IAsyncResult
  {
    private object syncObject;
    internal ManualResetEvent mre = new ManualResetEvent(true);

    internal AvatarDescriptionAsyncResult(object stateObject, int playerIndex)
    {
      this.syncObject = stateObject;
      this.PlayerIndex = playerIndex;
    }

    public object AsyncState => this.syncObject;

    public WaitHandle AsyncWaitHandle => (WaitHandle) this.mre;

    public bool CompletedSynchronously => true;

    public bool IsCompleted => this.mre.WaitOne(0);

    public int PlayerIndex { get; set; }
  }
}
