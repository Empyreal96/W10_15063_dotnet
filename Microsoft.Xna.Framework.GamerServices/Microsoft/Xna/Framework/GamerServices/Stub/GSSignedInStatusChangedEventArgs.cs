// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.Stub.GSSignedInStatusChangedEventArgs
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;

namespace Microsoft.Xna.Framework.GamerServices.Stub
{
  internal class GSSignedInStatusChangedEventArgs : EventArgs
  {
    internal GSSignedInStatusChangedEventArgs(
      int gamer,
      int playerIndex,
      PlayerSignInState newState)
    {
      this.Gamer = gamer;
      this.PlayerIndex = playerIndex;
      this.SignInState = newState;
    }

    public int PlayerIndex { get; private set; }

    public int Gamer { get; private set; }

    public PlayerSignInState SignInState { get; private set; }
  }
}
