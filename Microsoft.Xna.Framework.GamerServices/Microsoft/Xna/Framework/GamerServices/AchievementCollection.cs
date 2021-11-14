// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AchievementCollection
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.GamerServices
{
  public sealed class AchievementCollection : 
    IList<Achievement>,
    ICollection<Achievement>,
    IEnumerable<Achievement>,
    IEnumerable,
    IDisposable
  {
    private List<Achievement> achievements;
    private Dictionary<string, Achievement> achievementDictionary = new Dictionary<string, Achievement>();
    private bool isDisposed;

    internal AchievementCollection(List<Achievement> achievements)
    {
      this.achievements = achievements;
      achievements.Sort(new Comparison<Achievement>(AchievementCollection.CompareAchievements));
      foreach (Achievement achievement in achievements)
        this.achievementDictionary.Add(achievement.Key, achievement);
    }

    public void Dispose()
    {
      foreach (Achievement achievement in this.achievements)
        achievement.Dispose();
      this.isDisposed = true;
    }

    public bool IsDisposed => this.isDisposed;

    public Achievement this[int index] => this.achievements[index];

    public Achievement this[string achievementKey] => this.achievementDictionary[achievementKey];

    private static int CompareAchievements(Achievement a, Achievement b)
    {
      int num1 = AchievementCollection.RateAchievement(a);
      int num2 = AchievementCollection.RateAchievement(b);
      if (num1 != num2)
        return num1.CompareTo(num2);
      return a.IsEarned ? b.EarnedDateTime.CompareTo(a.EarnedDateTime) : a.Id.CompareTo(b.Id);
    }

    private static int RateAchievement(Achievement a)
    {
      if (a.IsEarned)
        return 1;
      return a.DisplayBeforeEarned ? 2 : 3;
    }

    public int Count => this.achievements.Count;

    public IEnumerator<Achievement> GetEnumerator() => (IEnumerator<Achievement>) this.achievements.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.achievements.GetEnumerator();

    Achievement IList<Achievement>.this[int index]
    {
      get => this.achievements[index];
      set => throw new NotSupportedException();
    }

    bool ICollection<Achievement>.Contains(Achievement item) => this.achievements.Contains(item);

    void ICollection<Achievement>.CopyTo(Achievement[] array, int arrayIndex) => this.achievements.CopyTo(array, arrayIndex);

    int IList<Achievement>.IndexOf(Achievement item) => this.achievements.IndexOf(item);

    bool ICollection<Achievement>.IsReadOnly => true;

    void ICollection<Achievement>.Add(Achievement item) => throw new NotSupportedException();

    void ICollection<Achievement>.Clear() => throw new NotSupportedException();

    void IList<Achievement>.Insert(int index, Achievement item) => throw new NotSupportedException();

    bool ICollection<Achievement>.Remove(Achievement item) => throw new NotSupportedException();

    void IList<Achievement>.RemoveAt(int index) => throw new NotSupportedException();
  }
}
