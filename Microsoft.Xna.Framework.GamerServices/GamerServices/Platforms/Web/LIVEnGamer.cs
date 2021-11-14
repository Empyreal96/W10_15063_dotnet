// Decompiled with JetBrains decompiler
// Type: GamerServices.Platforms.Web.LIVEnGamer
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.GamerServices.LIVEn;
using Microsoft.Xna.Framework.GamerServices.Stub;
using System;

namespace GamerServices.Platforms.Web
{
  internal class LIVEnGamer
  {
    public int Handle;
    public string Gamertag;
    public string DisplayName;
    public PlayerSignInState SignInState;
    public int GamerScore;
    public int TotalAchievements;
    public int TitlePlayed;
    public float Reputation;
    public string Culture;
    public string Motto;
    public int GamerPicture;
    public GamerZone GamerZone;
    public GamerPrivilegeOptions Privileges;
    private DateTime LastFillDateTime = DateTime.MinValue;

    public void FillGamerProfile(IPropertyFiller filler)
    {
      filler.BeginFillData();
      filler.SetNamedValue(GSPropertyName.GamerHandle, this.Handle);
      filler.SetNamedValue(GSPropertyName.Gamertag, this.Gamertag);
      filler.SetNamedValue(GSPropertyName.DisplayName, this.DisplayName);
      filler.SetNamedValue(GSPropertyName.SignInState, (int) this.SignInState);
      filler.SetNamedValue(GSPropertyName.GamerScore, this.GamerScore);
      filler.SetNamedValue(GSPropertyName.GamerZone, (int) this.GamerZone);
      filler.SetNamedValue(GSPropertyName.Motto, this.Motto);
      filler.SetNamedValue(GSPropertyName.Reputation, this.Reputation);
      filler.SetNamedValue(GSPropertyName.TitlePlayed, this.TitlePlayed);
      filler.SetNamedValue(GSPropertyName.TotalAchievements, this.TotalAchievements);
      filler.SetNamedValue(GSPropertyName.PrivilegeOptions, (int) this.Privileges);
      filler.SetNamedValue(GSPropertyName.GamerPicture, this.GamerPicture);
      filler.SetNamedValue(GSPropertyName.Culture, this.Culture);
      this.LastFillDateTime = DateTime.Now;
      filler.EndFillData();
    }

    public void Touch() => this.LastFillDateTime = DateTime.MinValue;

    public bool IsDirty => DateTime.Now - this.LastFillDateTime > TimeSpan.FromSeconds(3.0);

    public bool UpdatePrivileges(ILIVEnService webService)
    {
      PlayerSignInState playerSignInState = webService.GetCurrentGamerPrivilegeOptions(out this.Privileges) ? PlayerSignInState.SignedInToLive : PlayerSignInState.SignedInLocally;
      int num = playerSignInState != this.SignInState ? 1 : 0;
      this.SignInState = playerSignInState;
      return num != 0;
    }
  }
}
