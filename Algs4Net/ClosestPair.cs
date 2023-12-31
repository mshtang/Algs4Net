﻿/******************************************************************************
 *  File name :    ClosestPair.cs
 *  Demo test :    Use the algscmd util or Visual Studio IDE
 *            :    Enter algscmd alone for how to use the util
 *
 *  Given N points in the plane, find the closest pair in N log N time.
 *
 *  Note: could speed it up by comparing square of Euclidean distances
 *  instead of Euclidean distances.
 *
 *  C:\> algscmd ClosestPair
 *  6
 *  1 1
 *  4 1
 *  9 1
 *  2 6
 *  5 7
 *  10 7
 *  3 from (1, 1) to (4, 1)
 *  
 ******************************************************************************/

using System;

namespace Algs4Net
{
  /// <summary><para>
  /// The <c>ClosestPair</c> data type computes a closest pair of points
  /// in a set of <c>N</c> points in the plane and provides accessor methods 
  /// for getting the closest pair of points and the distance between them.
  /// The distance between two points is their Euclidean distance.
  /// </para><para>
  /// This implementation uses a divide-and-conquer algorithm. 
  /// It runs in O(<c>N</c> log <c>N</c>) time in the worst case and uses
  /// O(<c>N</c>) extra space. See also <seealso cref="FarthestPair"/>.
  /// </para></summary>
  /// <remarks><para>
  /// For additional documentation, see <a href="http://algs4.cs.princeton.edu/99hull">Section 9.9</a> of
  /// <i>Algorithms, 4th Edition</i> by Robert Sedgewick and Kevin Wayne.</para>
  /// <para>This class is a C# port from the original Java class 
  /// <a href="http://algs4.cs.princeton.edu/code/edu/princeton/cs/algs4/ClosestPair.java.html">ClosestPair</a>
  /// implementation by the respective authors.</para></remarks>
  ///
  //public class ClosestPair
  //{

  //  // closest pair of points and their Euclidean distance
  //  private Point2D best1, best2;
  //  private double bestDistance = double.PositiveInfinity;

  //  /// <summary>
  //  /// Computes the closest pair of points in the specified array of points.</summary>
  //  /// <param name="points">the array of points</param>
  //  /// <exception cref="NullReferenceException">if <c>points</c> is <c>null</c> or if any
  //  /// entry in <c>points[]</c> is <c>null</c></exception>
  //  ///
  //  public ClosestPair(Point2D[] points)
  //  {
  //    int N = points.Length;
  //    if (N <= 1) return;

  //    // sort by x-coordinate (breaking ties by y-coordinate)
  //    Point2D[] pointsByX = new Point2D[N];
  //    for (int i = 0; i < N; i++)
  //      pointsByX[i] = points[i];
  //    Array.Sort(pointsByX, Point2D.X_ORDER);

  //    // check for coincident points
  //    for (int i = 0; i < N - 1; i++)
  //    {
  //      if (pointsByX[i].Equals(pointsByX[i + 1]))
  //      {
  //        bestDistance = 0.0;
  //        best1 = pointsByX[i];
  //        best2 = pointsByX[i + 1];
  //        return;
  //      }
  //    }

  //    // sort by y-coordinate (but not yet sorted)
  //    Point2D[] pointsByY = new Point2D[N];
  //    for (int i = 0; i < N; i++)
  //      pointsByY[i] = pointsByX[i];

  //    // auxiliary array
  //    Point2D[] aux = new Point2D[N];

  //    closest(pointsByX, pointsByY, aux, 0, N - 1);
  //  }

  //  // find closest pair of points in pointsByX[lo..hi]
  //  // precondition:  pointsByX[lo..hi] and pointsByY[lo..hi] are the same sequence of points
  //  // precondition:  pointsByX[lo..hi] sorted by x-coordinate
  //  // postcondition: pointsByY[lo..hi] sorted by y-coordinate
  //  private double closest(Point2D[] pointsByX, Point2D[] pointsByY, Point2D[] aux, int lo, int hi)
  //  {
  //    if (hi <= lo) return double.PositiveInfinity;

  //    int mid = lo + (hi - lo) / 2;
  //    Point2D median = pointsByX[mid];

  //    // compute closest pair with both endpoints in left subarray or both in right subarray
  //    double delta1 = closest(pointsByX, pointsByY, aux, lo, mid);
  //    double delta2 = closest(pointsByX, pointsByY, aux, mid + 1, hi);
  //    double delta = Math.Min(delta1, delta2);

  //    // merge back so that pointsByY[lo..hi] are sorted by y-coordinate
  //    merge(pointsByY, aux, lo, mid, hi);

  //    // aux[0..M-1] = sequence of points closer than delta, sorted by y-coordinate
  //    int M = 0;
  //    for (int i = lo; i <= hi; i++)
  //    {
  //      if (Math.Abs(pointsByY[i].X - median.X) < delta)
  //        aux[M++] = pointsByY[i];
  //    }

