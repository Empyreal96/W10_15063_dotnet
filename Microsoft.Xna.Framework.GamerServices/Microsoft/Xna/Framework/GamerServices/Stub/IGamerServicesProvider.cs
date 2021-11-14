// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.Stub.IGamerServicesProvider
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using GamerServices.Platforms.Web;
using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft.Xna.Framework.GamerServices.Stub
{
  internal interface IGamerServicesProvider
  {
    event EventHandler<GSSignedInStatusChangedEventArgs> SignedInStatusChanged;

    event EventHandler<GSWriteLeaderboardEventArgs> WriteLeaderboard;

    void Initialize();

    void Update();

    void FillGamer(int gamer, IPropertyFiller filler);

    IAsyncResult BeginFillProfile(int gamer, AsyncCallback callback, object asyncState);

    void EndFillProfile(IAsyncResult result, IPropertyFiller filler);

    IAsyncResult BeginGetGamerFromGamertag(
      string gamertag,
      AsyncCallback callback,
      object asyncState);

    void EndGetGamerFromGamertag(IAsyncResult result, IPropertyFiller filler);

    IAsyncResult BeginGetPartnerToken(
      string audienceUri,
      AsyncCallback callback,
      object asyncState);

    string EndGetPartnerToken(IAsyncResult result);

    void InvokeDownloadPrivilegeOptions();

    int FillFriendCollection(int gamer, IPropertyCollectionFiller fillers);

    void DisposeGamer(int gamerHandle);

    void DisposeFriendCollection(int friendsHandle);

    bool IsFriend(int gamer1, int gamer2);

    Stream GetStream(int handle);

    int CreateStream(byte[] buffer, int size);

    void WritePresence(int gamer, string presence);

    void WritePresence(int gamer, int presenceMode, int presenceValue);

    IAsyncResult BeginGetAchievements(
      int gamer,
      AsyncCallback callback,
      object asyncState);

    void EndGetAchievements(IAsyncResult result, IPropertyCollectionFiller fillers);

    IAsyncResult BeginAwardAchievement(
      int gamer,
      string achievementKey,
      AsyncCallback callback,
      object asyncState);

    void EndAward(IAsyncResult result);

    IAsyncResult BeginReadLeaderboard(
      LeaderboardIdentity leaderboardId,
      IEnumerable<int> gamerHandles,
      int pivotGamer,
      int pageStart,
      int pageSize,
      AsyncCallback callback,
      object asyncState);

    GSLeaderboard EndReadLeaderboard(
      IAsyncResult result,
      IPropertyCollectionFiller fillers);

    void FillLeaderboardColumns(
      LeaderboardIdentity leaderboardId,
      bool reading,
      ILeaderboardColumnFiller columnFiller);

    void WriteToLeaderboard(LeaderboardIdentity leaderboardId, IPropertyCollectionFiller fillers);

    IAsyncResult QueueAsyncTask(
      LIVEnTask task,
      AsyncCallback callback,
      object asyncState);
  }
}
