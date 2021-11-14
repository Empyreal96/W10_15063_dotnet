// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.FriendGamer
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

namespace Microsoft.Xna.Framework.GamerServices
{
  public sealed class FriendGamer : Gamer
  {
    private string presence;
    private FriendState friendState;

    internal FriendGamer(uint kernelHandle)
      : base(kernelHandle)
    {
    }

    public string Presence => this.presence;

    public bool IsOnline => (uint) (this.friendState & FriendState.FriendIsOnline) > 0U;

    public bool IsPlaying => (uint) (this.friendState & FriendState.FriendIsPlaying) > 0U;

    public bool IsJoinable => (uint) (this.friendState & FriendState.FriendIsJoinable) > 0U;

    public bool IsAway => (uint) (this.friendState & FriendState.FriendIsAway) > 0U;

    public bool IsBusy => (uint) (this.friendState & FriendState.FriendIsBusy) > 0U;

    public bool HasVoice => (uint) (this.friendState & FriendState.FriendHasVoice) > 0U;

    public bool FriendRequestReceivedFrom => (uint) (this.friendState & FriendState.FriendRequestReceivedFrom) > 0U;

    public bool FriendRequestSentTo => (uint) (this.friendState & FriendState.FriendRequestSentTo) > 0U;

    public bool InviteReceivedFrom => (uint) (this.friendState & FriendState.InviteReceivedFrom) > 0U;

    public bool InviteSentTo => (uint) (this.friendState & FriendState.InviteSentTo) > 0U;

    public bool InviteAccepted => (uint) (this.friendState & FriendState.InviteAccepted) > 0U;

    public bool InviteRejected => (uint) (this.friendState & FriendState.InviteRejected) > 0U;
  }
}