  //    // compare each point to its neighbors with y-coordinate closer than delta
  //    for (int i = 0; i < M; i++)
  //    {
  //      // a geometric packing argument shows that this loop iterates at most 7 times
  //      for (int j = i + 1; (j < M) && (aux[j].Y - aux[i].Y < delta); j++)
  //      {
  //        double distance = aux[i].DistanceTo(aux[j]);
  //        if (distance < delta)
  //        {
  //          delta = distance;
  //          if (distance < bestDistance)
  //          {
  //            bestDistance = delta;
  //            best1 = aux[i];
  //            best2 = aux[j];
  //            // Console.WriteLine("better distance = " + delta + " from " + best1 + " to " + best2);
  //          }
  //        }
  //      }
  //    }
  //    return delta;
  //  }

  //  /// <summary>
  //  /// Returns one of the points in the closest pair of points.</summary>
  //  /// <returns>one of the two points in the closest pair of points;
  //  /// <c>null</c> if no such point (because there are fewer than 2 points)</returns>
  //  ///
  //  public Point2D Either
  //  {
  //    get { return best1; }
  //  }

  //  /// <summary>
  //  /// Returns the other point in the closest pair of points.</summary>
  //  /// <returns>the other point in the closest pair of points
  //  /// <c>null</c> if no such point (because there are fewer than 2 points)</returns>
  //  ///
  //  public Point2D Other
  //  {
  //    get { return best2; }
  //  }

  //  /// <summary>
  //  /// Returns the Eucliden distance between the closest pair of points.</summary>
  //  /// <returns>the Euclidean distance between the closest pair of points
  //  /// <c>double.PositiveInfinity</c> if no such pair of points
  //  /// exist (because there are fewer than 2 points)</returns>
  //  ///
  //  public double Distance()
  //  {
  //    return bestDistance;
  //  }

  //  // is v < w ?
  //  private static bool less(Point2D v, Point2D w)
  //  {
  //    return v.CompareTo(w) < 0;
  //  }

  //  // stably merge a[lo .. mid] with a[mid+1 ..hi] using aux[lo .. hi]
  //  // precondition: a[lo .. mid] and a[mid+1 .. hi] are sorted subarrays
  //  private static void merge(Point2D[] a, Point2D[] aux, int lo, int mid, int hi)
  //  {
  //    // copy to aux[]
  //    for (int k = lo; k <= hi; k++)
  //    {
  //      aux[k] = a[k];
  //    }

  //    // merge back to a[]
  //    int i = lo, j = mid + 1;
  //    for (int k = lo; k <= hi; k++)
  //    {
  //      if (i > mid) a[k] = aux[j++];
  //      else if (j > hi) a[k] = aux[i++];
  //      else if (less(aux[j], aux[i])) a[k] = aux[j++];
  //      else a[k] = aux[i++];
  //    }
  //  }

  //  /// <summary>
  //  /// Demo test the <c>ClosestPair</c> data type.
  //  /// Reads in an integer <c>N</c> and <c>N</c> points (specified by
  //  /// their <c>X</c>- and <c>Y</c>-coordinates) from standard input;
  //  /// computes a closest pair of points; and prints the pair to standard
  //  /// output.</summary>
  //  /// <param name="args">Place holder for user arguments</param>
  //  /// 
  //  [HelpText("algscmd ClosestPair < rs1423.txt", "The number of points followed by x y coordinates")]
  //  public static void MainTest(string[] args)
  //  {
  //    TextInput StdIn = new TextInput();
  //    int N = StdIn.ReadInt();
  //    Point2D[] points = new Point2D[N];
  //    for (int i = 0; i < N; i++)
  //    {
  //      double x = StdIn.ReadDouble();
  //      double y = StdIn.ReadDouble();
  //      points[i] = new Point2D(x, y);
  //    }
  //    ClosestPair closest = new ClosestPair(points);
  //    Console.WriteLine("{0} from {1} to {2}", closest.Distance(), closest.Either, closest.Other);
  //  }

  //}
}

/******************************************************************************
 *  Copyright 2016, Thai Nguyen.
 *  Copyright 2002-2015, Robert Sedgewick and Kevin Wayne.
 *
 *  This file is part of Algs4Net.dll, a .NET library that ports algs4.jar,
 *  which accompanies the textbook
 *
 *      Algorithms, 4th edition by Robert Sedgewick and Kevin Wayne,
 *      Addison-Wesley Professional, 2011, ISBN 0-321-57351-X.
 *      http://algs4.cs.princeton.edu
 *
 *
 *  Algs4Net.dll is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Algs4Net.dll is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Algs4Net.dll.  If not, see http://www.gnu.org/licenses.
 ******************************************************************************/
