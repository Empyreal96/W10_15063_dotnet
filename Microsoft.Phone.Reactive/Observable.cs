// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Observable
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows;

namespace Microsoft.Phone.Reactive
{
  public static class Observable
  {
    public static IObservable<TAccumulate> Aggregate<TSource, TAccumulate>(
      this IObservable<TSource> source,
      TAccumulate seed,
      Func<TAccumulate, TSource, TAccumulate> accumulator)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (accumulator == null)
        throw new ArgumentNullException(nameof (accumulator));
      return source.Scan0<TSource, TAccumulate>(seed, accumulator).Final<TAccumulate>();
    }

    public static IObservable<TSource> Aggregate<TSource>(
      this IObservable<TSource> source,
      Func<TSource, TSource, TSource> accumulator)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return accumulator != null ? source.Scan<TSource>(accumulator).Final<TSource>() : throw new ArgumentNullException(nameof (accumulator));
    }

    public static IObservable<bool> IsEmpty<TSource>(this IObservable<TSource> source) => source != null ? (IObservable<bool>) new AnonymousObservable<bool>((Func<IObserver<bool>, IDisposable>) (observer => source.Subscribe<TSource>((Action<TSource>) (_ =>
    {
      observer.OnNext(false);
      observer.OnCompleted();
    }), new Action<Exception>(observer.OnError), (Action) (() =>
    {
      observer.OnNext(true);
      observer.OnCompleted();
    })))) : throw new ArgumentNullException(nameof (source));

    public static IObservable<bool> Any<TSource>(this IObservable<TSource> source) => source != null ? source.IsEmpty<TSource>().Select<bool, bool>((Func<bool, bool>) (b => !b)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<bool> Any<TSource>(
      this IObservable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return predicate != null ? source.Where<TSource>(predicate).Any<TSource>() : throw new ArgumentNullException(nameof (predicate));
    }

    public static IObservable<bool> All<TSource>(
      this IObservable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (predicate == null)
        throw new ArgumentNullException(nameof (predicate));
      return source.Where<TSource>((Func<TSource, bool>) (v => !predicate(v))).IsEmpty<TSource>();
    }

    public static IObservable<bool> Contains<TSource>(
      this IObservable<TSource> source,
      TSource value,
      IEqualityComparer<TSource> comparer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (comparer == null)
        throw new ArgumentNullException(nameof (comparer));
      return source.Where<TSource>((Func<TSource, bool>) (v => comparer.Equals(v, value))).Any<TSource>();
    }

    public static IObservable<bool> Contains<TSource>(
      this IObservable<TSource> source,
      TSource value)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Contains<TSource>(value, (IEqualityComparer<TSource>) EqualityComparer<TSource>.Default);
    }

    public static IObservable<int> Count<TSource>(this IObservable<TSource> source) => source != null ? source.Aggregate<TSource, int>(0, (Func<int, TSource, int>) ((count, _) => {checked {count + 1;}})) : throw new ArgumentNullException(nameof (source));

    public static IObservable<long> LongCount<TSource>(this IObservable<TSource> source) => source != null ? source.Aggregate<TSource, long>(0L, (Func<long, TSource, long>) ((count, _) => {checked {count + 1L;}})).Final<long>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<double> Sum(this IObservable<double> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate<double, double>(0.0, (Func<double, double, double>) ((prev, curr) => prev + curr));
    }

    public static IObservable<float> Sum(this IObservable<float> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate<float, float>(0.0f, (Func<float, float, float>) ((prev, curr) => prev + curr));
    }

    public static IObservable<Decimal> Sum(this IObservable<Decimal> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate<Decimal, Decimal>(0M, (Func<Decimal, Decimal, Decimal>) ((prev, curr) => prev + curr));
    }

    public static IObservable<int> Sum(this IObservable<int> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate<int, int>(0, (Func<int, int, int>) ((prev, curr) => {checked {prev + curr;}}));
    }

    public static IObservable<long> Sum(this IObservable<long> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate<long, long>(0L, (Func<long, long, long>) ((prev, curr) => {checked {prev + curr;}}));
    }

    public static IObservable<double?> Sum(this IObservable<double?> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate<double?, double>(0.0, (Func<double, double?, double>) ((prev, curr) => prev + curr.GetValueOrDefault())).Select<double, double?>((Func<double, double?>) (x => new double?(x)));
    }

    public static IObservable<float?> Sum(this IObservable<float?> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate<float?, float>(0.0f, (Func<float, float?, float>) ((prev, curr) => prev + curr.GetValueOrDefault())).Select<float, float?>((Func<float, float?>) (x => new float?(x)));
    }

    public static IObservable<Decimal?> Sum(this IObservable<Decimal?> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate<Decimal?, Decimal>(0M, (Func<Decimal, Decimal?, Decimal>) ((prev, curr) => prev + curr.GetValueOrDefault())).Select<Decimal, Decimal?>((Func<Decimal, Decimal?>) (x => new Decimal?(x)));
    }

    public static IObservable<int?> Sum(this IObservable<int?> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate<int?, int>(0, (Func<int, int?, int>) ((prev, curr) => {checked {prev + curr.GetValueOrDefault();}})).Select<int, int?>((Func<int, int?>) (x => new int?(x)));
    }

    public static IObservable<long?> Sum(this IObservable<long?> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate<long?, long>(0L, (Func<long, long?, long>) ((prev, curr) => {checked {prev + curr.GetValueOrDefault();}})).Select<long, long?>((Func<long, long?>) (x => new long?(x)));
    }

    public static IObservable<TSource> MinBy<TSource, TKey>(
      this IObservable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (keySelector == null)
        throw new ArgumentNullException(nameof (keySelector));
      return source.MinBy<TSource, TKey>(keySelector, (IComparer<TKey>) Comparer<TKey>.Default);
    }

    public static IObservable<TSource> MinBy<TSource, TKey>(
      this IObservable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (keySelector == null)
        throw new ArgumentNullException(nameof (keySelector));
      if (comparer == null)
        throw new ArgumentNullException(nameof (comparer));
      return Observable.ExtremaBy<TSource, TKey>(source, keySelector, (Func<TKey, TKey, bool>) ((current, key) => comparer.Compare(key, current) < 0));
    }

    public static IObservable<TSource> Min<TSource>(this IObservable<TSource> source) => source != null ? source.MinBy<TSource, TSource>((Func<TSource, TSource>) (x => x)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<TSource> Min<TSource>(
      this IObservable<TSource> source,
      IComparer<TSource> comparer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (comparer == null)
        throw new ArgumentNullException(nameof (comparer));
      return source.MinBy<TSource, TSource>((Func<TSource, TSource>) (x => x), comparer);
    }

    public static IObservable<double> Min(this IObservable<double> source) => source != null ? source.Scan<double, double>(double.MaxValue, new Func<double, double, double>(Math.Min)).Final<double>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<float> Min(this IObservable<float> source) => source != null ? source.Scan<float, float>(float.MaxValue, new Func<float, float, float>(Math.Min)).Final<float>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<Decimal> Min(this IObservable<Decimal> source) => source != null ? source.Scan<Decimal, Decimal>(Decimal.MaxValue, new Func<Decimal, Decimal, Decimal>(Math.Min)).Final<Decimal>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<int> Min(this IObservable<int> source) => source != null ? source.Scan<int, int>(int.MaxValue, new Func<int, int, int>(Math.Min)).Final<int>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<long> Min(this IObservable<long> source) => source != null ? source.Scan<long, long>(long.MaxValue, new Func<long, long, long>(Math.Min)).Final<long>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<double?> Min(this IObservable<double?> source) => source != null ? source.Aggregate<double?, double?>(new double?(), new Func<double?, double?, double?>(Observable.NullableMin<double>)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<float?> Min(this IObservable<float?> source) => source != null ? source.Aggregate<float?, float?>(new float?(), new Func<float?, float?, float?>(Observable.NullableMin<float>)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<Decimal?> Min(this IObservable<Decimal?> source) => source != null ? source.Aggregate<Decimal?, Decimal?>(new Decimal?(), new Func<Decimal?, Decimal?, Decimal?>(Observable.NullableMin<Decimal>)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<int?> Min(this IObservable<int?> source) => source != null ? source.Aggregate<int?, int?>(new int?(), new Func<int?, int?, int?>(Observable.NullableMin<int>)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<long?> Min(this IObservable<long?> source) => source != null ? source.Aggregate<long?, long?>(new long?(), new Func<long?, long?, long?>(Observable.NullableMin<long>)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<TSource> MaxBy<TSource, TKey>(
      this IObservable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (keySelector == null)
        throw new ArgumentNullException(nameof (keySelector));
      return source.MaxBy<TSource, TKey>(keySelector, (IComparer<TKey>) Comparer<TKey>.Default);
    }

    public static IObservable<TSource> MaxBy<TSource, TKey>(
      this IObservable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (keySelector == null)
        throw new ArgumentNullException(nameof (keySelector));
      if (comparer == null)
        throw new ArgumentNullException(nameof (comparer));
      return Observable.ExtremaBy<TSource, TKey>(source, keySelector, (Func<TKey, TKey, bool>) ((current, key) => comparer.Compare(key, current) > 0));
    }

    public static IObservable<TSource> Max<TSource>(this IObservable<TSource> source) => source != null ? source.MaxBy<TSource, TSource>((Func<TSource, TSource>) (x => x)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<TSource> Max<TSource>(
      this IObservable<TSource> source,
      IComparer<TSource> comparer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (comparer == null)
        throw new ArgumentNullException(nameof (comparer));
      return source.MaxBy<TSource, TSource>((Func<TSource, TSource>) (x => x), comparer);
    }

    public static IObservable<double> Max(this IObservable<double> source) => source != null ? source.Scan<double, double>(double.MinValue, new Func<double, double, double>(Math.Max)).Final<double>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<float> Max(this IObservable<float> source) => source != null ? source.Scan<float, float>(float.MinValue, new Func<float, float, float>(Math.Max)).Final<float>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<Decimal> Max(this IObservable<Decimal> source) => source != null ? source.Scan<Decimal, Decimal>(Decimal.MinValue, new Func<Decimal, Decimal, Decimal>(Math.Max)).Final<Decimal>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<int> Max(this IObservable<int> source) => source != null ? source.Scan<int, int>(int.MinValue, new Func<int, int, int>(Math.Max)).Final<int>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<long> Max(this IObservable<long> source) => source != null ? source.Scan<long, long>(long.MinValue, new Func<long, long, long>(Math.Max)).Final<long>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<double?> Max(this IObservable<double?> source) => source != null ? source.Aggregate<double?, double?>(new double?(), new Func<double?, double?, double?>(Observable.NullableMax<double>)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<float?> Max(this IObservable<float?> source) => source != null ? source.Aggregate<float?, float?>(new float?(), new Func<float?, float?, float?>(Observable.NullableMax<float>)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<Decimal?> Max(this IObservable<Decimal?> source) => source != null ? source.Aggregate<Decimal?, Decimal?>(new Decimal?(), new Func<Decimal?, Decimal?, Decimal?>(Observable.NullableMax<Decimal>)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<int?> Max(this IObservable<int?> source) => source != null ? source.Aggregate<int?, int?>(new int?(), new Func<int?, int?, int?>(Observable.NullableMax<int>)) : throw new ArgumentNullException(nameof (source));

    public static IObservable<long?> Max(this IObservable<long?> source) => source != null ? source.Aggregate<long?, long?>(new long?(), new Func<long?, long?, long?>(Observable.NullableMax<long>)) : throw new ArgumentNullException(nameof (source));

    private static IObservable<TSource> ExtremaBy<TSource, TKey>(
      IObservable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TKey, TKey, bool> compare)
    {
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        bool hasValue = false;
        TKey lastKey = default (TKey);
        TSource result = default (TSource);
        return source.Subscribe<TSource>((Action<TSource>) (x =>
        {
          TKey key1 = default (TKey);
          TKey key2;
          try
          {
            key2 = keySelector(x);
          }
          catch (Exception ex)
          {
            observer.OnError(ex);
            return;
          }
          if (!hasValue)
          {
            hasValue = true;
            lastKey = key2;
            result = x;
          }
          else
          {
            bool flag;
            try
            {
              flag = compare(lastKey, key2);
            }
            catch (Exception ex)
            {
              observer.OnError(ex);
              return;
            }
            if (!flag)
              return;
            lastKey = key2;
            result = x;
          }
        }), new Action<Exception>(observer.OnError), (Action) (() =>
        {
          if (!hasValue)
            observer.OnError((Exception) new InvalidOperationException("Sequence contains no elements."));
          observer.OnNext(result);
          observer.OnCompleted();
        }));
      }));
    }

    public static IObservable<double> Average(this IObservable<double> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Scan(new{ sum = 0.0, count = 0L }, (prev, cur) => new
      {
        sum = prev.sum + cur,
        count = {checked {prev.count + 1L;}}
      }).Final().Select(s => s.sum / (double) s.count);
    }

    public static IObservable<float> Average(this IObservable<float> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Scan(new{ sum = 0.0f, count = 0L }, (prev, cur) => new
      {
        sum = prev.sum + cur,
        count = {checked {prev.count + 1L;}}
      }).Final().Select(s => s.sum / (float) s.count);
    }

    public static IObservable<Decimal> Average(this IObservable<Decimal> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Scan(new{ sum = 0M, count = 0L }, (prev, cur) => new
      {
        sum = prev.sum + cur,
        count = {checked {prev.count + 1L;}}
      }).Final().Select(s => s.sum / (Decimal) s.count);
    }

    public static IObservable<double> Average(this IObservable<int> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Scan(new{ sum = 0L, count = 0L }, (prev, cur) => new
      {
        sum = {checked {prev.sum + (long) cur;}},
        count = {checked {prev.count + 1L;}}
      }).Final().Select(s => (double) s.sum / (double) s.count);
    }

    public static IObservable<double> Average(this IObservable<long> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Scan(new{ sum = 0L, count = 0L }, (prev, cur) => new
      {
        sum = {checked {prev.sum + cur;}},
        count = {checked {prev.count + 1L;}}
      }).Final().Select(s => (double) s.sum / (double) s.count);
    }

    public static IObservable<double?> Average(this IObservable<double?> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate(new{ sum = 0.0, count = 0L }, (prev, cur) => !cur.HasValue ? prev : new
      {
        sum = prev.sum + cur.GetValueOrDefault(),
        count = checked (prev.count + 1L)
      }).Select(s => s.count != 0L ? new double?(s.sum / (double) s.count) : new double?());
    }

    public static IObservable<float?> Average(this IObservable<float?> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate(new{ sum = 0.0f, count = 0L }, (prev, cur) => !cur.HasValue ? prev : new
      {
        sum = prev.sum + cur.GetValueOrDefault(),
        count = checked (prev.count + 1L)
      }).Select(s => s.count != 0L ? new float?(s.sum / (float) s.count) : new float?());
    }

    public static IObservable<Decimal?> Average(this IObservable<Decimal?> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate(new{ sum = 0M, count = 0L }, (prev, cur) => !cur.HasValue ? prev : new
      {
        sum = prev.sum + cur.GetValueOrDefault(),
        count = checked (prev.count + 1L)
      }).Select(s => s.count != 0L ? new Decimal?(s.sum / (Decimal) s.count) : new Decimal?());
    }

    public static IObservable<double?> Average(this IObservable<int?> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate(new{ sum = 0, count = 0L }, (prev, cur) => !cur.HasValue ? prev : new
      {
        sum = checked (prev.sum + cur.GetValueOrDefault()),
        count = checked (prev.count + 1L)
      }).Select(s => s.count != 0L ? new double?((double) s.sum / (double) s.count) : new double?());
    }

    public static IObservable<double?> Average(this IObservable<long?> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Aggregate(new
      {
        sum = new double?(0.0),
        count = 0L
      }, (prev, cur) =>
      {
        if (!cur.HasValue)
          return prev;
        double? sum = prev.sum;
        double valueOrDefault = (double) cur.GetValueOrDefault();
        return new
        {
          sum = sum.HasValue ? new double?(sum.GetValueOrDefault() + valueOrDefault) : new double?(),
          count = checked (prev.count + 1L)
        };
      }).Select(s =>
      {
        if (s.count == 0L)
          return new double?();
        double? sum = s.sum;
        double count = (double) s.count;
        return !sum.HasValue ? new double?() : new double?(sum.GetValueOrDefault() / count);
      });
    }

    private static IObservable<TSource> Final<TSource>(this IObservable<TSource> source) => (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
    {
      TSource value = default (TSource);
      bool hasValue = false;
      return source.Subscribe<TSource>((Action<TSource>) (x =>
      {
        hasValue = true;
        value = x;
      }), new Action<Exception>(observer.OnError), (Action) (() =>
      {
        if (!hasValue)
        {
          observer.OnError((Exception) new InvalidOperationException("Sequence contains no elements."));
        }
        else
        {
          observer.OnNext(value);
          observer.OnCompleted();
        }
      }));
    }));

    private static T? NullableMin<T>(T? x, T? y) where T : struct, IComparable<T> => !x.HasValue || y.HasValue && x.Value.CompareTo(y.Value) > 0 ? y : x;

    private static T? NullableMax<T>(T? x, T? y) where T : struct, IComparable<T> => !x.HasValue || y.HasValue && x.Value.CompareTo(y.Value) < 0 ? y : x;

    public static Func<IObservable<TResult>> FromAsyncPattern<TResult>(
      Func<AsyncCallback, object, IAsyncResult> begin,
      Func<IAsyncResult, TResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return (Func<IObservable<TResult>>) (() =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>((IScheduler) Scheduler.ThreadPool);
        IAsyncResult asyncResult = begin((AsyncCallback) (iar =>
        {
          TResult result;
          try
          {
            result = end(iar);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result);
          subject.OnCompleted();
        }), (object) null);
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<T1, IObservable<TResult>> FromAsyncPattern<T1, TResult>(
      Func<T1, AsyncCallback, object, IAsyncResult> begin,
      Func<IAsyncResult, TResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return (Func<T1, IObservable<TResult>>) (x =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>((IScheduler) Scheduler.ThreadPool);
        IAsyncResult asyncResult = begin(x, (AsyncCallback) (iar =>
        {
          TResult result;
          try
          {
            result = end(iar);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result);
          subject.OnCompleted();
        }), (object) null);
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<T1, T2, IObservable<TResult>> FromAsyncPattern<T1, T2, TResult>(
      Func<T1, T2, AsyncCallback, object, IAsyncResult> begin,
      Func<IAsyncResult, TResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return (Func<T1, T2, IObservable<TResult>>) ((x, y) =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>((IScheduler) Scheduler.ThreadPool);
        IAsyncResult asyncResult = begin(x, y, (AsyncCallback) (iar =>
        {
          TResult result;
          try
          {
            result = end(iar);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result);
          subject.OnCompleted();
        }), (object) null);
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<T1, T2, T3, IObservable<TResult>> FromAsyncPattern<T1, T2, T3, TResult>(
      Func<T1, T2, T3, AsyncCallback, object, IAsyncResult> begin,
      Func<IAsyncResult, TResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return (Func<T1, T2, T3, IObservable<TResult>>) ((x, y, z) =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>((IScheduler) Scheduler.ThreadPool);
        IAsyncResult asyncResult = begin(x, y, z, (AsyncCallback) (iar =>
        {
          TResult result;
          try
          {
            result = end(iar);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result);
          subject.OnCompleted();
        }), (object) null);
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<T1, T2, T3, T4, IObservable<TResult>> FromAsyncPattern<T1, T2, T3, T4, TResult>(
      Func<T1, T2, T3, T4, AsyncCallback, object, IAsyncResult> begin,
      Func<IAsyncResult, TResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return (Func<T1, T2, T3, T4, IObservable<TResult>>) ((x, y, z, a) =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>((IScheduler) Scheduler.ThreadPool);
        IAsyncResult asyncResult = begin(x, y, z, a, (AsyncCallback) (iar =>
        {
          TResult result;
          try
          {
            result = end(iar);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result);
          subject.OnCompleted();
        }), (object) null);
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<T1, T2, T3, T4, T5, IObservable<TResult>> FromAsyncPattern<T1, T2, T3, T4, T5, TResult>(
      Func<T1, T2, T3, T4, T5, AsyncCallback, object, IAsyncResult> begin,
      Func<IAsyncResult, TResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return (Func<T1, T2, T3, T4, T5, IObservable<TResult>>) ((x, y, z, a, b) =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>((IScheduler) Scheduler.ThreadPool);
        IAsyncResult asyncResult = begin(x, y, z, a, b, (AsyncCallback) (iar =>
        {
          TResult result;
          try
          {
            result = end(iar);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result);
          subject.OnCompleted();
        }), (object) null);
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<IObservable<TResult>> ToAsync<TResult>(
      this Func<TResult> function)
    {
      return function != null ? function.ToAsync<TResult>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (function));
    }

    public static Func<IObservable<TResult>> ToAsync<TResult>(
      this Func<TResult> function,
      IScheduler scheduler)
    {
      if (function == null)
        throw new ArgumentNullException(nameof (function));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<IObservable<TResult>>) (() =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          TResult result1 = default (TResult);
          TResult result2;
          try
          {
            result2 = function();
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result2);
          subject.OnCompleted();
        }));
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<T, IObservable<TResult>> ToAsync<T, TResult>(
      this Func<T, TResult> function)
    {
      return function != null ? function.ToAsync<T, TResult>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (function));
    }

    public static Func<T, IObservable<TResult>> ToAsync<T, TResult>(
      this Func<T, TResult> function,
      IScheduler scheduler)
    {
      if (function == null)
        throw new ArgumentNullException(nameof (function));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<T, IObservable<TResult>>) (first =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          TResult result1 = default (TResult);
          TResult result2;
          try
          {
            result2 = function(first);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result2);
          subject.OnCompleted();
        }));
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<T1, T2, IObservable<TResult>> ToAsync<T1, T2, TResult>(
      this Func<T1, T2, TResult> function)
    {
      return function != null ? function.ToAsync<T1, T2, TResult>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (function));
    }

    public static Func<T1, T2, IObservable<TResult>> ToAsync<T1, T2, TResult>(
      this Func<T1, T2, TResult> function,
      IScheduler scheduler)
    {
      if (function == null)
        throw new ArgumentNullException(nameof (function));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<T1, T2, IObservable<TResult>>) ((first, second) =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          TResult result1 = default (TResult);
          TResult result2;
          try
          {
            result2 = function(first, second);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result2);
          subject.OnCompleted();
        }));
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<T1, T2, T3, IObservable<TResult>> ToAsync<T1, T2, T3, TResult>(
      this Func<T1, T2, T3, TResult> function)
    {
      return function != null ? function.ToAsync<T1, T2, T3, TResult>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (function));
    }

    public static Func<T1, T2, T3, IObservable<TResult>> ToAsync<T1, T2, T3, TResult>(
      this Func<T1, T2, T3, TResult> function,
      IScheduler scheduler)
    {
      if (function == null)
        throw new ArgumentNullException(nameof (function));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<T1, T2, T3, IObservable<TResult>>) ((first, second, third) =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          TResult result1 = default (TResult);
          TResult result2;
          try
          {
            result2 = function(first, second, third);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result2);
          subject.OnCompleted();
        }));
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<T1, T2, T3, T4, IObservable<TResult>> ToAsync<T1, T2, T3, T4, TResult>(
      this Func<T1, T2, T3, T4, TResult> function)
    {
      return function != null ? function.ToAsync<T1, T2, T3, T4, TResult>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (function));
    }

    public static Func<T1, T2, T3, T4, IObservable<TResult>> ToAsync<T1, T2, T3, T4, TResult>(
      this Func<T1, T2, T3, T4, TResult> function,
      IScheduler scheduler)
    {
      if (function == null)
        throw new ArgumentNullException(nameof (function));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<T1, T2, T3, T4, IObservable<TResult>>) ((first, second, third, fourth) =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          TResult result1 = default (TResult);
          TResult result2;
          try
          {
            result2 = function(first, second, third, fourth);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result2);
          subject.OnCompleted();
        }));
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<T1, T2, T3, T4, T5, IObservable<TResult>> ToAsync<T1, T2, T3, T4, T5, TResult>(
      this Func<T1, T2, T3, T4, T5, TResult> function)
    {
      return function != null ? function.ToAsync<T1, T2, T3, T4, T5, TResult>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (function));
    }

    public static Func<T1, T2, T3, T4, T5, IObservable<TResult>> ToAsync<T1, T2, T3, T4, T5, TResult>(
      this Func<T1, T2, T3, T4, T5, TResult> function,
      IScheduler scheduler)
    {
      if (function == null)
        throw new ArgumentNullException(nameof (function));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<T1, T2, T3, T4, T5, IObservable<TResult>>) ((first, second, third, fourth, fifth) =>
      {
        AsyncSubject<TResult> subject = new AsyncSubject<TResult>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          TResult result1 = default (TResult);
          TResult result2;
          try
          {
            result2 = function(first, second, third, fourth, fifth);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(result2);
          subject.OnCompleted();
        }));
        return ((IObservable<TResult>) subject).AsObservable<TResult>();
      });
    }

    public static Func<IObservable<Unit>> ToAsync(this Action action) => action != null ? action.ToAsync((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (action));

    public static Func<IObservable<Unit>> ToAsync(
      this Action action,
      IScheduler scheduler)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<IObservable<Unit>>) (() =>
      {
        AsyncSubject<Unit> subject = new AsyncSubject<Unit>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          try
          {
            action();
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(new Unit());
          subject.OnCompleted();
        }));
        return ((IObservable<Unit>) subject).AsObservable<Unit>();
      });
    }

    public static Func<TSource, IObservable<Unit>> ToAsync<TSource>(
      this Action<TSource> action)
    {
      return action != null ? action.ToAsync<TSource>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (action));
    }

    public static Func<TSource, IObservable<Unit>> ToAsync<TSource>(
      this Action<TSource> action,
      IScheduler scheduler)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<TSource, IObservable<Unit>>) (first =>
      {
        AsyncSubject<Unit> subject = new AsyncSubject<Unit>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          try
          {
            action(first);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(new Unit());
          subject.OnCompleted();
        }));
        return ((IObservable<Unit>) subject).AsObservable<Unit>();
      });
    }

    public static Func<T1, T2, IObservable<Unit>> ToAsync<T1, T2>(
      this Action<T1, T2> action)
    {
      return action != null ? action.ToAsync<T1, T2>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (action));
    }

    public static Func<T1, T2, IObservable<Unit>> ToAsync<T1, T2>(
      this Action<T1, T2> action,
      IScheduler scheduler)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<T1, T2, IObservable<Unit>>) ((first, second) =>
      {
        AsyncSubject<Unit> subject = new AsyncSubject<Unit>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          try
          {
            action(first, second);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(new Unit());
          subject.OnCompleted();
        }));
        return ((IObservable<Unit>) subject).AsObservable<Unit>();
      });
    }

    public static Func<T1, T2, T3, IObservable<Unit>> ToAsync<T1, T2, T3>(
      this Action<T1, T2, T3> action)
    {
      return action != null ? action.ToAsync<T1, T2, T3>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (action));
    }

    public static Func<T1, T2, T3, IObservable<Unit>> ToAsync<T1, T2, T3>(
      this Action<T1, T2, T3> action,
      IScheduler scheduler)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<T1, T2, T3, IObservable<Unit>>) ((first, second, third) =>
      {
        AsyncSubject<Unit> subject = new AsyncSubject<Unit>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          try
          {
            action(first, second, third);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(new Unit());
          subject.OnCompleted();
        }));
        return ((IObservable<Unit>) subject).AsObservable<Unit>();
      });
    }

    public static Func<T1, T2, T3, T4, IObservable<Unit>> ToAsync<T1, T2, T3, T4>(
      this Action<T1, T2, T3, T4> action)
    {
      return action != null ? action.ToAsync<T1, T2, T3, T4>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (action));
    }

    public static Func<T1, T2, T3, T4, IObservable<Unit>> ToAsync<T1, T2, T3, T4>(
      this Action<T1, T2, T3, T4> action,
      IScheduler scheduler)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<T1, T2, T3, T4, IObservable<Unit>>) ((first, second, third, fourth) =>
      {
        AsyncSubject<Unit> subject = new AsyncSubject<Unit>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          try
          {
            action(first, second, third, fourth);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(new Unit());
          subject.OnCompleted();
        }));
        return ((IObservable<Unit>) subject).AsObservable<Unit>();
      });
    }

    public static Func<T1, T2, T3, T4, T5, IObservable<Unit>> ToAsync<T1, T2, T3, T4, T5>(
      this Action<T1, T2, T3, T4, T5> action)
    {
      return action != null ? action.ToAsync<T1, T2, T3, T4, T5>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (action));
    }

    public static Func<T1, T2, T3, T4, T5, IObservable<Unit>> ToAsync<T1, T2, T3, T4, T5>(
      this Action<T1, T2, T3, T4, T5> action,
      IScheduler scheduler)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (Func<T1, T2, T3, T4, T5, IObservable<Unit>>) ((first, second, third, fourth, fifth) =>
      {
        AsyncSubject<Unit> subject = new AsyncSubject<Unit>(scheduler);
        scheduler.Schedule((Action) (() =>
        {
          try
          {
            action(first, second, third, fourth, fifth);
          }
          catch (Exception ex)
          {
            subject.OnError(ex);
            return;
          }
          subject.OnNext(new Unit());
          subject.OnCompleted();
        }));
        return ((IObservable<Unit>) subject).AsObservable<Unit>();
      });
    }

    public static IObservable<TSource> Start<TSource>(Func<TSource> function)
    {
      if (function == null)
        throw new ArgumentNullException(nameof (function));
      return function.ToAsync<TSource>()();
    }

    public static IObservable<TSource> Start<TSource>(
      Func<TSource> function,
      IScheduler scheduler)
    {
      if (function == null)
        throw new ArgumentNullException(nameof (function));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return function.ToAsync<TSource>(scheduler)();
    }

    public static IObservable<Unit> Start(Action action)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      return action.ToAsync((IScheduler) Scheduler.ThreadPool)();
    }

    public static IObservable<Unit> Start(Action action, IScheduler scheduler)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return action.ToAsync(scheduler)();
    }

    public static Func<IObservable<Unit>> FromAsyncPattern(
      Func<AsyncCallback, object, IAsyncResult> begin,
      Action<IAsyncResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return Observable.FromAsyncPattern<Unit>(begin, (Func<IAsyncResult, Unit>) (iar =>
      {
        end(iar);
        return new Unit();
      }));
    }

    public static Func<T1, IObservable<Unit>> FromAsyncPattern<T1>(
      Func<T1, AsyncCallback, object, IAsyncResult> begin,
      Action<IAsyncResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return Observable.FromAsyncPattern<T1, Unit>(begin, (Func<IAsyncResult, Unit>) (iar =>
      {
        end(iar);
        return new Unit();
      }));
    }

    public static Func<T1, T2, IObservable<Unit>> FromAsyncPattern<T1, T2>(
      Func<T1, T2, AsyncCallback, object, IAsyncResult> begin,
      Action<IAsyncResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return Observable.FromAsyncPattern<T1, T2, Unit>(begin, (Func<IAsyncResult, Unit>) (iar =>
      {
        end(iar);
        return new Unit();
      }));
    }

    public static Func<T1, T2, T3, IObservable<Unit>> FromAsyncPattern<T1, T2, T3>(
      Func<T1, T2, T3, AsyncCallback, object, IAsyncResult> begin,
      Action<IAsyncResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return Observable.FromAsyncPattern<T1, T2, T3, Unit>(begin, (Func<IAsyncResult, Unit>) (iar =>
      {
        end(iar);
        return new Unit();
      }));
    }

    public static Func<T1, T2, T3, T4, IObservable<Unit>> FromAsyncPattern<T1, T2, T3, T4>(
      Func<T1, T2, T3, T4, AsyncCallback, object, IAsyncResult> begin,
      Action<IAsyncResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return Observable.FromAsyncPattern<T1, T2, T3, T4, Unit>(begin, (Func<IAsyncResult, Unit>) (iar =>
      {
        end(iar);
        return new Unit();
      }));
    }

    public static Func<T1, T2, T3, T4, T5, IObservable<Unit>> FromAsyncPattern<T1, T2, T3, T4, T5>(
      Func<T1, T2, T3, T4, T5, AsyncCallback, object, IAsyncResult> begin,
      Action<IAsyncResult> end)
    {
      if (begin == null)
        throw new ArgumentNullException(nameof (begin));
      if (end == null)
        throw new ArgumentNullException(nameof (end));
      return Observable.FromAsyncPattern<T1, T2, T3, T4, T5, Unit>(begin, (Func<IAsyncResult, Unit>) (iar =>
      {
        end(iar);
        return new Unit();
      }));
    }

    public static IObservable<TResult> Let<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> function)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (function == null)
        throw new ArgumentNullException(nameof (function));
      return function(source);
    }

    public static IObservable<TSource> RefCount<TSource>(
      this IConnectableObservable<TSource> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      object gate = new object();
      int count = 0;
      IConnectableObservable<TSource> connectable = source;
      IDisposable connectableSubscription = (IDisposable) null;
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        bool flag = false;
        lock (gate)
        {
          ++count;
          flag = count == 1;
        }
        IDisposable subscription = ((IObservable<TSource>) connectable).Subscribe(observer);
        if (flag)
          connectableSubscription = connectable.Connect();
        return Disposable.Create((Action) (() =>
        {
          subscription.Dispose();
          lock (gate)
          {
            --count;
            if (count != 0)
              return;
            connectableSubscription.Dispose();
          }
        }));
      }));
    }

    public static IConnectableObservable<TSource> Publish<TSource>(
      this IObservable<TSource> source)
    {
      return source != null ? (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new Subject<TSource>()) : throw new ArgumentNullException(nameof (source));
    }

    public static IObservable<TResult> Publish<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IConnectableObservable<TSource> connectableObservable = source.Publish<TSource>();
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          selector((IObservable<TSource>) connectableObservable).Subscribe(observer),
          connectableObservable.Connect()
        });
      }));
    }

    public static IConnectableObservable<TSource> Prune<TSource>(
      this IObservable<TSource> source)
    {
      return source != null ? source.Prune<TSource>((IScheduler) Scheduler.CurrentThread) : throw new ArgumentNullException(nameof (source));
    }

    public static IConnectableObservable<TSource> Prune<TSource>(
      this IObservable<TSource> source,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return scheduler != null ? (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new AsyncSubject<TSource>(scheduler)) : throw new ArgumentNullException(nameof (scheduler));
    }

    public static IObservable<TResult> Prune<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return source.Prune<TSource, TResult>(selector, (IScheduler) Scheduler.CurrentThread);
    }

    public static IObservable<TResult> Prune<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IConnectableObservable<TSource> connectableObservable = source.Prune<TSource>(scheduler);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          selector((IObservable<TSource>) connectableObservable).Subscribe(observer),
          connectableObservable.Connect()
        });
      }));
    }

    public static IConnectableObservable<TSource> Replay<TSource>(
      this IObservable<TSource> source)
    {
      return source != null ? (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new ReplaySubject<TSource>((IScheduler) Scheduler.CurrentThread)) : throw new ArgumentNullException(nameof (source));
    }

    public static IConnectableObservable<TSource> Replay<TSource>(
      this IObservable<TSource> source,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return scheduler != null ? (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new ReplaySubject<TSource>(scheduler)) : throw new ArgumentNullException(nameof (scheduler));
    }

    public static IObservable<TResult> Replay<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return source.Replay<TSource, TResult>(selector, (IScheduler) Scheduler.CurrentThread);
    }

    public static IObservable<TResult> Replay<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IConnectableObservable<TSource> connectableObservable = source.Replay<TSource>(scheduler);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          selector((IObservable<TSource>) connectableObservable).Subscribe(observer),
          connectableObservable.Connect()
        });
      }));
    }

    public static IConnectableObservable<TSource> Replay<TSource>(
      this IObservable<TSource> source,
      TimeSpan window)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (window.TotalMilliseconds < 0.0)
        throw new ArgumentOutOfRangeException(nameof (window));
      return (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new ReplaySubject<TSource>(window, (IScheduler) Scheduler.CurrentThread));
    }

    public static IObservable<TResult> Replay<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector,
      TimeSpan window)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (window.TotalMilliseconds < 0.0)
        throw new ArgumentOutOfRangeException(nameof (window));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IConnectableObservable<TSource> connectableObservable = source.Replay<TSource>(window);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          selector((IObservable<TSource>) connectableObservable).Subscribe(observer),
          connectableObservable.Connect()
        });
      }));
    }

    public static IConnectableObservable<TSource> Replay<TSource>(
      this IObservable<TSource> source,
      TimeSpan window,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (window.TotalMilliseconds < 0.0)
        throw new ArgumentOutOfRangeException(nameof (window));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new ReplaySubject<TSource>(window, scheduler));
    }

    public static IObservable<TResult> Replay<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector,
      TimeSpan window,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (window.TotalMilliseconds < 0.0)
        throw new ArgumentOutOfRangeException(nameof (window));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IConnectableObservable<TSource> connectableObservable = source.Replay<TSource>(window, scheduler);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          selector((IObservable<TSource>) connectableObservable).Subscribe(observer),
          connectableObservable.Connect()
        });
      }));
    }

    public static IConnectableObservable<TSource> Replay<TSource>(
      this IObservable<TSource> source,
      int bufferSize,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (bufferSize < 0)
        throw new ArgumentOutOfRangeException(nameof (bufferSize));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new ReplaySubject<TSource>(bufferSize, scheduler));
    }

    public static IObservable<TResult> Replay<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector,
      int bufferSize,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (bufferSize < 0)
        throw new ArgumentOutOfRangeException(nameof (bufferSize));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IConnectableObservable<TSource> connectableObservable = source.Replay<TSource>(bufferSize, scheduler);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          selector((IObservable<TSource>) connectableObservable).Subscribe(observer),
          connectableObservable.Connect()
        });
      }));
    }

    public static IConnectableObservable<TSource> Replay<TSource>(
      this IObservable<TSource> source,
      int bufferSize)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (bufferSize < 0)
        throw new ArgumentOutOfRangeException(nameof (bufferSize));
      return (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new ReplaySubject<TSource>(bufferSize, (IScheduler) Scheduler.CurrentThread));
    }

    public static IObservable<TResult> Replay<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector,
      int bufferSize)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (bufferSize < 0)
        throw new ArgumentOutOfRangeException(nameof (bufferSize));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IConnectableObservable<TSource> connectableObservable = source.Replay<TSource>(bufferSize);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          selector((IObservable<TSource>) connectableObservable).Subscribe(observer),
          connectableObservable.Connect()
        });
      }));
    }

    public static IConnectableObservable<TSource> Replay<TSource>(
      this IObservable<TSource> source,
      int bufferSize,
      TimeSpan window)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (bufferSize < 0)
        throw new ArgumentOutOfRangeException(nameof (bufferSize));
      if (window.TotalMilliseconds < 0.0)
        throw new ArgumentOutOfRangeException(nameof (window));
      return (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new ReplaySubject<TSource>(bufferSize, window));
    }

    public static IObservable<TResult> Replay<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector,
      int bufferSize,
      TimeSpan window)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (bufferSize < 0)
        throw new ArgumentOutOfRangeException(nameof (bufferSize));
      if (window.TotalMilliseconds < 0.0)
        throw new ArgumentOutOfRangeException(nameof (window));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IConnectableObservable<TSource> connectableObservable = source.Replay<TSource>(bufferSize, window);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          selector((IObservable<TSource>) connectableObservable).Subscribe(observer),
          connectableObservable.Connect()
        });
      }));
    }

    public static IConnectableObservable<TSource> Replay<TSource>(
      this IObservable<TSource> source,
      int bufferSize,
      TimeSpan window,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (bufferSize < 0)
        throw new ArgumentOutOfRangeException(nameof (bufferSize));
      if (window.TotalMilliseconds < 0.0)
        throw new ArgumentOutOfRangeException(nameof (window));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new ReplaySubject<TSource>(bufferSize, window, scheduler));
    }

    public static IObservable<TResult> Replay<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector,
      int bufferSize,
      TimeSpan window,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (bufferSize < 0)
        throw new ArgumentOutOfRangeException(nameof (bufferSize));
      if (window.TotalMilliseconds < 0.0)
        throw new ArgumentOutOfRangeException(nameof (window));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IConnectableObservable<TSource> connectableObservable = source.Replay<TSource>(bufferSize, window, scheduler);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          selector((IObservable<TSource>) connectableObservable).Subscribe(observer),
          connectableObservable.Connect()
        });
      }));
    }

    public static IConnectableObservable<TSource> Publish<TSource>(
      this IObservable<TSource> source,
      TSource initialValue)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Publish<TSource>(initialValue, (IScheduler) Scheduler.CurrentThread);
    }

    public static IConnectableObservable<TSource> Publish<TSource>(
      this IObservable<TSource> source,
      TSource initialValue,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IConnectableObservable<TSource>) new ConnectableObservable<TSource>(source, (ISubject<TSource>) new BehaviorSubject<TSource>(initialValue, scheduler));
    }

    public static IObservable<TResult> Publish<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector,
      TSource initialValue)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return source.Publish<TSource, TResult>(selector, initialValue, (IScheduler) Scheduler.CurrentThread);
    }

    public static IObservable<TResult> Publish<TSource, TResult>(
      this IObservable<TSource> source,
      Func<IObservable<TSource>, IObservable<TResult>> selector,
      TSource initialValue,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IConnectableObservable<TSource> connectableObservable = source.Publish<TSource>(initialValue, scheduler);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          selector((IObservable<TSource>) connectableObservable).Subscribe(observer),
          connectableObservable.Connect()
        });
      }));
    }

    public static IEnumerable<TSource> ToEnumerable<TSource>(
      this IObservable<TSource> source)
    {
      return source != null ? (IEnumerable<TSource>) new AnonymousEnumerable<TSource>((Func<IEnumerator<TSource>>) (() => source.GetEnumerator<TSource>())) : throw new ArgumentNullException(nameof (source));
    }

    internal static IEnumerator<TSource> PushToPull<TSource>(
      this IObservable<TSource> source,
      Action<Notification<TSource>> push,
      Func<Notification<TSource>> pull)
    {
      IDisposable subscription = (IDisposable) null;
      PushPullAdapter<TSource> pushPullAdapter = new PushPullAdapter<TSource>(push, pull, (Action) (() => subscription.Dispose()));
      subscription = source.Subscribe((IObserver<TSource>) pushPullAdapter);
      return (IEnumerator<TSource>) pushPullAdapter;
    }

    public static IEnumerator<TSource> GetEnumerator<TSource>(
      this IObservable<TSource> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      Queue<Notification<TSource>> q = new Queue<Notification<TSource>>();
      Semaphore s = new Semaphore(0, int.MaxValue);
      return source.PushToPull<TSource>((Action<Notification<TSource>>) (x =>
      {
        lock (q)
          q.Enqueue(x);
        s.Release();
      }), (Func<Notification<TSource>>) (() =>
      {
        s.WaitOne();
        lock (q)
          return q.Dequeue();
      }));
    }

    internal static IEnumerator<TSource> GetMostRecentEnumerator<TSource>(
      this IObservable<TSource> source,
      TSource initialValue)
    {
      Notification<TSource> notification = (Notification<TSource>) new Notification<TSource>.OnNext(initialValue);
      return source.PushToPull<TSource>((Action<Notification<TSource>>) (x => notification = x), (Func<Notification<TSource>>) (() => notification));
    }

    internal static IEnumerator<TSource> GetNextEnumerator<TSource>(
      this IObservable<TSource> source)
    {
      Semaphore s = new Semaphore(0, 1);
      bool waiting = false;
      object gate = new object();
      Notification<TSource> notification = (Notification<TSource>) null;
      return source.PushToPull<TSource>((Action<Notification<TSource>>) (x =>
      {
        lock (gate)
        {
          if (waiting)
          {
            notification = x;
            s.Release();
          }
          waiting = false;
        }
      }), (Func<Notification<TSource>>) (() =>
      {
        lock (gate)
          waiting = true;
        s.WaitOne();
        return notification;
      }));
    }

    internal static IEnumerator<TSource> GetLatestEnumerator<TSource>(
      this IObservable<TSource> source)
    {
      object gate = new object();
      Notification<TSource> notification = (Notification<TSource>) null;
      Notification<TSource> current = (Notification<TSource>) null;
      Semaphore s = new Semaphore(0, 1);
      return source.PushToPull<TSource>((Action<Notification<TSource>>) (x =>
      {
        bool flag = false;
        lock (gate)
        {
          flag = notification == (Notification<TSource>) null;
          notification = x;
        }
        if (!flag)
          return;
        s.Release();
      }), (Func<Notification<TSource>>) (() =>
      {
        s.WaitOne();
        lock (gate)
        {
          current = notification;
          notification = (Notification<TSource>) null;
        }
        return current;
      }));
    }

    public static IEnumerable<TSource> MostRecent<TSource>(
      this IObservable<TSource> source,
      TSource initialValue)
    {
      return source != null ? (IEnumerable<TSource>) new AnonymousEnumerable<TSource>((Func<IEnumerator<TSource>>) (() => source.GetMostRecentEnumerator<TSource>(initialValue))) : throw new ArgumentNullException(nameof (source));
    }

    public static IEnumerable<TSource> Next<TSource>(this IObservable<TSource> source) => source != null ? (IEnumerable<TSource>) new AnonymousEnumerable<TSource>((Func<IEnumerator<TSource>>) (() => source.GetNextEnumerator<TSource>())) : throw new ArgumentNullException(nameof (source));

    public static IEnumerable<TSource> Latest<TSource>(this IObservable<TSource> source) => source != null ? (IEnumerable<TSource>) new AnonymousEnumerable<TSource>((Func<IEnumerator<TSource>>) (() => source.GetLatestEnumerator<TSource>())) : throw new ArgumentNullException(nameof (source));

    public static TSource First<TSource>(this IObservable<TSource> source) => source != null ? source.FirstOrDefaultInternal<TSource>(true) : throw new ArgumentNullException(nameof (source));

    public static TSource FirstOrDefault<TSource>(this IObservable<TSource> source) => source != null ? source.FirstOrDefaultInternal<TSource>(false) : throw new ArgumentNullException(nameof (source));

    private static TSource FirstOrDefaultInternal<TSource>(
      this IObservable<TSource> source,
      bool throwOnEmpty)
    {
      TSource value = default (TSource);
      bool seenValue = false;
      Exception ex = (Exception) null;
      Semaphore gate = new Semaphore(0, int.MaxValue);
      using (source.Subscribe<TSource>((Action<TSource>) (v =>
      {
        if (!seenValue)
          value = v;
        seenValue = true;
        gate.Release();
      }), (Action<Exception>) (e =>
      {
        ex = e;
        gate.Release();
      }), (Action) (() => gate.Release())))
        gate.WaitOne();
      if (ex != null)
        throw ex.PrepareForRethrow();
      if (throwOnEmpty && !seenValue)
        throw new InvalidOperationException("Sequence contains no elements.");
      return value;
    }

    public static TSource Last<TSource>(this IObservable<TSource> source) => source != null ? source.LastOrDefaultInternal<TSource>(true) : throw new ArgumentNullException(nameof (source));

    public static TSource LastOrDefault<TSource>(this IObservable<TSource> source) => source != null ? source.LastOrDefaultInternal<TSource>(false) : throw new ArgumentNullException(nameof (source));

    private static TSource LastOrDefaultInternal<TSource>(
      this IObservable<TSource> source,
      bool throwOnEmpty)
    {
      TSource value = default (TSource);
      bool seenValue = false;
      Exception ex = (Exception) null;
      Semaphore gate = new Semaphore(0, int.MaxValue);
      using (source.Subscribe<TSource>((Action<TSource>) (v =>
      {
        seenValue = true;
        value = v;
      }), (Action<Exception>) (e =>
      {
        ex = e;
        gate.Release();
      }), (Action) (() => gate.Release())))
        gate.WaitOne();
      if (ex != null)
        throw ex.PrepareForRethrow();
      if (throwOnEmpty && !seenValue)
        throw new InvalidOperationException("Sequence contains no elements.");
      return value;
    }

    public static TSource Single<TSource>(this IObservable<TSource> source) => source != null ? source.SingleOrDefaultInternal<TSource>(true) : throw new ArgumentNullException(nameof (source));

    public static TSource SingleOrDefault<TSource>(this IObservable<TSource> source) => source != null ? source.SingleOrDefaultInternal<TSource>(false) : throw new ArgumentNullException(nameof (source));

    private static TSource SingleOrDefaultInternal<TSource>(
      this IObservable<TSource> source,
      bool throwOnEmpty)
    {
      TSource value = default (TSource);
      bool seenValue = false;
      Exception ex = (Exception) null;
      Semaphore gate = new Semaphore(0, int.MaxValue);
      using (source.Subscribe<TSource>((Action<TSource>) (v =>
      {
        if (seenValue)
        {
          ex = (Exception) new InvalidOperationException("Sequence contains more than one element.");
          gate.Release();
        }
        value = v;
        seenValue = true;
      }), (Action<Exception>) (e =>
      {
        ex = e;
        gate.Release();
      }), (Action) (() => gate.Release())))
        gate.WaitOne();
      if (ex != null)
        throw ex.PrepareForRethrow();
      if (throwOnEmpty && !seenValue)
        throw new InvalidOperationException("Sequence contains no elements.");
      return value;
    }

    public static void Run<TSource>(this IObservable<TSource> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      source.Run<TSource>((Action<TSource>) (_ => { }), (Action<Exception>) (ex =>
      {
        throw ex.PrepareForRethrow();
      }), (Action) (() => { }));
    }

    public static void Run<TSource>(this IObservable<TSource> source, IObserver<TSource> observer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (observer == null)
        throw new ArgumentNullException(nameof (observer));
      source.Run<TSource>(new Action<TSource>(observer.OnNext), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted));
    }

    public static void Run<TSource>(this IObservable<TSource> source, Action<TSource> onNext)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      source.Run<TSource>(onNext, (Action<Exception>) (ex =>
      {
        throw ex.PrepareForRethrow();
      }), (Action) (() => { }));
    }

    public static void Run<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext,
      Action onCompleted)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onCompleted == null)
        throw new ArgumentNullException(nameof (onCompleted));
      source.Run<TSource>(onNext, (Action<Exception>) (ex =>
      {
        throw ex.PrepareForRethrow();
      }), onCompleted);
    }

    public static void Run<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext,
      Action<Exception> onError)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onError == null)
        throw new ArgumentNullException(nameof (onError));
      source.Run<TSource>(onNext, onError, (Action) (() => { }));
    }

    public static void Run<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext,
      Action<Exception> onError,
      Action onCompleted)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onError == null)
        throw new ArgumentNullException(nameof (onError));
      if (onCompleted == null)
        throw new ArgumentNullException(nameof (onCompleted));
      ManualResetEvent evt = new ManualResetEvent(false);
      using (source.Subscribe<TSource>(onNext, (Action<Exception>) (ex =>
      {
        try
        {
          onError(ex);
        }
        finally
        {
          evt.Set();
        }
      }), (Action) (() =>
      {
        try
        {
          onCompleted();
        }
        finally
        {
          evt.Set();
        }
      })))
        evt.WaitOne();
    }

    public static IObservable<TSource> ObserveOn<TSource>(
      this IObservable<TSource> source,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        Queue<Notification<TSource>> q = new Queue<Notification<TSource>>();
        bool active = false;
        object gate = new object();
        MutableDisposable cancelable = new MutableDisposable();
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          source.Materialize<TSource>().Subscribe<Notification<TSource>>((Action<Notification<TSource>>) (n =>
          {
            bool flag1 = false;
            lock (gate)
            {
              flag1 = !active;
              active = true;
              q.Enqueue(n);
            }
            if (!flag1)
              return;
            cancelable.Disposable = scheduler.Schedule((Action<Action>) (self =>
            {
              Notification<TSource> notification = (Notification<TSource>) null;
              lock (gate)
                notification = q.Dequeue();
              notification.Accept(observer);
              bool flag2 = false;
              lock (gate)
                flag2 = active = q.Count > 0;
              if (!flag2)
                return;
              self();
            }));
          })),
          (IDisposable) cancelable
        });
      }));
    }

    public static IObservable<TSource> SubscribeOn<TSource>(
      this IObservable<TSource> source,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        MutableDisposable d = new MutableDisposable();
        scheduler.Schedule((Action) (() => d.Disposable = (IDisposable) new ScheduledDisposable(scheduler, source.Subscribe(observer))));
        return (IDisposable) d;
      }));
    }

    public static IObservable<TSource> ObserveOn<TSource>(
      this IObservable<TSource> source,
      DispatcherScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return source.ObserveOn<TSource>(scheduler.Dispatcher);
    }

    public static IObservable<TSource> ObserveOnDispatcher<TSource>(
      this IObservable<TSource> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.ObserveOn<TSource>(Deployment.Current.Dispatcher);
    }

    public static IObservable<TSource> SubscribeOnDispatcher<TSource>(
      this IObservable<TSource> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.SubscribeOn<TSource>(Deployment.Current.Dispatcher);
    }

    public static IObservable<TSource> SubscribeOn<TSource>(
      this IObservable<TSource> source,
      DispatcherScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return source.SubscribeOn<TSource>(scheduler.Dispatcher);
    }

    public static IObservable<TSource> SubscribeOn<TSource>(
      this IObservable<TSource> source,
      SynchronizationContext context)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (context == null)
        throw new ArgumentNullException(nameof (context));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        MutableDisposable subscription = new MutableDisposable();
        context.Post((SendOrPostCallback) (_ => subscription.Disposable = (IDisposable) new ContextDisposable(context, source.Subscribe(observer))), (object) null);
        return (IDisposable) subscription;
      }));
    }

    public static IObservable<TSource> ObserveOn<TSource>(
      this IObservable<TSource> source,
      SynchronizationContext synchronizationContext)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (synchronizationContext == null)
        throw new ArgumentNullException(nameof (synchronizationContext));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer => source.Subscribe<TSource>((Action<TSource>) (x => synchronizationContext.Post((SendOrPostCallback) (_ => observer.OnNext(x)), (object) null)), (Action<Exception>) (exception => synchronizationContext.Post((SendOrPostCallback) (_ => observer.OnError(exception)), (object) null)), (Action) (() => synchronizationContext.Post((SendOrPostCallback) (_ => observer.OnCompleted()), (object) null)))));
    }

    public static IObservable<TSource> Synchronize<TSource>(
      this IObservable<TSource> source)
    {
      return source != null ? Observable.Defer<TSource>((Func<IObservable<TSource>>) (() => source.Synchronize<TSource>(new object()))) : throw new ArgumentNullException(nameof (source));
    }

    public static IObservable<TSource> Synchronize<TSource>(
      this IObservable<TSource> source,
      object gate)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (gate == null)
        throw new ArgumentNullException(nameof (gate));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer => source.Subscribe((IObserver<TSource>) new SynchronizedObserver<TSource>(observer, gate))));
    }

    public static IObservable<TValue> Never<TValue>() => (IObservable<TValue>) new AnonymousObservable<TValue>((Func<IObserver<TValue>, IDisposable>) (observer => Disposable.Empty));

    public static IObservable<TValue> Empty<TValue>() => Observable.Empty<TValue>((IScheduler) Scheduler.CurrentThread);

    public static IObservable<TValue> Empty<TValue>(IScheduler scheduler) => scheduler != null ? (IObservable<TValue>) new AnonymousObservable<TValue>((Func<IObserver<TValue>, IDisposable>) (observer => scheduler.Schedule(new Action(observer.OnCompleted)))) : throw new ArgumentNullException(nameof (scheduler));

    public static IObservable<TValue> Return<TValue>(TValue value) => Observable.Return<TValue>(value, (IScheduler) Scheduler.CurrentThread);

    public static IObservable<TValue> Return<TValue>(TValue value, IScheduler scheduler)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TValue>) new AnonymousObservable<TValue>((Func<IObserver<TValue>, IDisposable>) (observer => scheduler.Schedule((Action) (() =>
      {
        observer.OnNext(value);
        observer.OnCompleted();
      }))));
    }

    public static IObservable<TValue> Throw<TValue>(Exception exception) => exception != null ? Observable.Throw<TValue>(exception, (IScheduler) Scheduler.CurrentThread) : throw new ArgumentNullException(nameof (exception));

    public static IObservable<TValue> Throw<TValue>(
      Exception exception,
      IScheduler scheduler)
    {
      if (exception == null)
        throw new ArgumentNullException(nameof (exception));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TValue>) new AnonymousObservable<TValue>((Func<IObserver<TValue>, IDisposable>) (observer => scheduler.Schedule((Action) (() => observer.OnError(exception)))));
    }

    public static IDisposable Subscribe<TSource>(
      this IEnumerable<TSource> source,
      IObserver<TSource> observer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (observer == null)
        throw new ArgumentNullException(nameof (observer));
      return source.Subscribe<TSource>(observer, (IScheduler) Scheduler.CurrentThread);
    }

    public static IDisposable Subscribe<TSource>(
      this IEnumerable<TSource> source,
      IObserver<TSource> observer,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (observer == null)
        throw new ArgumentNullException(nameof (observer));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      IEnumerator<TSource> e = source.GetEnumerator();
      BooleanDisposable flag = new BooleanDisposable();
      scheduler.Schedule((Action<Action>) (self =>
      {
        bool flag1 = false;
        Exception exception = (Exception) null;
        TSource source1 = default (TSource);
        if (flag.IsDisposed)
        {
          e.Dispose();
        }
        else
        {
          try
          {
            flag1 = e.MoveNext();
            if (flag1)
              source1 = e.Current;
          }
          catch (Exception ex)
          {
            exception = ex;
          }
          if (!flag1 || exception != null)
            e.Dispose();
          if (exception != null)
            observer.OnError(exception);
          else if (!flag1)
          {
            observer.OnCompleted();
          }
          else
          {
            observer.OnNext(source1);
            self();
          }
        }
      }));
      return (IDisposable) flag;
    }

    public static IObservable<IEvent<TEventArgs>> FromEvent<TDelegate, TEventArgs>(
      Func<EventHandler<TEventArgs>, TDelegate> conversion,
      Action<TDelegate> addHandler,
      Action<TDelegate> removeHandler)
      where TEventArgs : EventArgs
    {
      if (conversion == null)
        throw new ArgumentNullException(nameof (conversion));
      if (addHandler == null)
        throw new ArgumentNullException(nameof (addHandler));
      if (removeHandler == null)
        throw new ArgumentNullException(nameof (removeHandler));
      return (IObservable<IEvent<TEventArgs>>) new AnonymousObservable<IEvent<TEventArgs>>((Func<IObserver<IEvent<TEventArgs>>, IDisposable>) (observer =>
      {
        TDelegate handler = conversion((EventHandler<TEventArgs>) ((sender, eventArgs) => observer.OnNext(Event.Create<TEventArgs>(sender, eventArgs))));
        addHandler(handler);
        return Disposable.Create((Action) (() => removeHandler(handler)));
      }));
    }

    public static IObservable<IEvent<TEventArgs>> FromEvent<TEventArgs>(
      Action<EventHandler<TEventArgs>> addHandler,
      Action<EventHandler<TEventArgs>> removeHandler)
      where TEventArgs : EventArgs
    {
      if (addHandler == null)
        throw new ArgumentNullException(nameof (addHandler));
      if (removeHandler == null)
        throw new ArgumentNullException(nameof (removeHandler));
      return Observable.FromEvent<EventHandler<TEventArgs>, TEventArgs>((Func<EventHandler<TEventArgs>, EventHandler<TEventArgs>>) (handler => handler), addHandler, removeHandler);
    }

    public static IObservable<IEvent<TEventArgs>> FromEvent<TEventArgs>(
      object target,
      string eventName)
      where TEventArgs : EventArgs
    {
      if (target == null)
        throw new ArgumentNullException(nameof (target));
      EventInfo eventInfo = eventName != null ? target.GetType().GetEvent(eventName, BindingFlags.Instance | BindingFlags.Public) : throw new ArgumentNullException(nameof (eventName));
      MethodInfo addMethod = eventInfo != null ? eventInfo.GetAddMethod() : throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "Could not find event '{0}' on object of type '{1}'.", (object) eventName, (object) target.GetType().FullName));
      MethodInfo removeMethod = eventInfo.GetRemoveMethod();
      if (addMethod == null)
        throw new InvalidOperationException("Event is missing the add method.");
      if (removeMethod == null)
        throw new InvalidOperationException("Event is missing the remove method.");
      ParameterInfo[] parameters1 = addMethod.GetParameters();
      Type delegateType = parameters1.Length == 1 ? parameters1[0].ParameterType : throw new InvalidOperationException("Add method should take 1 parameter.");
      MethodInfo method = delegateType.GetMethod("Invoke");
      ParameterInfo[] parameters2 = method.GetParameters();
      if (parameters2.Length == 2 && parameters2[0].ParameterType.Equals(typeof (object)) && (typeof (TEventArgs).Equals(parameters2[1].ParameterType) && method.ReturnType == typeof (void)))
        return (IObservable<IEvent<TEventArgs>>) new AnonymousObservable<IEvent<TEventArgs>>((Func<IObserver<IEvent<TEventArgs>>, IDisposable>) (observer =>
        {
          EventHandler<TEventArgs> eventHandler = (EventHandler<TEventArgs>) ((sender, eventArgs) => observer.OnNext(Event.Create<TEventArgs>(sender, eventArgs)));
          Delegate d = Delegate.CreateDelegate(delegateType, (object) eventHandler, "Invoke");
          addMethod.Invoke(target, new object[1]
          {
            (object) d
          });
          return Disposable.Create((Action) (() => removeMethod.Invoke(target, new object[1]
          {
            (object) d
          })));
        }));
      throw new InvalidOperationException("The event delegate must be of the form void Handler(object, T) where T : EventArgs.");
    }

    public static IObservable<TResult> Generate<TState, TResult>(
      TState initialState,
      Func<TState, bool> condition,
      Func<TState, TResult> resultSelector,
      Func<TState, TState> iterate,
      IScheduler scheduler)
    {
      if (condition == null)
        throw new ArgumentNullException(nameof (condition));
      if (resultSelector == null)
        throw new ArgumentNullException(nameof (resultSelector));
      if (iterate == null)
        throw new ArgumentNullException(nameof (iterate));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        bool first = true;
        return scheduler.Schedule((Action<Action>) (self =>
        {
          TResult result = default (TResult);
          bool flag;
          try
          {
            if (first)
              first = false;
            else
              initialState = iterate(initialState);
            flag = condition(initialState);
            if (flag)
              result = resultSelector(initialState);
          }
          catch (Exception ex)
          {
            observer.OnError(ex);
            return;
          }
          if (flag)
          {
            observer.OnNext(result);
            self();
          }
          else
            observer.OnCompleted();
        }));
      }));
    }

    public static IObservable<TResult> Generate<TState, TResult>(
      TState initialState,
      Func<TState, bool> condition,
      Func<TState, TResult> resultSelector,
      Func<TState, TState> iterate)
    {
      if (condition == null)
        throw new ArgumentNullException(nameof (condition));
      if (resultSelector == null)
        throw new ArgumentNullException(nameof (resultSelector));
      if (iterate == null)
        throw new ArgumentNullException(nameof (iterate));
      return Observable.Generate<TState, TResult>(initialState, condition, resultSelector, iterate, (IScheduler) Scheduler.CurrentThread);
    }

    public static IObservable<TValue> Defer<TValue>(
      Func<IObservable<TValue>> observableFactory)
    {
      if (observableFactory == null)
        throw new ArgumentNullException(nameof (observableFactory));
      return (IObservable<TValue>) new AnonymousObservable<TValue>((Func<IObserver<TValue>, IDisposable>) (observer =>
      {
        IObservable<TValue> iobservable;
        try
        {
          iobservable = observableFactory();
        }
        catch (Exception ex)
        {
          return Observable.Throw<TValue>(ex).Subscribe(observer);
        }
        return iobservable.Subscribe(observer);
      }));
    }

    public static IObservable<TSource> Using<TSource, TResource>(
      Func<TResource> resourceSelector,
      Func<TResource, IObservable<TSource>> resourceUsage)
      where TResource : IDisposable
    {
      if (resourceSelector == null)
        throw new ArgumentNullException(nameof (resourceSelector));
      if (resourceUsage == null)
        throw new ArgumentNullException(nameof (resourceUsage));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        IDisposable disposable = Disposable.Empty;
        IObservable<TSource> iobservable;
        try
        {
          TResource resource = resourceSelector();
          if ((object) resource != null)
            disposable = (IDisposable) resource;
          iobservable = resourceUsage(resource);
        }
        catch (Exception ex)
        {
          return (IDisposable) new CompositeDisposable(new IDisposable[2]
          {
            Observable.Throw<TSource>(ex).Subscribe(observer),
            disposable
          });
        }
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          iobservable.Subscribe(observer),
          disposable
        });
      }));
    }

    public static IObservable<TSource> ToObservable<TSource>(
      this IEnumerable<TSource> source)
    {
      return source != null ? source.ToObservable<TSource>((IScheduler) Scheduler.CurrentThread) : throw new ArgumentNullException(nameof (source));
    }

    public static IObservable<TSource> ToObservable<TSource>(
      this IEnumerable<TSource> source,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer => source.Subscribe<TSource>(observer, scheduler)));
    }

    public static IObservable<TSource> CreateWithDisposable<TSource>(
      Func<IObserver<TSource>, IDisposable> subscribe)
    {
      return subscribe != null ? (IObservable<TSource>) new AnonymousObservable<TSource>(subscribe) : throw new ArgumentNullException(nameof (subscribe));
    }

    public static IObservable<TSource> Create<TSource>(
      Func<IObserver<TSource>, Action> subscribe)
    {
      return subscribe != null ? Observable.CreateWithDisposable<TSource>((Func<IObserver<TSource>, IDisposable>) (o => Disposable.Create(subscribe(o)))) : throw new ArgumentNullException(nameof (subscribe));
    }

    public static IObservable<int> Range(int start, int count)
    {
      long num = (long) start + (long) count - 1L;
      if (count < 0 || num > (long) int.MaxValue)
        throw new ArgumentOutOfRangeException(nameof (count));
      return Observable.Range(start, count, (IScheduler) Scheduler.CurrentThread);
    }

    public static IObservable<int> Range(int start, int count, IScheduler scheduler)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      long max = (long) start + (long) count - 1L;
      if (count < 0 || max > (long) int.MaxValue)
        throw new ArgumentOutOfRangeException(nameof (count));
      return Observable.Generate<int, int>(start, (Func<int, bool>) (x => (long) x <= max), (Func<int, int>) (x => x), (Func<int, int>) (x => x + 1), scheduler);
    }

    private static IEnumerable<T> RepeatInfinite<T>(T value)
    {
      while (true)
        yield return value;
    }

    public static IObservable<TSource> Repeat<TSource>(this IObservable<TSource> source) => source != null ? Observable.RepeatInfinite<IObservable<TSource>>(source).Concat<TSource>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<TSource> Repeat<TSource>(
      this IObservable<TSource> source,
      int repeatCount)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return repeatCount >= 0 ? Enumerable.Repeat<IObservable<TSource>>(source, repeatCount).Concat<TSource>() : throw new ArgumentOutOfRangeException(nameof (repeatCount));
    }

    public static IObservable<TSource> Retry<TSource>(this IObservable<TSource> source) => source != null ? Observable.RepeatInfinite<IObservable<TSource>>(source).Catch<TSource>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<TSource> Retry<TSource>(
      this IObservable<TSource> source,
      int retryCount)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return retryCount >= 0 ? Enumerable.Repeat<IObservable<TSource>>(source, retryCount).Catch<TSource>() : throw new ArgumentOutOfRangeException(nameof (retryCount));
    }

    public static IObservable<TValue> Repeat<TValue>(TValue value, IScheduler scheduler) => scheduler != null ? Observable.Return<TValue>(value, scheduler).Repeat<TValue>() : throw new ArgumentNullException(nameof (scheduler));

    public static IObservable<TValue> Repeat<TValue>(
      TValue value,
      int repeatCount,
      IScheduler scheduler)
    {
      if (repeatCount < 0)
        throw new ArgumentOutOfRangeException(nameof (repeatCount));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return Observable.Return<TValue>(value, scheduler).Repeat<TValue>(repeatCount);
    }

    public static IObservable<TValue> Repeat<TValue>(TValue value) => Observable.Repeat<TValue>(value, (IScheduler) Scheduler.CurrentThread);

    public static IObservable<TValue> Repeat<TValue>(TValue value, int repeatCount)
    {
      if (repeatCount < 0)
        throw new ArgumentOutOfRangeException(nameof (repeatCount));
      return Observable.Repeat<TValue>(value, repeatCount, (IScheduler) Scheduler.CurrentThread);
    }

    public static Pattern<TLeft, TRight> And<TLeft, TRight>(
      this IObservable<TLeft> left,
      IObservable<TRight> right)
    {
      if (left == null)
        throw new ArgumentNullException(nameof (left));
      return right != null ? new Pattern<TLeft, TRight>(left, right) : throw new ArgumentNullException(nameof (right));
    }

    public static Plan<TResult> Then<TSource, TResult>(
      this IObservable<TSource> source,
      Func<TSource, TResult> selector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return selector != null ? new Pattern<TSource>(source).Then<TResult>(selector) : throw new ArgumentNullException(nameof (selector));
    }

    public static IObservable<TResult> Join<TResult>(params Plan<TResult>[] plans) => plans != null ? ((IEnumerable<Plan<TResult>>) plans).Join<TResult>() : throw new ArgumentNullException(nameof (plans));

    public static IObservable<TResult> Join<TResult>(
      this IEnumerable<Plan<TResult>> plans)
    {
      if (plans == null)
        throw new ArgumentNullException(nameof (plans));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        Dictionary<object, IJoinObserver> externalSubscriptions = new Dictionary<object, IJoinObserver>();
        object gate = new object();
        List<ActivePlan> activePlans = new List<ActivePlan>();
        IObserver<TResult> outObserver = Observer.Create<TResult>(new Action<TResult>(observer.OnNext), (Action<Exception>) (exception =>
        {
          foreach (IDisposable disposable in externalSubscriptions.Values)
            disposable.Dispose();
          observer.OnError(exception);
        }), new Action(observer.OnCompleted));
        try
        {
          foreach (Plan<TResult> plan in plans)
            activePlans.Add(plan.Activate(externalSubscriptions, outObserver, (Action<ActivePlan>) (activePlan =>
            {
              activePlans.Remove(activePlan);
              if (activePlans.Count != 0)
                return;
              outObserver.OnCompleted();
            })));
        }
        catch (Exception ex)
        {
          return Observable.Throw<TResult>(ex).Subscribe(observer);
        }
        CompositeDisposable compositeDisposable = new CompositeDisposable(new IDisposable[0]);
        foreach (IJoinObserver joinObserver in externalSubscriptions.Values)
        {
          joinObserver.Subscribe(gate);
          compositeDisposable.Add((IDisposable) joinObserver);
        }
        return (IDisposable) compositeDisposable;
      }));
    }

    internal static IObservable<TResult> Combine<TLeft, TRight, TResult>(
      this IObservable<TLeft> leftSource,
      IObservable<TRight> rightSource,
      Func<IObserver<TResult>, IDisposable, IDisposable, IObserver<Either<Notification<TLeft>, Notification<TRight>>>> combinerSelector)
    {
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        MutableDisposable mutableDisposable1 = new MutableDisposable();
        MutableDisposable mutableDisposable2 = new MutableDisposable();
        IObserver<Either<Notification<TLeft>, Notification<TRight>>> iobserver = combinerSelector(observer, (IDisposable) mutableDisposable1, (IDisposable) mutableDisposable2);
        object gate = new object();
        mutableDisposable1.Disposable = leftSource.Materialize<TLeft>().Select<Notification<TLeft>, Either<Notification<TLeft>, Notification<TRight>>>((Func<Notification<TLeft>, Either<Notification<TLeft>, Notification<TRight>>>) (x => Either<Notification<TLeft>, Notification<TRight>>.CreateLeft(x))).Synchronize<Either<Notification<TLeft>, Notification<TRight>>>(gate).Subscribe(iobserver);
        mutableDisposable2.Disposable = rightSource.Materialize<TRight>().Select<Notification<TRight>, Either<Notification<TLeft>, Notification<TRight>>>((Func<Notification<TRight>, Either<Notification<TLeft>, Notification<TRight>>>) (x => Either<Notification<TLeft>, Notification<TRight>>.CreateRight(x))).Synchronize<Either<Notification<TLeft>, Notification<TRight>>>(gate).Subscribe(iobserver);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          (IDisposable) mutableDisposable1,
          (IDisposable) mutableDisposable2
        });
      }));
    }

    public static IObservable<TSource> Merge<TSource>(
      this IObservable<IObservable<TSource>> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        object gate = new object();
        bool isStopped = false;
        CompositeDisposable group = new CompositeDisposable(new IDisposable[0]);
        MutableDisposable mutableDisposable = new MutableDisposable();
        group.Add((IDisposable) mutableDisposable);
        mutableDisposable.Disposable = source.Subscribe<IObservable<TSource>>((Action<IObservable<TSource>>) (innerSource =>
        {
          MutableDisposable innerSubscription = new MutableDisposable();
          group.Add((IDisposable) innerSubscription);
          innerSubscription.Disposable = innerSource.Subscribe<TSource>((Action<TSource>) (x =>
          {
            lock (gate)
              observer.OnNext(x);
          }), (Action<Exception>) (exception =>
          {
            lock (gate)
              observer.OnError(exception);
          }), (Action) (() =>
          {
            group.Remove((IDisposable) innerSubscription);
            if (!isStopped || group.Count != 1)
              return;
            lock (gate)
              observer.OnCompleted();
          }));
        }), (Action<Exception>) (exception =>
        {
          lock (gate)
            observer.OnError(exception);
        }), (Action) (() =>
        {
          isStopped = true;
          if (group.Count != 1)
            return;
          lock (gate)
            observer.OnCompleted();
        }));
        return (IDisposable) group;
      }));
    }

    public static IObservable<TSource> Switch<TSource>(
      this IObservable<IObservable<TSource>> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        object gate = new object();
        MutableDisposable innerSubscription = new MutableDisposable();
        MutableDisposable subscription = new MutableDisposable();
        bool isStopped = false;
        subscription.Disposable = source.Subscribe<IObservable<TSource>>((Action<IObservable<TSource>>) (innerSource =>
        {
          MutableDisposable mutableDisposable = new MutableDisposable();
          innerSubscription.Disposable = (IDisposable) mutableDisposable;
          mutableDisposable.Disposable = innerSource.Subscribe<TSource>((Action<TSource>) (x =>
          {
            lock (gate)
              observer.OnNext(x);
          }), (Action<Exception>) (exception =>
          {
            subscription.Dispose();
            innerSubscription.Dispose();
            lock (gate)
              observer.OnError(exception);
          }), (Action) (() =>
          {
            innerSubscription.Disposable = (IDisposable) null;
            if (!isStopped)
              return;
            lock (gate)
              observer.OnCompleted();
          }));
        }), (Action<Exception>) (exception =>
        {
          innerSubscription.Dispose();
          lock (gate)
            observer.OnError(exception);
        }), (Action) (() =>
        {
          isStopped = true;
          if (innerSubscription.Disposable != null)
            return;
          lock (gate)
            observer.OnCompleted();
        }));
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          (IDisposable) subscription,
          (IDisposable) innerSubscription
        });
      }));
    }

    public static IObservable<TSource> Concat<TSource>(
      this IObservable<TSource> first,
      IObservable<TSource> second)
    {
      if (first == null)
        throw new ArgumentNullException(nameof (first));
      return second != null ? Observable.Concat<TSource>(new IObservable<TSource>[2]
      {
        first,
        second
      }) : throw new ArgumentNullException(nameof (second));
    }

    public static IObservable<TSource> Concat<TSource>(
      params IObservable<TSource>[] sources)
    {
      return sources != null ? ((IEnumerable<IObservable<TSource>>) sources).Concat<TSource>() : throw new ArgumentNullException(nameof (sources));
    }

    public static IObservable<TSource> Concat<TSource>(
      this IEnumerable<IObservable<TSource>> sources)
    {
      if (sources == null)
        throw new ArgumentNullException(nameof (sources));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        IEnumerator<IObservable<TSource>> e = sources.GetEnumerator();
        MutableDisposable subscription = new MutableDisposable();
        IDisposable disposable = Scheduler.Immediate.Schedule((Action<Action>) (self =>
        {
          IObservable<TSource> source = (IObservable<TSource>) null;
          bool flag;
          try
          {
            flag = ((IEnumerator) e).MoveNext();
            if (flag)
              source = e.Current;
            else
              ((IDisposable) e).Dispose();
          }
          catch (Exception ex)
          {
            observer.OnError(ex);
            ((IDisposable) e).Dispose();
            return;
          }
          if (!flag)
          {
            observer.OnCompleted();
          }
          else
          {
            MutableDisposable mutableDisposable = new MutableDisposable();
            subscription.Disposable = (IDisposable) mutableDisposable;
            mutableDisposable.Disposable = source.Subscribe<TSource>(new Action<TSource>(observer.OnNext), new Action<Exception>(observer.OnError), self);
          }
        }));
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          (IDisposable) subscription,
          disposable
        });
      }));
    }

    public static IObservable<TSource> Catch<TSource, TException>(
      this IObservable<TSource> source,
      Func<TException, IObservable<TSource>> handler)
      where TException : Exception
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (handler == null)
        throw new ArgumentNullException(nameof (handler));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        MutableDisposable subscription = new MutableDisposable();
        subscription.Disposable = source.Subscribe<TSource>(new Action<TSource>(observer.OnNext), (Action<Exception>) (exception =>
        {
          if (exception is TException exception3)
          {
            IObservable<TSource> iobservable;
            try
            {
              iobservable = handler(exception3);
            }
            catch (Exception ex)
            {
              observer.OnError(ex);
              return;
            }
            MutableDisposable mutableDisposable = new MutableDisposable();
            subscription.Disposable = (IDisposable) mutableDisposable;
            mutableDisposable.Disposable = iobservable.Subscribe(observer);
          }
          else
            observer.OnError(exception);
        }), new Action(observer.OnCompleted));
        return (IDisposable) subscription;
      }));
    }

    public static IObservable<TSource> Catch<TSource>(
      this IObservable<TSource> first,
      IObservable<TSource> second)
    {
      if (first == null)
        throw new ArgumentNullException(nameof (first));
      return second != null ? Observable.Catch<TSource>(new IObservable<TSource>[2]
      {
        first,
        second
      }) : throw new ArgumentNullException(nameof (second));
    }

    public static IObservable<TSource> Catch<TSource>(
      params IObservable<TSource>[] sources)
    {
      return sources != null ? ((IEnumerable<IObservable<TSource>>) sources).Catch<TSource>() : throw new ArgumentNullException(nameof (sources));
    }

    public static IObservable<TSource> Catch<TSource>(
      this IEnumerable<IObservable<TSource>> sources)
    {
      if (sources == null)
        throw new ArgumentNullException(nameof (sources));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        IEnumerator<IObservable<TSource>> e = sources.GetEnumerator();
        MutableDisposable subscription = new MutableDisposable();
        Exception lastException = (Exception) null;
        IDisposable disposable = Scheduler.Immediate.Schedule((Action<Action>) (self =>
        {
          if (subscription == null)
            return;
          IObservable<TSource> source = (IObservable<TSource>) null;
          bool flag;
          try
          {
            flag = ((IEnumerator) e).MoveNext();
            if (flag)
              source = e.Current;
            else
              ((IDisposable) e).Dispose();
          }
          catch (Exception ex)
          {
            observer.OnError(ex);
            ((IDisposable) e).Dispose();
            return;
          }
          if (!flag)
          {
            if (lastException != null)
              observer.OnError(lastException);
            else
              observer.OnCompleted();
          }
          else
          {
            MutableDisposable mutableDisposable = new MutableDisposable();
            subscription.Disposable = (IDisposable) mutableDisposable;
            mutableDisposable.Disposable = source.Subscribe<TSource>(new Action<TSource>(observer.OnNext), (Action<Exception>) (exception =>
            {
              lastException = exception;
              self();
            }), new Action(observer.OnCompleted));
          }
        }));
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          (IDisposable) subscription,
          disposable
        });
      }));
    }

    public static IObservable<TSource> OnErrorResumeNext<TSource>(
      this IObservable<TSource> first,
      IObservable<TSource> second)
    {
      if (first == null)
        throw new ArgumentNullException(nameof (first));
      return second != null ? Observable.OnErrorResumeNext<TSource>(new IObservable<TSource>[2]
      {
        first,
        second
      }) : throw new ArgumentNullException(nameof (second));
    }

    public static IObservable<TSource> OnErrorResumeNext<TSource>(
      params IObservable<TSource>[] sources)
    {
      return sources != null ? ((IEnumerable<IObservable<TSource>>) sources).OnErrorResumeNext<TSource>() : throw new ArgumentNullException(nameof (sources));
    }

    public static IObservable<TSource> OnErrorResumeNext<TSource>(
      this IEnumerable<IObservable<TSource>> sources)
    {
      if (sources == null)
        throw new ArgumentNullException(nameof (sources));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        IEnumerator<IObservable<TSource>> e = sources.GetEnumerator();
        MutableDisposable subscription = new MutableDisposable();
        IDisposable disposable = Scheduler.Immediate.Schedule((Action<Action>) (self =>
        {
          IObservable<TSource> source = (IObservable<TSource>) null;
          bool flag;
          try
          {
            flag = ((IEnumerator) e).MoveNext();
            if (flag)
              source = e.Current;
            else
              ((IDisposable) e).Dispose();
          }
          catch (Exception ex)
          {
            observer.OnError(ex);
            ((IDisposable) e).Dispose();
            return;
          }
          if (!flag)
          {
            observer.OnCompleted();
          }
          else
          {
            MutableDisposable mutableDisposable = new MutableDisposable();
            subscription.Disposable = (IDisposable) mutableDisposable;
            mutableDisposable.Disposable = source.Subscribe<TSource>(new Action<TSource>(observer.OnNext), (Action<Exception>) (exception => self()), self);
          }
        }));
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          (IDisposable) subscription,
          disposable
        });
      }));
    }

    public static IObservable<TResult> Zip<TLeft, TRight, TResult>(
      this IObservable<TLeft> leftSource,
      IObservable<TRight> rightSource,
      Func<TLeft, TRight, TResult> selector)
    {
      if (leftSource == null)
        throw new ArgumentNullException(nameof (leftSource));
      if (rightSource == null)
        throw new ArgumentNullException(nameof (rightSource));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return leftSource.Combine<TLeft, TRight, TResult>(rightSource, (Func<IObserver<TResult>, IDisposable, IDisposable, IObserver<Either<Notification<TLeft>, Notification<TRight>>>>) ((observer, leftSubscription, rightSubscription) =>
      {
        Observable.ZipHelper<TLeft, TRight, TResult> zipHelper = new Observable.ZipHelper<TLeft, TRight, TResult>(selector, observer);
        return (IObserver<Either<Notification<TLeft>, Notification<TRight>>>) new BinaryObserver<TLeft, TRight>(new Action<Notification<TLeft>>(zipHelper.Left.OnNext), new Action<Notification<TRight>>(zipHelper.Right.OnNext));
      }));
    }

    public static IObservable<TResult> Zip<TLeft, TRight, TResult>(
      this IObservable<TLeft> leftSource,
      IEnumerable<TRight> rightSource,
      Func<TLeft, TRight, TResult> selector)
    {
      if (leftSource == null)
        throw new ArgumentNullException(nameof (leftSource));
      if (rightSource == null)
        throw new ArgumentNullException(nameof (rightSource));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        IEnumerator<TRight> rightEnumerator = rightSource.GetEnumerator();
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          leftSource.Subscribe<TLeft>((Action<TLeft>) (left =>
          {
            bool flag;
            try
            {
              flag = rightEnumerator.MoveNext();
            }
            catch (Exception ex)
            {
              observer.OnError(ex);
              return;
            }
            if (flag)
            {
              TRight right = default (TRight);
              TRight current;
              try
              {
                current = rightEnumerator.Current;
              }
              catch (Exception ex)
              {
                observer.OnError(ex);
                return;
              }
              TResult result;
              try
              {
                result = selector(left, current);
              }
              catch (Exception ex)
              {
                observer.OnError(ex);
                return;
              }
              observer.OnNext(result);
            }
            else
              observer.OnCompleted();
          }), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted)),
          (IDisposable) rightEnumerator
        });
      }));
    }

    public static IObservable<TResult> CombineLatest<TLeft, TRight, TResult>(
      this IObservable<TLeft> leftSource,
      IObservable<TRight> rightSource,
      Func<TLeft, TRight, TResult> selector)
    {
      if (leftSource == null)
        throw new ArgumentNullException(nameof (leftSource));
      if (rightSource == null)
        throw new ArgumentNullException(nameof (rightSource));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return leftSource.Combine<TLeft, TRight, TResult>(rightSource, (Func<IObserver<TResult>, IDisposable, IDisposable, IObserver<Either<Notification<TLeft>, Notification<TRight>>>>) ((observer, leftSubscription, rightSubscription) =>
      {
        Observable.CombineLatestHelper<TLeft, TRight, TResult> combineLatestHelper = new Observable.CombineLatestHelper<TLeft, TRight, TResult>(selector, observer);
        return (IObserver<Either<Notification<TLeft>, Notification<TRight>>>) new BinaryObserver<TLeft, TRight>(new Action<Notification<TLeft>>(combineLatestHelper.Left.OnNext), new Action<Notification<TRight>>(combineLatestHelper.Right.OnNext));
      }));
    }

    public static IObservable<TSource> Amb<TSource>(
      this IObservable<TSource> leftSource,
      IObservable<TSource> rightSource)
    {
      if (leftSource == null)
        throw new ArgumentNullException(nameof (leftSource));
      return rightSource != null ? Observable.AmbHelper<TSource>(leftSource, rightSource) : throw new ArgumentNullException(nameof (rightSource));
    }

    public static IObservable<TSource> Amb<TSource>(params IObservable<TSource>[] sources) => sources != null ? Observable.AmbHelper<TSource>((IEnumerable<IObservable<TSource>>) sources) : throw new ArgumentNullException(nameof (sources));

    public static IObservable<TSource> Amb<TSource>(
      this IEnumerable<IObservable<TSource>> sources)
    {
      return sources != null ? Observable.AmbHelper<TSource>(sources) : throw new ArgumentNullException(nameof (sources));
    }

    private static IObservable<TSource> AmbHelper<TSource>(
      IEnumerable<IObservable<TSource>> sources)
    {
      return (IObservable<TSource>) Enumerable.Aggregate<IObservable<TSource>, IObservable<TSource>>((IEnumerable<M0>) sources, (M1) Observable.Never<TSource>(), (Func<M1, M0, M1>) ((previous, current) => previous.Amb<TSource>(current)));
    }

    private static IObservable<TSource> AmbHelper<TSource>(
      IObservable<TSource> leftSource,
      IObservable<TSource> rightSource)
    {
      return leftSource.Combine<TSource, TSource, TSource>(rightSource, (Func<IObserver<TSource>, IDisposable, IDisposable, IObserver<Either<Notification<TSource>, Notification<TSource>>>>) ((observer, leftSubscription, rightSubscription) =>
      {
        Observable.AmbState choice = Observable.AmbState.Neither;
        return (IObserver<Either<Notification<TSource>, Notification<TSource>>>) new BinaryObserver<TSource, TSource>((Action<Notification<TSource>>) (left =>
        {
          if (choice == Observable.AmbState.Neither)
          {
            choice = Observable.AmbState.Left;
            rightSubscription.Dispose();
          }
          if (choice != Observable.AmbState.Left)
            return;
          left.Accept(observer);
        }), (Action<Notification<TSource>>) (right =>
        {
          if (choice == Observable.AmbState.Neither)
          {
            choice = Observable.AmbState.Right;
            leftSubscription.Dispose();
          }
          if (choice != Observable.AmbState.Right)
            return;
          right.Accept(observer);
        }));
      }));
    }

    public static IObservable<TResult> ForkJoin<TLeft, TRight, TResult>(
      this IObservable<TLeft> leftSource,
      IObservable<TRight> rightSource,
      Func<TLeft, TRight, TResult> selector)
    {
      if (leftSource == null)
        throw new ArgumentNullException(nameof (leftSource));
      if (rightSource == null)
        throw new ArgumentNullException(nameof (rightSource));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return leftSource.Combine<TLeft, TRight, TResult>(rightSource, (Func<IObserver<TResult>, IDisposable, IDisposable, IObserver<Either<Notification<TLeft>, Notification<TRight>>>>) ((observer, leftSubscription, rightSubscription) =>
      {
        bool leftStopped = false;
        bool rightStopped = false;
        bool hasLeft = false;
        bool hasRight = false;
        TLeft lastLeft = default (TLeft);
        TRight lastRight = default (TRight);
        return (IObserver<Either<Notification<TLeft>, Notification<TRight>>>) new BinaryObserver<TLeft, TRight>((Action<Notification<TLeft>>) (left =>
        {
          switch (left.Kind)
          {
            case NotificationKind.OnNext:
              hasLeft = true;
              lastLeft = left.Value;
              break;
            case NotificationKind.OnError:
              rightSubscription.Dispose();
              observer.OnError(left.Exception);
              break;
            case NotificationKind.OnCompleted:
              leftStopped = true;
              if (!rightStopped)
                break;
              if (!hasLeft)
              {
                observer.OnCompleted();
                break;
              }
              if (!hasRight)
              {
                observer.OnCompleted();
                break;
              }
              TResult result;
              try
              {
                result = selector(lastLeft, lastRight);
              }
              catch (Exception ex)
              {
                observer.OnError(ex);
                break;
              }
              observer.OnNext(result);
              observer.OnCompleted();
              break;
          }
        }), (Action<Notification<TRight>>) (right =>
        {
          switch (right.Kind)
          {
            case NotificationKind.OnNext:
              hasRight = true;
              lastRight = right.Value;
              break;
            case NotificationKind.OnError:
              rightSubscription.Dispose();
              observer.OnError(right.Exception);
              break;
            case NotificationKind.OnCompleted:
              rightStopped = true;
              if (!leftStopped)
                break;
              if (!hasLeft)
              {
                observer.OnCompleted();
                break;
              }
              if (!hasRight)
              {
                observer.OnCompleted();
                break;
              }
              TResult result;
              try
              {
                result = selector(lastLeft, lastRight);
              }
              catch (Exception ex)
              {
                observer.OnError(ex);
                break;
              }
              observer.OnNext(result);
              observer.OnCompleted();
              break;
          }
        }));
      }));
    }

    public static IObservable<TSource[]> ForkJoin<TSource>(
      params IObservable<TSource>[] sources)
    {
      return sources != null ? ((IEnumerable<IObservable<TSource>>) sources).ForkJoin<TSource>() : throw new ArgumentNullException(nameof (sources));
    }

    public static IObservable<TSource[]> ForkJoin<TSource>(
      this IEnumerable<IObservable<TSource>> sources)
    {
      if (sources == null)
        throw new ArgumentNullException(nameof (sources));
      return ((IObservable<List<TSource>>) Enumerable.Aggregate<IObservable<TSource>, IObservable<List<TSource>>>((IEnumerable<M0>) sources, (M1) Observable.Return<List<TSource>>(new List<TSource>()), (Func<M1, M0, M1>) ((xs, ys) => xs.ForkJoin<List<TSource>, TSource, List<TSource>>(ys, (Func<List<TSource>, TSource, List<TSource>>) ((x, y) =>
      {
        x.Add(y);
        return x;
      }))))).Select<List<TSource>, TSource[]>((Func<List<TSource>, TSource[]>) (x => x.ToArray()));
    }

    public static IObservable<TSource> TakeUntil<TSource, TOther>(
      this IObservable<TSource> source,
      IObservable<TOther> other)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (other == null)
        throw new ArgumentNullException(nameof (other));
      return other.Combine<TOther, TSource, TSource>(source, (Func<IObserver<TSource>, IDisposable, IDisposable, IObserver<Either<Notification<TOther>, Notification<TSource>>>>) ((observer, otherSubscription, sourceSubscription) =>
      {
        bool isSourceStopped = false;
        bool isOtherStopped = false;
        return (IObserver<Either<Notification<TOther>, Notification<TSource>>>) new BinaryObserver<TOther, TSource>((Action<Notification<TOther>>) (otherValue =>
        {
          if (isSourceStopped || isOtherStopped)
            return;
          if (otherValue.Kind == NotificationKind.OnCompleted)
            isOtherStopped = true;
          else if (otherValue.Kind == NotificationKind.OnError)
          {
            isOtherStopped = true;
            isSourceStopped = true;
            observer.OnError(otherValue.Exception);
          }
          else
          {
            isSourceStopped = true;
            observer.OnCompleted();
          }
        }), (Action<Notification<TSource>>) (sourceValue =>
        {
          if (isSourceStopped)
            return;
          sourceValue.Accept(observer);
          isSourceStopped = (uint) sourceValue.Kind > 0U;
          if (!isSourceStopped)
            return;
          otherSubscription.Dispose();
        }));
      }));
    }

    public static IObservable<TSource> SkipUntil<TSource, TOther>(
      this IObservable<TSource> source,
      IObservable<TOther> other)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (other == null)
        throw new ArgumentNullException(nameof (other));
      return source.Combine<TSource, TOther, TSource>(other, (Func<IObserver<TSource>, IDisposable, IDisposable, IObserver<Either<Notification<TSource>, Notification<TOther>>>>) ((observer, leftSubscription, rightSubscription) =>
      {
        bool open = false;
        bool rightStopped = false;
        return (IObserver<Either<Notification<TSource>, Notification<TOther>>>) new BinaryObserver<TSource, TOther>((Action<Notification<TSource>>) (left =>
        {
          if (!open)
            return;
          left.Accept(observer);
        }), (Action<Notification<TOther>>) (right =>
        {
          if (rightStopped)
            return;
          if (right.Kind == NotificationKind.OnNext)
            open = true;
          else if (right.Kind == NotificationKind.OnError)
            observer.OnError(right.Exception);
          rightStopped = true;
          rightSubscription.Dispose();
        }));
      }));
    }

    public static IObservable<TSource> Merge<TSource>(
      this IObservable<TSource> leftSource,
      IObservable<TSource> rightSource,
      IScheduler scheduler)
    {
      if (leftSource == null)
        throw new ArgumentNullException(nameof (leftSource));
      if (rightSource == null)
        throw new ArgumentNullException(nameof (rightSource));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return ((IEnumerable<IObservable<TSource>>) new IObservable<TSource>[2]
      {
        leftSource,
        rightSource
      }).Merge<TSource>(scheduler);
    }

    public static IObservable<TSource> Merge<TSource>(
      this IObservable<TSource> leftSource,
      IObservable<TSource> rightSource)
    {
      if (leftSource == null)
        throw new ArgumentNullException(nameof (leftSource));
      return rightSource != null ? Observable.Merge<TSource>(new IObservable<TSource>[2]
      {
        leftSource,
        rightSource
      }) : throw new ArgumentNullException(nameof (rightSource));
    }

    public static IObservable<TSource> Merge<TSource>(
      params IObservable<TSource>[] sources)
    {
      return sources != null ? ((IEnumerable<IObservable<TSource>>) sources).Merge<TSource>() : throw new ArgumentNullException(nameof (sources));
    }

    public static IObservable<TSource> Merge<TSource>(
      IScheduler scheduler,
      params IObservable<TSource>[] sources)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return sources != null ? ((IEnumerable<IObservable<TSource>>) sources).Merge<TSource>(scheduler) : throw new ArgumentNullException(nameof (sources));
    }

    public static IObservable<TSource> Merge<TSource>(
      this IEnumerable<IObservable<TSource>> sources)
    {
      return sources != null ? sources.Merge<TSource>((IScheduler) Scheduler.Immediate) : throw new ArgumentNullException(nameof (sources));
    }

    public static IObservable<TSource> Merge<TSource>(
      this IEnumerable<IObservable<TSource>> sources,
      IScheduler scheduler)
    {
      if (sources == null)
        throw new ArgumentNullException(nameof (sources));
      return scheduler != null ? sources.ToObservable<IObservable<TSource>>(scheduler).Merge<TSource>() : throw new ArgumentNullException(nameof (scheduler));
    }

    public static IObservable<Notification<TSource>> Materialize<TSource>(
      this IObservable<TSource> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return (IObservable<Notification<TSource>>) new AnonymousObservable<Notification<TSource>>((Func<IObserver<Notification<TSource>>, IDisposable>) (observer => source.Subscribe<TSource>((Action<TSource>) (value => observer.OnNext((Notification<TSource>) new Notification<TSource>.OnNext(value))), (Action<Exception>) (exception =>
      {
        observer.OnNext((Notification<TSource>) new Notification<TSource>.OnError(exception));
        observer.OnCompleted();
      }), (Action) (() =>
      {
        observer.OnNext((Notification<TSource>) new Notification<TSource>.OnCompleted());
        observer.OnCompleted();
      }))));
    }

    public static IObservable<TSource> Dematerialize<TSource>(
      this IObservable<Notification<TSource>> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer => source.Subscribe<Notification<TSource>>((Action<Notification<TSource>>) (x => x.Accept(observer)), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted))));
    }

    public static IObservable<TSource> AsObservable<TSource>(
      this IObservable<TSource> source)
    {
      return source != null ? (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer => source.Subscribe(observer))) : throw new ArgumentNullException(nameof (source));
    }

    public static IObservable<IList<TSource>> BufferWithCount<TSource>(
      this IObservable<TSource> source,
      int count,
      int skip)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (count <= 0)
        throw new ArgumentOutOfRangeException(nameof (count));
      if (skip <= 0)
        throw new ArgumentOutOfRangeException(nameof (skip));
      return (IObservable<IList<TSource>>) new AnonymousObservable<IList<TSource>>((Func<IObserver<IList<TSource>>, IDisposable>) (observer =>
      {
        List<TSource> list = new List<TSource>();
        int n = 0;
        return source.Subscribe<TSource>((Action<TSource>) (x =>
        {
          if (n == 0)
            list.Add(x);
          else
            --n;
          if (list.Count != count)
            return;
          List<TSource> list1 = list.ToList<TSource>();
          list.RemoveRange(0, Math.Min(skip, list.Count));
          n = Math.Max(0, skip - count);
          observer.OnNext((IList<TSource>) list1);
        }), (Action<Exception>) (ex =>
        {
          List<TSource> list1 = list.ToList<TSource>();
          if (list1.Count > 0)
            observer.OnNext((IList<TSource>) list1);
          observer.OnError(ex);
        }), (Action) (() =>
        {
          List<TSource> list1 = list.ToList<TSource>();
          if (list1.Count > 0)
            observer.OnNext((IList<TSource>) list1);
          observer.OnCompleted();
        }));
      }));
    }

    public static IObservable<IList<TSource>> BufferWithCount<TSource>(
      this IObservable<TSource> source,
      int count)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (count <= 0)
        throw new ArgumentOutOfRangeException(nameof (count));
      IObservable<TSource> source1 = source;
      int num = count;
      return source1.BufferWithCount<TSource>(num, num);
    }

    public static IObservable<TSource> StartWith<TSource>(
      this IObservable<TSource> source,
      params TSource[] values)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.StartWith<TSource>((IScheduler) Scheduler.CurrentThread, values);
    }

    public static IObservable<TSource> StartWith<TSource>(
      this IObservable<TSource> source,
      IScheduler scheduler,
      params TSource[] values)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return ((IEnumerable<TSource>) values).ToObservable<TSource>(scheduler).Concat<TSource>(source);
    }

    public static IObservable<TAccumulate> Scan<TSource, TAccumulate>(
      this IObservable<TSource> source,
      TAccumulate seed,
      Func<TAccumulate, TSource, TAccumulate> accumulator)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (accumulator == null)
        throw new ArgumentNullException(nameof (accumulator));
      return Observable.Defer<TAccumulate>((Func<IObservable<TAccumulate>>) (() =>
      {
        TAccumulate accumulation = default (TAccumulate);
        bool hasAccumulation = false;
        return source.Select<TSource, TAccumulate>((Func<TSource, TAccumulate>) (x =>
        {
          if (hasAccumulation)
          {
            accumulation = accumulator(accumulation, x);
          }
          else
          {
            accumulation = accumulator(seed, x);
            hasAccumulation = true;
          }
          return accumulation;
        }));
      }));
    }

    public static IObservable<TAccumulate> Scan0<TSource, TAccumulate>(
      this IObservable<TSource> source,
      TAccumulate seed,
      Func<TAccumulate, TSource, TAccumulate> accumulator)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (accumulator == null)
        throw new ArgumentNullException(nameof (accumulator));
      return Observable.CreateWithDisposable<TAccumulate>((Func<IObserver<TAccumulate>, IDisposable>) (observer =>
      {
        bool atBegin = true;
        return source.Subscribe<TSource>((Action<TSource>) (value =>
        {
          if (atBegin)
          {
            observer.OnNext(seed);
            atBegin = false;
          }
          try
          {
            seed = accumulator(seed, value);
          }
          catch (Exception ex)
          {
            observer.OnError(ex);
            return;
          }
          observer.OnNext(seed);
        }), (Action<Exception>) (exception => observer.OnError(exception)), (Action) (() =>
        {
          if (atBegin)
            observer.OnNext(seed);
          observer.OnCompleted();
        }));
      }));
    }

    public static IObservable<TSource> Scan<TSource>(
      this IObservable<TSource> source,
      Func<TSource, TSource, TSource> accumulator)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (accumulator == null)
        throw new ArgumentNullException(nameof (accumulator));
      return Observable.Defer<TSource>((Func<IObservable<TSource>>) (() =>
      {
        TSource accumulation = default (TSource);
        bool hasAccumulation = false;
        return source.Select<TSource, TSource>((Func<TSource, TSource>) (x =>
        {
          if (hasAccumulation)
          {
            accumulation = accumulator(accumulation, x);
          }
          else
          {
            accumulation = x;
            hasAccumulation = true;
          }
          return accumulation;
        }));
      }));
    }

    public static IObservable<TSource> DistinctUntilChanged<TSource, TKey>(
      this IObservable<TSource> source,
      Func<TSource, TKey> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (keySelector == null)
        throw new ArgumentNullException(nameof (keySelector));
      if (comparer == null)
        throw new ArgumentNullException(nameof (comparer));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        TKey currentKey = default (TKey);
        bool hasCurrentKey = false;
        return source.Subscribe<TSource>((Action<TSource>) (value =>
        {
          TKey key = default (TKey);
          TKey y;
          try
          {
            y = keySelector(value);
          }
          catch (Exception ex)
          {
            observer.OnError(ex);
            return;
          }
          bool flag = false;
          if (hasCurrentKey)
          {
            try
            {
              flag = comparer.Equals(currentKey, y);
            }
            catch (Exception ex)
            {
              observer.OnError(ex);
              return;
            }
          }
          if (hasCurrentKey && flag)
            return;
          hasCurrentKey = true;
          currentKey = y;
          observer.OnNext(value);
        }), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted));
      }));
    }

    public static IObservable<TSource> DistinctUntilChanged<TSource>(
      this IObservable<TSource> source,
      IEqualityComparer<TSource> comparer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (comparer == null)
        throw new ArgumentNullException(nameof (comparer));
      return source.DistinctUntilChanged<TSource, TSource>((Func<TSource, TSource>) (x => x), comparer);
    }

    public static IObservable<TSource> DistinctUntilChanged<TSource, TKey>(
      this IObservable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (keySelector == null)
        throw new ArgumentNullException(nameof (keySelector));
      return source.DistinctUntilChanged<TSource, TKey>(keySelector, (IEqualityComparer<TKey>) EqualityComparer<TKey>.Default);
    }

    public static IObservable<TSource> DistinctUntilChanged<TSource>(
      this IObservable<TSource> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.DistinctUntilChanged<TSource, TSource>((Func<TSource, TSource>) (x => x), (IEqualityComparer<TSource>) EqualityComparer<TSource>.Default);
    }

    public static IObservable<TSource> Finally<TSource>(
      this IObservable<TSource> source,
      Action finallyAction)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (finallyAction == null)
        throw new ArgumentNullException(nameof (finallyAction));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        IDisposable subscription = source.Subscribe(observer);
        return Disposable.Create((Action) (() =>
        {
          try
          {
            subscription.Dispose();
          }
          finally
          {
            finallyAction();
          }
        }));
      }));
    }

    public static IObservable<TSource> Do<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (obs => source.Subscribe<TSource>((Action<TSource>) (x =>
      {
        try
        {
          onNext(x);
        }
        catch (Exception ex)
        {
          obs.OnError(ex);
        }
        obs.OnNext(x);
      }), new Action<Exception>(obs.OnError), new Action(obs.OnCompleted))));
    }

    public static IObservable<TSource> Do<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext,
      Action onCompleted)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onCompleted == null)
        throw new ArgumentNullException(nameof (onCompleted));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (obs => source.Subscribe<TSource>((Action<TSource>) (x =>
      {
        try
        {
          onNext(x);
        }
        catch (Exception ex)
        {
          obs.OnError(ex);
        }
        obs.OnNext(x);
      }), new Action<Exception>(obs.OnError), (Action) (() =>
      {
        try
        {
          onCompleted();
        }
        catch (Exception ex)
        {
          obs.OnError(ex);
        }
        obs.OnCompleted();
      }))));
    }

    public static IObservable<TSource> Do<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext,
      Action<Exception> onError)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onError == null)
        throw new ArgumentNullException(nameof (onError));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (obs => source.Subscribe<TSource>((Action<TSource>) (x =>
      {
        try
        {
          onNext(x);
        }
        catch (Exception ex)
        {
          obs.OnError(ex);
        }
        obs.OnNext(x);
      }), (Action<Exception>) (ex =>
      {
        try
        {
          onError(ex);
        }
        catch (Exception ex1)
        {
          obs.OnError(ex1);
        }
        obs.OnError(ex);
      }), new Action(obs.OnCompleted))));
    }

    public static IObservable<TSource> Do<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext,
      Action<Exception> onError,
      Action onCompleted)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onError == null)
        throw new ArgumentNullException(nameof (onError));
      if (onCompleted == null)
        throw new ArgumentNullException(nameof (onCompleted));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (obs => source.Subscribe<TSource>((Action<TSource>) (x =>
      {
        try
        {
          onNext(x);
        }
        catch (Exception ex)
        {
          obs.OnError(ex);
        }
        obs.OnNext(x);
      }), (Action<Exception>) (ex =>
      {
        try
        {
          onError(ex);
        }
        catch (Exception ex1)
        {
          obs.OnError(ex1);
        }
        obs.OnError(ex);
      }), (Action) (() =>
      {
        try
        {
          onCompleted();
        }
        catch (Exception ex)
        {
          obs.OnError(ex);
        }
        obs.OnCompleted();
      }))));
    }

    public static IObservable<TSource> Do<TSource>(
      this IObservable<TSource> source,
      IObserver<TSource> observer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return observer != null ? source.Do<TSource>(new Action<TSource>(observer.OnNext), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted)) : throw new ArgumentNullException(nameof (observer));
    }

    private static IEnumerable<IObservable<TSource>> WhileCore<TSource>(
      Func<bool> condition,
      IObservable<TSource> source)
    {
      Func<bool> func;
      while (func())
      {
        IObservable<TSource> iobservable;
        yield return iobservable;
      }
    }

    public static IObservable<TSource> While<TSource>(
      Func<bool> condition,
      IObservable<TSource> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return condition != null ? Observable.WhileCore<TSource>(condition, source).Concat<TSource>() : throw new ArgumentNullException(nameof (condition));
    }

    public static IObservable<TResult> If<TResult>(
      Func<bool> condition,
      IObservable<TResult> thenSource,
      IObservable<TResult> elseSource)
    {
      if (condition == null)
        throw new ArgumentNullException(nameof (condition));
      if (thenSource == null)
        throw new ArgumentNullException(nameof (thenSource));
      if (elseSource == null)
        throw new ArgumentNullException(nameof (elseSource));
      return Observable.Defer<TResult>((Func<IObservable<TResult>>) (() => !condition() ? elseSource : thenSource));
    }

    public static IObservable<TSource> DoWhile<TSource>(
      Func<bool> condition,
      IObservable<TSource> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return condition != null ? source.Concat<TSource>(Observable.While<TSource>(condition, source)) : throw new ArgumentNullException(nameof (condition));
    }

    public static IObservable<TResult> Case<TValue, TResult>(
      Func<TValue> selector,
      IDictionary<TValue, IObservable<TResult>> sources,
      IObservable<TResult> defaultSource)
    {
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (sources == null)
        throw new ArgumentNullException(nameof (sources));
      if (defaultSource == null)
        throw new ArgumentNullException(nameof (defaultSource));
      return Observable.Defer<TResult>((Func<IObservable<TResult>>) (() =>
      {
        IObservable<TResult> iobservable;
        if (!sources.TryGetValue(selector(), out iobservable))
          iobservable = defaultSource;
        return iobservable;
      }));
    }

    public static IObservable<TResult> Case<TValue, TResult>(
      Func<TValue> selector,
      IDictionary<TValue, IObservable<TResult>> sources,
      IScheduler scheduler)
    {
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (sources == null)
        throw new ArgumentNullException(nameof (sources));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return Observable.Case<TValue, TResult>(selector, sources, Observable.Empty<TResult>(scheduler));
    }

    public static IObservable<TResult> Case<TValue, TResult>(
      Func<TValue> selector,
      IDictionary<TValue, IObservable<TResult>> sources)
    {
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      if (sources == null)
        throw new ArgumentNullException(nameof (sources));
      return Observable.Case<TValue, TResult>(selector, sources, (IScheduler) Scheduler.CurrentThread);
    }

    private static IEnumerable<IObservable<TResult>> ForCore<TSource, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, IObservable<TResult>> resultSelector)
    {
      IEnumerable<TSource> sources;
      foreach (TSource source1 in sources)
      {
        Func<TSource, IObservable<TResult>> func;
        yield return func(source1);
      }
    }

    public static IObservable<TResult> For<TSource, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, IObservable<TResult>> resultSelector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return resultSelector != null ? Observable.ForCore<TSource, TResult>(source, resultSelector).Concat<TResult>() : throw new ArgumentNullException(nameof (resultSelector));
    }

    public static IObservable<TResult> Let<TValue, TResult>(
      TValue value,
      Func<TValue, IObservable<TResult>> selector)
    {
      return selector != null ? Observable.Defer<TResult>((Func<IObservable<TResult>>) (() => selector(value))) : throw new ArgumentNullException(nameof (selector));
    }

    public static IObservable<TSource> SkipLast<TSource>(
      this IObservable<TSource> source,
      int count)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (count < 0)
        throw new ArgumentOutOfRangeException(nameof (count));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        Queue<TSource> q = new Queue<TSource>();
        return source.Subscribe<TSource>((Action<TSource>) (x =>
        {
          q.Enqueue(x);
          if (q.Count <= count)
            return;
          observer.OnNext(q.Dequeue());
        }), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted));
      }));
    }

    public static IObservable<TSource> TakeLast<TSource>(
      this IObservable<TSource> source,
      int count)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (count < 0)
        throw new ArgumentOutOfRangeException(nameof (count));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        Queue<TSource> q = new Queue<TSource>();
        return source.Subscribe<TSource>((Action<TSource>) (x =>
        {
          q.Enqueue(x);
          if (q.Count <= count)
            return;
          q.Dequeue();
        }), new Action<Exception>(observer.OnError), (Action) (() =>
        {
          while (q.Count > 0)
            observer.OnNext(q.Dequeue());
          observer.OnCompleted();
        }));
      }));
    }

    public static IObservable<TResult> Select<TSource, TResult>(
      this IObservable<TSource> source,
      Func<TSource, TResult> selector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer => source.Subscribe<TSource>((Action<TSource>) (x =>
      {
        TResult result;
        try
        {
          result = selector(x);
        }
        catch (Exception ex)
        {
          observer.OnError(ex);
          return;
        }
        observer.OnNext(result);
      }), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted))));
    }

    public static IObservable<TResult> Select<TSource, TResult>(
      this IObservable<TSource> source,
      Func<TSource, int, TResult> selector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return Observable.Defer<TResult>((Func<IObservable<TResult>>) (() =>
      {
        int index = 0;
        return source.Select<TSource, TResult>((Func<TSource, TResult>) (x => selector(x, index++)));
      }));
    }

    public static IObservable<TSource> Where<TSource>(
      this IObservable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (predicate == null)
        throw new ArgumentNullException(nameof (predicate));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer => source.Subscribe<TSource>((Action<TSource>) (x =>
      {
        bool flag;
        try
        {
          flag = predicate(x);
        }
        catch (Exception ex)
        {
          observer.OnError(ex);
          return;
        }
        if (!flag)
          return;
        observer.OnNext(x);
      }), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted))));
    }

    public static IObservable<TSource> Where<TSource>(
      this IObservable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (predicate == null)
        throw new ArgumentNullException(nameof (predicate));
      return Observable.Defer<TSource>((Func<IObservable<TSource>>) (() =>
      {
        int index = 0;
        return source.Where<TSource>((Func<TSource, bool>) (x => predicate(x, index++)));
      }));
    }

    public static IObservable<IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
      this IObservable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (keySelector == null)
        throw new ArgumentNullException(nameof (keySelector));
      if (elementSelector == null)
        throw new ArgumentNullException(nameof (elementSelector));
      return source.GroupBy<TSource, TKey, TElement>(keySelector, elementSelector, (IEqualityComparer<TKey>) EqualityComparer<TKey>.Default);
    }

    public static IObservable<IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(
      this IObservable<TSource> source,
      Func<TSource, TKey> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (keySelector == null)
        throw new ArgumentNullException(nameof (keySelector));
      if (comparer == null)
        throw new ArgumentNullException(nameof (comparer));
      return source.GroupBy<TSource, TKey, TSource>(keySelector, (Func<TSource, TSource>) (x => x), comparer);
    }

    public static IObservable<IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(
      this IObservable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (keySelector == null)
        throw new ArgumentNullException(nameof (keySelector));
      return source.GroupBy<TSource, TKey, TSource>(keySelector, (Func<TSource, TSource>) (x => x), (IEqualityComparer<TKey>) EqualityComparer<TKey>.Default);
    }

    public static IObservable<IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
      this IObservable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      IEqualityComparer<TKey> comparer)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (keySelector == null)
        throw new ArgumentNullException(nameof (keySelector));
      if (elementSelector == null)
        throw new ArgumentNullException(nameof (elementSelector));
      if (comparer == null)
        throw new ArgumentNullException(nameof (comparer));
      return (IObservable<IGroupedObservable<TKey, TElement>>) new AnonymousObservable<IGroupedObservable<TKey, TElement>>((Func<IObserver<IGroupedObservable<TKey, TElement>>, IDisposable>) (observer =>
      {
        Dictionary<TKey, Subject<TElement>> map = new Dictionary<TKey, Subject<TElement>>(comparer);
        MutableDisposable mutableDisposable = new MutableDisposable();
        RefCountDisposable refCountDisposable = new RefCountDisposable((IDisposable) mutableDisposable);
        mutableDisposable.Disposable = source.Subscribe<TSource>((Action<TSource>) (x =>
        {
          TKey key1 = default (TKey);
          TKey key2;
          try
          {
            key2 = keySelector(x);
          }
          catch (Exception ex)
          {
            foreach (Subject<TElement> subject in map.Values)
              subject.OnError(ex);
            observer.OnError(ex);
            return;
          }
          bool flag = false;
          Subject<TElement> subject1 = (Subject<TElement>) null;
          try
          {
            if (!map.TryGetValue(key2, out subject1))
            {
              subject1 = new Subject<TElement>();
              map.Add(key2, subject1);
              flag = true;
            }
          }
          catch (Exception ex)
          {
            foreach (Subject<TElement> subject2 in map.Values)
              subject2.OnError(ex);
            observer.OnError(ex);
            return;
          }
          if (flag)
            observer.OnNext((IGroupedObservable<TKey, TElement>) new GroupedObservable<TKey, TElement>(key2, (IObservable<TElement>) subject1, refCountDisposable));
          TElement element1 = default (TElement);
          TElement element2;
          try
          {
            element2 = elementSelector(x);
          }
          catch (Exception ex)
          {
            foreach (Subject<TElement> subject2 in map.Values)
              subject2.OnError(ex);
            observer.OnError(ex);
            return;
          }
          subject1.OnNext(element2);
        }), (Action<Exception>) (e =>
        {
          foreach (Subject<TElement> subject in map.Values)
            subject.OnError(e);
          observer.OnError(e);
        }), (Action) (() =>
        {
          foreach (Subject<TElement> subject in map.Values)
            subject.OnCompleted();
          observer.OnCompleted();
        }));
        return (IDisposable) refCountDisposable;
      }));
    }

    public static IObservable<TSource> Take<TSource>(
      this IObservable<TSource> source,
      int count)
    {
      return source.Take<TSource>(count, (IScheduler) Scheduler.CurrentThread);
    }

    public static IObservable<TSource> Take<TSource>(
      this IObservable<TSource> source,
      int count,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (count < 0)
        throw new ArgumentOutOfRangeException(nameof (count));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        if (count == 0)
        {
          source.Subscribe<TSource>((Action<TSource>) (_ => { }), (Action<Exception>) (_ => { }), (Action) (() => { })).Dispose();
          return Observable.Empty<TSource>(scheduler).Subscribe(observer);
        }
        int remaining = count;
        return source.Subscribe<TSource>((Action<TSource>) (x =>
        {
          if (remaining <= 0)
            return;
          --remaining;
          observer.OnNext(x);
          if (remaining != 0)
            return;
          observer.OnCompleted();
        }), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted));
      }));
    }

    public static IObservable<TSource> Skip<TSource>(
      this IObservable<TSource> source,
      int count)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (count < 0)
        throw new ArgumentOutOfRangeException(nameof (count));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer => source.Subscribe<TSource>((Action<TSource>) (x =>
      {
        if (count <= 0)
          observer.OnNext(x);
        else
          --count;
      }), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted))));
    }

    public static IObservable<TSource> TakeWhile<TSource>(
      this IObservable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (predicate == null)
        throw new ArgumentNullException(nameof (predicate));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        bool running = true;
        return source.Subscribe<TSource>((Action<TSource>) (x =>
        {
          if (!running)
            return;
          try
          {
            running = predicate(x);
          }
          catch (Exception ex)
          {
            observer.OnError(ex);
            return;
          }
          if (running)
            observer.OnNext(x);
          else
            observer.OnCompleted();
        }), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted));
      }));
    }

    public static IObservable<TSource> SkipWhile<TSource>(
      this IObservable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (predicate == null)
        throw new ArgumentNullException(nameof (predicate));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        bool running = false;
        return source.Subscribe<TSource>((Action<TSource>) (x =>
        {
          if (!running)
          {
            try
            {
              running = !predicate(x);
            }
            catch (Exception ex)
            {
              observer.OnError(ex);
              return;
            }
          }
          if (!running)
            return;
          observer.OnNext(x);
        }), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted));
      }));
    }

    public static IObservable<TOther> SelectMany<TSource, TOther>(
      this IObservable<TSource> source,
      IObservable<TOther> other)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return other != null ? source.SelectMany<TSource, TOther>((Func<TSource, IObservable<TOther>>) (_ => other)) : throw new ArgumentNullException(nameof (other));
    }

    public static IObservable<TResult> SelectMany<TSource, TResult>(
      this IObservable<TSource> source,
      Func<TSource, IObservable<TResult>> selector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return selector != null ? source.Select<TSource, IObservable<TResult>>(selector).Merge<TResult>() : throw new ArgumentNullException(nameof (selector));
    }

    public static IObservable<TResult> SelectMany<TSource, TResult>(
      this IObservable<TSource> source,
      Func<TSource, IObservable<TResult>> onNext,
      Func<Exception, IObservable<TResult>> onError,
      Func<IObservable<TResult>> onCompleted)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onError == null)
        throw new ArgumentNullException(nameof (onError));
      if (onCompleted == null)
        throw new ArgumentNullException(nameof (onCompleted));
      return source.Materialize<TSource>().SelectMany<Notification<TSource>, TResult>((Func<Notification<TSource>, IObservable<TResult>>) (notification =>
      {
        if (notification.Kind == NotificationKind.OnNext)
          return onNext(notification.Value);
        return notification.Kind == NotificationKind.OnError ? onError(notification.Exception) : onCompleted();
      }));
    }

    public static IObservable<TResult> SelectMany<TSource, TResult>(
      this IObservable<TSource> source,
      Func<TSource, IEnumerable<TResult>> selector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (selector == null)
        throw new ArgumentNullException(nameof (selector));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer => source.Subscribe<TSource>((Action<TSource>) (x =>
      {
        IEnumerable<TResult> results;
        try
        {
          results = selector(x);
        }
        catch (Exception ex)
        {
          observer.OnError(ex);
          return;
        }
        using (IEnumerator<TResult> enumerator = results.GetEnumerator())
        {
          bool flag = true;
          while (flag)
          {
            TResult result = default (TResult);
            try
            {
              flag = enumerator.MoveNext();
              if (flag)
                result = enumerator.Current;
            }
            catch (Exception ex)
            {
              observer.OnError(ex);
              break;
            }
            if (flag)
              observer.OnNext(result);
          }
        }
      }), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted))));
    }

    public static IObservable<TResult> SelectMany<TSource, TCollection, TResult>(
      this IObservable<TSource> source,
      Func<TSource, IObservable<TCollection>> collectionSelector,
      Func<TSource, TCollection, TResult> resultSelector)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (collectionSelector == null)
        throw new ArgumentNullException(nameof (collectionSelector));
      if (resultSelector == null)
        throw new ArgumentNullException(nameof (resultSelector));
      return source.SelectMany<TSource, TResult>((Func<TSource, IObservable<TResult>>) (x => collectionSelector(x).Select<TCollection, TResult>((Func<TCollection, TResult>) (y => resultSelector(x, y)))));
    }

    public static IObservable<TResult> OfType<TResult>(this IObservable<object> source) => source != null ? source.Where<object>((Func<object, bool>) (x => x is TResult)).Cast<TResult>() : throw new ArgumentNullException(nameof (source));

    public static IObservable<TResult> Cast<TResult>(this IObservable<object> source) => source != null ? source.Select<object, TResult>((Func<object, TResult>) (x => (TResult) x)) : throw new ArgumentNullException(nameof (source));

    private static TimeSpan Normalize(TimeSpan timeSpan) => timeSpan.CompareTo(TimeSpan.Zero) < 0 ? TimeSpan.Zero : timeSpan;

    public static IObservable<long> Interval(TimeSpan period) => Observable.Interval(period, (IScheduler) Scheduler.ThreadPool);

    public static IObservable<long> Interval(TimeSpan period, IScheduler scheduler)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      TimeSpan timeSpan = period;
      return Observable.Timer(timeSpan, timeSpan, scheduler);
    }

    public static IObservable<long> Timer(TimeSpan dueTime) => Observable.Timer(dueTime, (IScheduler) Scheduler.ThreadPool);

    public static IObservable<long> Timer(DateTimeOffset dueTime) => Observable.Timer(dueTime, (IScheduler) Scheduler.ThreadPool);

    public static IObservable<long> Timer(TimeSpan dueTime, TimeSpan period) => Observable.Timer(dueTime, period, (IScheduler) Scheduler.ThreadPool);

    public static IObservable<long> Timer(DateTimeOffset dueTime, TimeSpan period) => Observable.Timer(dueTime, period, (IScheduler) Scheduler.ThreadPool);

    public static IObservable<long> Timer(TimeSpan dueTime, IScheduler scheduler)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      TimeSpan d = Observable.Normalize(dueTime);
      return (IObservable<long>) new AnonymousObservable<long>((Func<IObserver<long>, IDisposable>) (observer => scheduler.Schedule((Action) (() =>
      {
        observer.OnNext(0L);
        observer.OnCompleted();
      }), d)));
    }

    public static IObservable<long> Timer(DateTimeOffset dueTime, IScheduler scheduler)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<long>) new AnonymousObservable<long>((Func<IObserver<long>, IDisposable>) (observer => scheduler.Schedule((Action) (() =>
      {
        observer.OnNext(0L);
        observer.OnCompleted();
      }), dueTime)));
    }

    public static IObservable<long> Timer(
      TimeSpan dueTime,
      TimeSpan period,
      IScheduler scheduler)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return Observable.Defer<long>((Func<IObservable<long>>) (() => Observable.Timer(scheduler.Now + dueTime, period, scheduler)));
    }

    public static IObservable<long> Timer(
      DateTimeOffset dueTime,
      TimeSpan period,
      IScheduler scheduler)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      TimeSpan p = Observable.Normalize(period);
      return (IObservable<long>) new AnonymousObservable<long>((Func<IObserver<long>, IDisposable>) (observer =>
      {
        long count = 0;
        return scheduler.Schedule((Action<Action<DateTimeOffset>>) (self =>
        {
          if (p > TimeSpan.Zero)
          {
            DateTimeOffset now = scheduler.Now;
            dueTime += p;
            if (dueTime <= now)
              dueTime = now + p;
          }
          observer.OnNext(count);
          ++count;
          self(dueTime);
        }), dueTime);
      }));
    }

    public static IObservable<TSource> Delay<TSource>(
      this IObservable<TSource> source,
      TimeSpan dueTime)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Delay<TSource>(dueTime, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<TSource> Delay<TSource>(
      this IObservable<TSource> source,
      DateTimeOffset dueTime)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Delay<TSource>(dueTime, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<TSource> Delay<TSource>(
      this IObservable<TSource> source,
      TimeSpan dueTime,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        object gate = new object();
        Queue<Timestamped<Notification<TSource>>> q = new Queue<Timestamped<Notification<TSource>>>();
        bool active = false;
        bool running = false;
        MutableDisposable cancelable = new MutableDisposable();
        Exception exception = (Exception) null;
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          source.Materialize<TSource>().Timestamp<Notification<TSource>>(scheduler).Subscribe<Timestamped<Notification<TSource>>>((Action<Timestamped<Notification<TSource>>>) (notification =>
          {
            bool flag1 = false;
            lock (gate)
            {
              if (notification.Value.Kind == NotificationKind.OnError)
              {
                q.Clear();
                q.Enqueue(notification);
                exception = notification.Value.Exception;
                flag1 = !running;
              }
              else
              {
                q.Enqueue(new Timestamped<Notification<TSource>>(notification.Value, notification.Timestamp.Add(dueTime)));
                flag1 = !active;
                active = true;
              }
            }
            if (!flag1)
              return;
            if (exception != null)
            {
              observer.OnError(exception);
            }
            else
            {
              MutableDisposable mutableDisposable = new MutableDisposable();
              cancelable.Disposable = (IDisposable) mutableDisposable;
              mutableDisposable.Disposable = scheduler.Schedule((Action<Action<TimeSpan>>) (self =>
              {
                lock (gate)
                {
                  if (exception != null)
                    return;
                  running = true;
                }
                Notification<TSource> notification1;
                do
                {
                  notification1 = (Notification<TSource>) null;
                  lock (gate)
                  {
                    if (q.Count > 0)
                    {
                      Timestamped<Notification<TSource>> timestamped = q.Peek();
                      if (timestamped.Timestamp.CompareTo(scheduler.Now) <= 0)
                      {
                        timestamped = q.Dequeue();
                        notification1 = timestamped.Value;
                      }
                    }
                  }
                  if (notification1 != (Notification<TSource>) null)
                    notification1.Accept(observer);
                }
                while (notification1 != (Notification<TSource>) null);
                bool flag2 = false;
                TimeSpan timeSpan = TimeSpan.Zero;
                Exception exception1 = (Exception) null;
                lock (gate)
                {
                  if (q.Count > 0)
                  {
                    flag2 = true;
                    timeSpan = TimeSpan.FromTicks(Math.Max(0L, q.Peek().Timestamp.Subtract(scheduler.Now).Ticks));
                  }
                  else
                    active = false;
                  exception1 = exception;
                  running = false;
                }
                if (exception1 != null)
                {
                  observer.OnError(exception1);
                }
                else
                {
                  if (!flag2)
                    return;
                  self(timeSpan);
                }
              }), dueTime);
            }
          })),
          (IDisposable) cancelable
        });
      }));
    }

    public static IObservable<TSource> Delay<TSource>(
      this IObservable<TSource> source,
      DateTimeOffset dueTime,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return Observable.Defer<TSource>((Func<IObservable<TSource>>) (() => source.Delay<TSource>(dueTime.Subtract(scheduler.Now), scheduler)));
    }

    public static IObservable<TSource> Throttle<TSource>(
      this IObservable<TSource> source,
      TimeSpan dueTime)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Throttle<TSource>(dueTime, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<TSource> Throttle<TSource>(
      this IObservable<TSource> source,
      TimeSpan dueTime,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        object gate = new object();
        TSource value = default (TSource);
        bool hasValue = false;
        MutableDisposable cancelable = new MutableDisposable();
        ulong id = 0;
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          source.Subscribe<TSource>((Action<TSource>) (x =>
          {
            ulong currentid;
            lock (gate)
            {
              hasValue = true;
              value = x;
              ++id;
              currentid = id;
            }
            MutableDisposable mutableDisposable = new MutableDisposable();
            cancelable.Disposable = (IDisposable) mutableDisposable;
            mutableDisposable.Disposable = scheduler.Schedule((Action) (() =>
            {
              lock (gate)
              {
                if (hasValue && (long) id == (long) currentid)
                  observer.OnNext(value);
                hasValue = false;
              }
            }), dueTime);
          }), (Action<Exception>) (exception =>
          {
            cancelable.Dispose();
            lock (gate)
            {
              observer.OnError(exception);
              hasValue = false;
              ++id;
            }
          }), (Action) (() =>
          {
            cancelable.Dispose();
            lock (gate)
            {
              if (hasValue)
                observer.OnNext(value);
              observer.OnCompleted();
              hasValue = false;
              ++id;
            }
          })),
          (IDisposable) cancelable
        });
      }));
    }

    public static IObservable<IList<TSource>> BufferWithTime<TSource>(
      this IObservable<TSource> source,
      TimeSpan timeSpan,
      TimeSpan timeShift,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return Observable.Timer(timeSpan, timeShift, scheduler).Combine<long, TSource, IList<TSource>>(source, (Func<IObserver<IList<TSource>>, IDisposable, IDisposable, IObserver<Either<Notification<long>, Notification<TSource>>>>) ((observer, leftSubscription, rightSubscription) =>
      {
        List<Timestamped<TSource>> list = new List<Timestamped<TSource>>();
        DateTimeOffset currentWindowStart = scheduler.Now;
        Func<IList<TSource>> getCurrentWindow = (Func<IList<TSource>>) (() => (IList<TSource>) ((IEnumerable<TSource>) Enumerable.Select<Timestamped<TSource>, TSource>(Enumerable.Where<Timestamped<TSource>>((IEnumerable<M0>) list, (Func<M0, bool>) (p => p.Timestamp.CompareTo(currentWindowStart) >= 0)), (Func<M0, M1>) (p => p.Value))).ToList<TSource>());
        return (IObserver<Either<Notification<long>, Notification<TSource>>>) new BinaryObserver<long, TSource>((Action<Notification<long>>) (left =>
        {
          IList<TSource> sourceList = getCurrentWindow();
          DateTimeOffset dateTimeOffset = scheduler.Now;
          dateTimeOffset = dateTimeOffset.Add(timeShift);
          DateTimeOffset other = dateTimeOffset.Subtract(timeSpan);
          if (list.Count > 0)
          {
            int num = 0;
            while (num < list.Count && list[num].Timestamp.CompareTo(other) <= 0)
              ++num;
            list.RemoveRange(0, num);
          }
          observer.OnNext(sourceList);
          currentWindowStart = other;
        }), (Action<Notification<TSource>>) (right =>
        {
          if (right.Kind == NotificationKind.OnNext)
          {
            list.Add(new Timestamped<TSource>(right.Value, scheduler.Now));
          }
          else
          {
            if (right.Kind == NotificationKind.OnError)
            {
              observer.OnError(right.Exception);
            }
            else
            {
              observer.OnNext(getCurrentWindow());
              observer.OnCompleted();
            }
            leftSubscription.Dispose();
          }
        }));
      }));
    }

    public static IObservable<IList<TSource>> BufferWithTime<TSource>(
      this IObservable<TSource> source,
      TimeSpan timeSpan,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      IObservable<TSource> source1 = source;
      TimeSpan timeSpan1 = timeSpan;
      IScheduler scheduler1 = scheduler;
      return source1.BufferWithTime<TSource>(timeSpan1, timeSpan1, scheduler1);
    }

    public static IObservable<IList<TSource>> BufferWithTime<TSource>(
      this IObservable<TSource> source,
      TimeSpan timeSpan,
      TimeSpan timeShift)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.BufferWithTime<TSource>(timeSpan, timeShift, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<IList<TSource>> BufferWithTime<TSource>(
      this IObservable<TSource> source,
      TimeSpan timeSpan)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.BufferWithTime<TSource>(timeSpan, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<IList<TSource>> BufferWithTimeOrCount<TSource>(
      this IObservable<TSource> source,
      TimeSpan timeSpan,
      int count,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (count <= 0)
        throw new ArgumentOutOfRangeException(nameof (count));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<IList<TSource>>) new AnonymousObservable<IList<TSource>>((Func<IObserver<IList<TSource>>, IDisposable>) (observer =>
      {
        ulong bufferId = 0;
        object gate = new object();
        List<TSource> data = new List<TSource>();
        Action flushBuffer = (Action) (() =>
        {
          observer.OnNext((IList<TSource>) data);
          data = new List<TSource>();
          ++bufferId;
        });
        MutableDisposable timer = new MutableDisposable();
        Action<ulong> startTimer = (Action<ulong>) null;
        startTimer = (Action<ulong>) (myId => timer.Disposable = scheduler.Schedule((Action) (() =>
        {
          bool flag = false;
          ulong num = 0;
          lock (gate)
          {
            if ((long) myId == (long) bufferId)
            {
              flushBuffer();
              num = bufferId;
              flag = true;
            }
          }
          if (!flag)
            return;
          startTimer(num);
        }), timeSpan));
        startTimer(bufferId);
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          source.Subscribe<TSource>((Action<TSource>) (x =>
          {
            bool flag = false;
            ulong num = 0;
            lock (gate)
            {
              data.Add(x);
              if (data.Count == count)
              {
                flushBuffer();
                num = bufferId;
                flag = true;
              }
            }
            if (!flag)
              return;
            startTimer(num);
          }), (Action<Exception>) (exception =>
          {
            lock (gate)
              observer.OnError(exception);
          }), (Action) (() =>
          {
            lock (gate)
            {
              observer.OnNext((IList<TSource>) data);
              ++bufferId;
              observer.OnCompleted();
            }
          })),
          (IDisposable) timer
        });
      }));
    }

    public static IObservable<IList<TSource>> BufferWithTimeOrCount<TSource>(
      this IObservable<TSource> source,
      TimeSpan timeSpan,
      int count)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (count <= 0)
        throw new ArgumentOutOfRangeException(nameof (count));
      return source.BufferWithTimeOrCount<TSource>(timeSpan, count, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<Microsoft.Phone.Reactive.TimeInterval<TSource>> TimeInterval<TSource>(
      this IObservable<TSource> source,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return Observable.Defer<Microsoft.Phone.Reactive.TimeInterval<TSource>>((Func<IObservable<Microsoft.Phone.Reactive.TimeInterval<TSource>>>) (() =>
      {
        DateTimeOffset last = scheduler.Now;
        return source.Select<TSource, Microsoft.Phone.Reactive.TimeInterval<TSource>>((Func<TSource, Microsoft.Phone.Reactive.TimeInterval<TSource>>) (x =>
        {
          DateTimeOffset now = scheduler.Now;
          TimeSpan interval = now.Subtract(last);
          last = now;
          return new Microsoft.Phone.Reactive.TimeInterval<TSource>(x, interval);
        }));
      }));
    }

    public static IObservable<Microsoft.Phone.Reactive.TimeInterval<TSource>> TimeInterval<TSource>(
      this IObservable<TSource> source)
    {
      return source != null ? source.TimeInterval<TSource>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (source));
    }

    public static IObservable<TSource> RemoveTimeInterval<TSource>(
      this IObservable<Microsoft.Phone.Reactive.TimeInterval<TSource>> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Select<Microsoft.Phone.Reactive.TimeInterval<TSource>, TSource>((Func<Microsoft.Phone.Reactive.TimeInterval<TSource>, TSource>) (x => x.Value));
    }

    public static IObservable<Timestamped<TSource>> Timestamp<TSource>(
      this IObservable<TSource> source,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return source.Select<TSource, Timestamped<TSource>>((Func<TSource, Timestamped<TSource>>) (x => new Timestamped<TSource>(x, scheduler.Now)));
    }

    public static IObservable<Timestamped<TSource>> Timestamp<TSource>(
      this IObservable<TSource> source)
    {
      return source != null ? source.Timestamp<TSource>((IScheduler) Scheduler.ThreadPool) : throw new ArgumentNullException(nameof (source));
    }

    public static IObservable<TSource> RemoveTimestamp<TSource>(
      this IObservable<Timestamped<TSource>> source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Select<Timestamped<TSource>, TSource>((Func<Timestamped<TSource>, TSource>) (x => x.Value));
    }

    public static IObservable<TSource> Sample<TSource>(
      this IObservable<TSource> source,
      TimeSpan interval,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return source.Combine<TSource, long, TSource>(Observable.Interval(interval, scheduler), (Func<IObserver<TSource>, IDisposable, IDisposable, IObserver<Either<Notification<TSource>, Notification<long>>>>) ((observer, leftSubscription, rightSubscription) =>
      {
        Notification<TSource> value = (Notification<TSource>) null;
        bool atEnd = false;
        return (IObserver<Either<Notification<TSource>, Notification<long>>>) new BinaryObserver<TSource, long>((Action<Notification<TSource>>) (newValue =>
        {
          switch (newValue.Kind)
          {
            case NotificationKind.OnNext:
              value = newValue;
              break;
            case NotificationKind.OnError:
              newValue.Accept(observer);
              break;
            case NotificationKind.OnCompleted:
              atEnd = true;
              break;
          }
        }), (Action<Notification<long>>) (_ =>
        {
          Notification<TSource> notification = value;
          value = (Notification<TSource>) null;
          if (notification != (Notification<TSource>) null)
            notification.Accept(observer);
          if (!atEnd)
            return;
          observer.OnCompleted();
        }));
      }));
    }

    public static IObservable<TSource> Sample<TSource>(
      this IObservable<TSource> source,
      TimeSpan interval)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Sample<TSource>(interval, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<TSource> Timeout<TSource>(
      this IObservable<TSource> source,
      TimeSpan dueTime)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Timeout<TSource>(dueTime, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<TSource> Timeout<TSource>(
      this IObservable<TSource> source,
      TimeSpan dueTime,
      IObservable<TSource> other)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (other == null)
        throw new ArgumentNullException(nameof (other));
      return source.Timeout<TSource>(dueTime, other, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<TSource> Timeout<TSource>(
      this IObservable<TSource> source,
      DateTimeOffset dueTime)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Timeout<TSource>(dueTime, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<TSource> Timeout<TSource>(
      this IObservable<TSource> source,
      DateTimeOffset dueTime,
      IObservable<TSource> other)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (other == null)
        throw new ArgumentNullException(nameof (other));
      return source.Timeout<TSource>(dueTime, other, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<TSource> Timeout<TSource>(
      this IObservable<TSource> source,
      TimeSpan dueTime,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return source.Timeout<TSource>(dueTime, Observable.Throw<TSource>((Exception) new TimeoutException()), scheduler);
    }

    public static IObservable<TSource> Timeout<TSource>(
      this IObservable<TSource> source,
      TimeSpan dueTime,
      IObservable<TSource> other,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      if (other == null)
        throw new ArgumentNullException(nameof (other));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        MutableDisposable subscription = new MutableDisposable();
        MutableDisposable timer = new MutableDisposable();
        MutableDisposable mutableDisposable = new MutableDisposable();
        subscription.Disposable = (IDisposable) mutableDisposable;
        object gate = new object();
        ulong id = 0;
        ulong initial = id;
        bool switched = false;
        timer.Disposable = scheduler.Schedule((Action) (() =>
        {
          bool flag = false;
          lock (gate)
          {
            switched = (long) id == (long) initial;
            flag = switched;
          }
          if (!flag)
            return;
          subscription.Disposable = other.Subscribe(observer);
        }), dueTime);
        mutableDisposable.Disposable = source.Subscribe<TSource>((Action<TSource>) (x =>
        {
          bool flag1 = false;
          ulong value = 0;
          lock (gate)
          {
            flag1 = !switched;
            if (flag1)
            {
              ++id;
              value = id;
            }
          }
          if (!flag1)
            return;
          observer.OnNext(x);
          timer.Disposable = scheduler.Schedule((Action) (() =>
          {
            bool flag2 = false;
            lock (gate)
            {
              switched = (long) id == (long) value;
              flag2 = switched;
            }
            if (!flag2)
              return;
            subscription.Disposable = other.Subscribe(observer);
          }), dueTime);
        }), (Action<Exception>) (exception =>
        {
          bool flag = false;
          lock (gate)
          {
            flag = !switched;
            if (flag)
              ++id;
          }
          if (!flag)
            return;
          observer.OnError(exception);
        }), (Action) (() =>
        {
          bool flag = false;
          lock (gate)
          {
            flag = !switched;
            if (flag)
              ++id;
          }
          if (!flag)
            return;
          observer.OnCompleted();
        }));
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          (IDisposable) subscription,
          (IDisposable) timer
        });
      }));
    }

    public static IObservable<TSource> Timeout<TSource>(
      this IObservable<TSource> source,
      DateTimeOffset dueTime,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return source.Timeout<TSource>(dueTime, Observable.Throw<TSource>((Exception) new TimeoutException()), scheduler);
    }

    public static IObservable<TSource> Timeout<TSource>(
      this IObservable<TSource> source,
      DateTimeOffset dueTime,
      IObservable<TSource> other,
      IScheduler scheduler)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      if (other == null)
        throw new ArgumentNullException(nameof (other));
      return (IObservable<TSource>) new AnonymousObservable<TSource>((Func<IObserver<TSource>, IDisposable>) (observer =>
      {
        MutableDisposable subscription = new MutableDisposable();
        MutableDisposable mutableDisposable = new MutableDisposable();
        subscription.Disposable = (IDisposable) mutableDisposable;
        object gate = new object();
        bool switched = false;
        IDisposable disposable = scheduler.Schedule((Action) (() =>
        {
          bool flag = false;
          lock (gate)
          {
            flag = !switched;
            switched = true;
          }
          if (!flag)
            return;
          subscription.Disposable = other.Subscribe(observer);
        }), dueTime);
        mutableDisposable.Disposable = source.Subscribe<TSource>((Action<TSource>) (x =>
        {
          lock (gate)
          {
            if (switched)
              return;
            observer.OnNext(x);
          }
        }), (Action<Exception>) (exception =>
        {
          bool flag = false;
          lock (gate)
          {
            flag = !switched;
            switched = true;
          }
          if (!flag)
            return;
          observer.OnError(exception);
        }), (Action) (() =>
        {
          bool flag = false;
          lock (gate)
          {
            flag = !switched;
            switched = true;
          }
          if (!flag)
            return;
          observer.OnCompleted();
        }));
        return (IDisposable) new CompositeDisposable(new IDisposable[2]
        {
          (IDisposable) subscription,
          disposable
        });
      }));
    }

    public static IObservable<TResult> GenerateWithTime<TState, TResult>(
      TState initialState,
      Func<TState, bool> condition,
      Func<TState, TResult> resultSelector,
      Func<TState, TimeSpan> timeSelector,
      Func<TState, TState> iterate,
      IScheduler scheduler)
    {
      if (condition == null)
        throw new ArgumentNullException(nameof (condition));
      if (resultSelector == null)
        throw new ArgumentNullException(nameof (resultSelector));
      if (timeSelector == null)
        throw new ArgumentNullException(nameof (timeSelector));
      if (iterate == null)
        throw new ArgumentNullException(nameof (iterate));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        bool first = true;
        bool hasResult = false;
        TResult result = default (TResult);
        TimeSpan time = new TimeSpan();
        return scheduler.Schedule((Action<Action<TimeSpan>>) (self =>
        {
          if (hasResult)
            observer.OnNext(result);
          try
          {
            if (first)
              first = false;
            else
              initialState = iterate(initialState);
            hasResult = condition(initialState);
            if (hasResult)
            {
              result = resultSelector(initialState);
              time = timeSelector(initialState);
            }
          }
          catch (Exception ex)
          {
            observer.OnError(ex);
            return;
          }
          if (hasResult)
            self(time);
          else
            observer.OnCompleted();
        }), TimeSpan.Zero);
      }));
    }

    public static IObservable<TResult> GenerateWithTime<TState, TResult>(
      TState initialState,
      Func<TState, bool> condition,
      Func<TState, TResult> resultSelector,
      Func<TState, TimeSpan> timeSelector,
      Func<TState, TState> iterate)
    {
      if (condition == null)
        throw new ArgumentNullException(nameof (condition));
      if (resultSelector == null)
        throw new ArgumentNullException(nameof (resultSelector));
      if (timeSelector == null)
        throw new ArgumentNullException(nameof (timeSelector));
      if (iterate == null)
        throw new ArgumentNullException(nameof (iterate));
      return Observable.GenerateWithTime<TState, TResult>(initialState, condition, resultSelector, timeSelector, iterate, (IScheduler) Scheduler.ThreadPool);
    }

    public static IObservable<TResult> GenerateWithTime<TState, TResult>(
      TState initialState,
      Func<TState, bool> condition,
      Func<TState, TResult> resultSelector,
      Func<TState, DateTimeOffset> timeSelector,
      Func<TState, TState> iterate,
      IScheduler scheduler)
    {
      if (condition == null)
        throw new ArgumentNullException(nameof (condition));
      if (resultSelector == null)
        throw new ArgumentNullException(nameof (resultSelector));
      if (timeSelector == null)
        throw new ArgumentNullException(nameof (timeSelector));
      if (iterate == null)
        throw new ArgumentNullException(nameof (iterate));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        bool first = true;
        bool hasResult = false;
        TResult result = default (TResult);
        DateTimeOffset time = new DateTimeOffset();
        return scheduler.Schedule((Action<Action<DateTimeOffset>>) (self =>
        {
          if (hasResult)
            observer.OnNext(result);
          try
          {
            if (first)
              first = false;
            else
              initialState = iterate(initialState);
            hasResult = condition(initialState);
            if (hasResult)
            {
              result = resultSelector(initialState);
              time = timeSelector(initialState);
            }
          }
          catch (Exception ex)
          {
            observer.OnError(ex);
            return;
          }
          if (hasResult)
            self(time);
          else
            observer.OnCompleted();
        }), scheduler.Now);
      }));
    }

    public static IObservable<TResult> GenerateWithTime<TState, TResult>(
      TState initialState,
      Func<TState, bool> condition,
      Func<TState, TResult> resultSelector,
      Func<TState, DateTimeOffset> timeSelector,
      Func<TState, TState> iterate)
    {
      if (condition == null)
        throw new ArgumentNullException(nameof (condition));
      if (resultSelector == null)
        throw new ArgumentNullException(nameof (resultSelector));
      if (timeSelector == null)
        throw new ArgumentNullException(nameof (timeSelector));
      if (iterate == null)
        throw new ArgumentNullException(nameof (iterate));
      return Observable.GenerateWithTime<TState, TResult>(initialState, condition, resultSelector, timeSelector, iterate, (IScheduler) Scheduler.ThreadPool);
    }

    private enum AmbState
    {
      Left,
      Right,
      Neither,
    }

    private class CombineLatestHelper<TLeft, TRight, TResult>
    {
      private readonly IObserver<TResult> observer;
      private readonly Func<TLeft, TRight, TResult> selector;
      private bool leftStopped;
      private Notification<TLeft>.OnNext leftValue;
      private bool rightStopped;
      private Notification<TRight>.OnNext rightValue;

      public CombineLatestHelper(Func<TLeft, TRight, TResult> selector, IObserver<TResult> observer)
      {
        Observable.CombineLatestHelper<TLeft, TRight, TResult> combineLatestHelper = this;
        this.selector = selector;
        this.observer = observer;
        this.Left = Observer.Create<Notification<TLeft>>((Action<Notification<TLeft>>) (left =>
        {
          if (left.Kind == NotificationKind.OnNext)
          {
            combineLatestHelper.leftValue = (Notification<TLeft>.OnNext) left;
            if ((Notification<TRight>) combineLatestHelper.rightValue != (Notification<TRight>) null)
            {
              combineLatestHelper.OnNext();
            }
            else
            {
              if (!combineLatestHelper.rightStopped)
                return;
              observer.OnCompleted();
            }
          }
          else if (left.Kind == NotificationKind.OnError)
          {
            observer.OnError(left.Exception);
          }
          else
          {
            combineLatestHelper.leftStopped = true;
            if (!combineLatestHelper.rightStopped)
              return;
            observer.OnCompleted();
          }
        }));
        this.Right = Observer.Create<Notification<TRight>>((Action<Notification<TRight>>) (right =>
        {
          if (right.Kind == NotificationKind.OnNext)
          {
            combineLatestHelper.rightValue = (Notification<TRight>.OnNext) right;
            if ((Notification<TLeft>) combineLatestHelper.leftValue != (Notification<TLeft>) null)
            {
              combineLatestHelper.OnNext();
            }
            else
            {
              if (!combineLatestHelper.leftStopped)
                return;
              observer.OnCompleted();
            }
          }
          else if (right.Kind == NotificationKind.OnError)
          {
            observer.OnError(right.Exception);
          }
          else
          {
            combineLatestHelper.rightStopped = true;
            if (!combineLatestHelper.leftStopped)
              return;
            observer.OnCompleted();
          }
        }));
      }

      public IObserver<Notification<TLeft>> Left { get; private set; }

      public IObserver<Notification<TRight>> Right { get; private set; }

      private void OnNext()
      {
        TResult result;
        try
        {
          result = this.selector(this.leftValue.Value, this.rightValue.Value);
        }
        catch (Exception ex)
        {
          this.observer.OnError(ex);
          return;
        }
        this.observer.OnNext(result);
      }
    }

    private class ZipHelper<TLeft, TRight, TResult>
    {
      private readonly Queue<Notification<TLeft>> leftQ;
      private readonly IObserver<TResult> observer;
      private readonly Queue<Notification<TRight>> rightQ;
      private readonly Func<TLeft, TRight, TResult> selector;

      public ZipHelper(Func<TLeft, TRight, TResult> selector, IObserver<TResult> observer)
      {
        Observable.ZipHelper<TLeft, TRight, TResult> zipHelper = this;
        this.selector = selector;
        this.observer = observer;
        this.leftQ = new Queue<Notification<TLeft>>();
        this.rightQ = new Queue<Notification<TRight>>();
        this.Left = Observer.Create<Notification<TLeft>>((Action<Notification<TLeft>>) (left =>
        {
          if (left.Kind == NotificationKind.OnError)
            observer.OnError(left.Exception);
          else if (zipHelper.rightQ.Count == 0)
            zipHelper.leftQ.Enqueue(left);
          else
            zipHelper.OnNext(left, zipHelper.rightQ.Dequeue());
        }));
        this.Right = Observer.Create<Notification<TRight>>((Action<Notification<TRight>>) (right =>
        {
          if (right.Kind == NotificationKind.OnError)
            observer.OnError(right.Exception);
          else if (zipHelper.leftQ.Count == 0)
            zipHelper.rightQ.Enqueue(right);
          else
            zipHelper.OnNext(zipHelper.leftQ.Dequeue(), right);
        }));
      }

      public IObserver<Notification<TLeft>> Left { get; private set; }

      public IObserver<Notification<TRight>> Right { get; private set; }

      private void OnNext(Notification<TLeft> left, Notification<TRight> right)
      {
        if (left.Kind != NotificationKind.OnCompleted)
        {
          if (right.Kind != NotificationKind.OnCompleted)
          {
            TResult result;
            try
            {
              result = this.selector(left.Value, right.Value);
            }
            catch (Exception ex)
            {
              this.observer.OnError(ex);
              return;
            }
            this.observer.OnNext(result);
            return;
          }
        }
        this.observer.OnCompleted();
      }
    }
  }
}
