// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.LeaderboardEntryFiller
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class LeaderboardEntryFiller : BaseFiller, IPropertyFiller
  {
    internal LeaderboardEntry Target;
    internal GamerFiller GamerFiller;

    void IPropertyFiller.BeginFillData() => this.Target.Columns.BeginFillData();

    void IPropertyFiller.EndFillData() => this.Target.Columns.EndFillData();

    void IPropertyFiller.SetNamedValue(GSPropertyName name, int value)
    {
      switch (name)
      {
        case GSPropertyName.LeaderboardGamer:
          this.Target.Gamer = this.CreateGamer(value);
          break;
        case GSPropertyName.LeaderboardScoreBlob:
          this.SetStream("ScoreBlob", value);
          break;
        case GSPropertyName.LeaderboardTimeBlob:
          this.SetStream("TimeBlob", value);
          break;
        case GSPropertyName.LeaderboardAverageScore:
          this.Target.Columns.SetValue("AverageScore", value);
          break;
        case GSPropertyName.LeaderboardBestScoreBlob:
          this.SetStream("BestScoreBlob", value);
          break;
        case GSPropertyName.LeaderboardBestTimeBlob:
          this.SetStream("BestTimeBlob", value);
          break;
        default:
          this.SetNamedValue(name, value);
          break;
      }
    }

    void IPropertyFiller.SetNamedValue(GSPropertyName name, long value)
    {
      switch (name)
      {
        case GSPropertyName.LeaderboardScore:
          this.Target.Columns.SetValue("Score", value);
          break;
        case GSPropertyName.LeaderboardRating:
          this.Target.SetRating(value);
          break;
        case GSPropertyName.LeaderboardTime:
          this.Target.Columns.SetValue("Time", value);
          break;
        case GSPropertyName.LeaderboardTimeStamp:
          this.Target.Columns.SetValue("TimeStamp", value);
          break;
        case GSPropertyName.LeaderboardBestScore:
          this.Target.Columns.SetValue("BestScore", value);
          break;
        case GSPropertyName.LeaderboardBestTime:
          this.Target.Columns.SetValue("BestTime", value);
          break;
        case GSPropertyName.LeaderboardCumulativeScore:
          this.Target.Columns.SetValue("CumulativeScore", value);
          break;
        case GSPropertyName.LeaderboardCumulativeTime:
          this.Target.Columns.SetValue("CumulativeTime", value);
          break;
        case GSPropertyName.LeaderboardGamesPlayed:
          this.Target.Columns.SetValue("GamesPlayed", value);
          break;
        case GSPropertyName.LeaderboardAverageScore:
          this.Target.Columns.SetValue("AverageScore", value);
          break;
        case GSPropertyName.LeaderboardAverageTime:
          this.Target.Columns.SetValue("AverageTime", value);
          break;
        case GSPropertyName.LeaderboardWins:
          this.Target.Columns.SetValue("Wins", value);
          break;
        case GSPropertyName.LeaderboardLosses:
          this.Target.Columns.SetValue("Losses", value);
          break;
        case GSPropertyName.LeaderboardLastPlayedDateTime:
          this.Target.Columns.SetValue("LastPlayedDateTime", value);
          break;
        default:
          this.SetNamedValue(name, value);
          break;
      }
    }

    bool IPropertyFiller.TryGetNamedValue(GSPropertyName name, out string value)
    {
      bool flag = true;
      if (name == GSPropertyName.LeaderboardOutcome)
        value = this.Target.Columns.GetValueString("Outcome");
      else
        flag = this.TryGetNamedValue(name, out value);
      return flag;
    }

    bool IPropertyFiller.TryGetNamedValue(GSPropertyName name, out int value)
    {
      bool flag = true;
      switch (name)
      {
        case GSPropertyName.LeaderboardGamer:
          value = (int) this.Target.Gamer.KernelHandle;
          break;
        case GSPropertyName.LeaderboardOutcome:
          value = this.Target.Columns.GetValueInt32("Outcome");
          break;
        case GSPropertyName.LeaderboardScoreBlob:
          value = this.GetStreamHandle("ScoreBlob");
          break;
        case GSPropertyName.LeaderboardTimeBlob:
          value = this.GetStreamHandle("TimeBlob");
          break;
        default:
          flag = this.TryGetNamedValue(name, out value);
          break;
      }
      return flag;
    }

    bool IPropertyFiller.TryGetNamedValue(GSPropertyName name, out long value)
    {
      bool flag = true;
      switch (name)
      {
        case GSPropertyName.LeaderboardScore:
          value = this.Target.Columns.GetValueInt64("Score");
          break;
        case GSPropertyName.LeaderboardRating:
          value = this.Target.Rating;
          break;
        case GSPropertyName.LeaderboardTime:
          value = this.Target.Columns.GetValueInt64("Time");
          break;
        case GSPropertyName.LeaderboardTimeStamp:
          value = this.Target.Columns.GetValueInt64("TimeStamp");
          break;
        default:
          flag = this.TryGetNamedValue(name, out value);
          break;
      }
      return flag;
    }

    private void SetStream(string key, int handle)
    {
      if (!(this.Target.Columns.GetProperty(key, false) is StreamPropertyValue property))
        return;
      property.Handle = handle;
    }

    private int GetStreamHandle(string key) => this.Target.Columns.GetProperty(key, false) is StreamPropertyValue property ? property.Handle : 0;

    private Gamer CreateGamer(int handle)
    {
      Gamer gamer = (Gamer) new SocialGamer((uint) handle);
      this.GamerFiller.Target = gamer;
      GamerServicesDispatcher.Gsp.FillGamer(handle, (IPropertyFiller) this.GamerFiller);
      return gamer;
    }
  }
}
