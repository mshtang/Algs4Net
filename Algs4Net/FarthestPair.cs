﻿/******************************************************************************
 *  File name :    FarthestPair.cs
 *  Demo test :    Use the algscmd util or Visual Studio IDE
 *            :    Enter algscmd alone for how to use the util
 *
 *  Given a set of N points in the plane, find the farthest pair
 *  (equivalently, compute the diameter of the set of points).
 *
 *  Computes the convex hull of the set of points and using the
 *  rotating calipers method to find all antipodal point pairs
 *  and the farthest pair.
 *  
 *  C:\> algscmd FarthestPair
 *  5
 *  1 1
 *  2 2
 *  3 3
 *  4 4
 *  1 6
 *  5 from (1, 1) to (1, 6)
 *
 *  C:\> algscmd FarthestPair < rs1423.tx
 *
 ******************************************************************************/

using System;

namespace Algs4Net
{
  /// <summary><para>
  /// The <c>FarthestPair</c> data type computes the farthest pair of points
  /// in a set of <c>N</c> points in the plane and provides accessor methods
  /// for getting the farthest pair of points and the distance between them.
  /// The distance between two points is their Euclidean distance.
  /// </para><para>
  /// This implementation computes the convex hull of the set of points and
  /// uses the rotating calipers method to find all antipodal point pairs
  /// and the farthest pair.
  /// It runs in O(<c>N</c> log <c>N</c>) time in the worst case and uses
  /// O(<c>N</c>) extra space.
  /// See also <seealso cref="ClosestPair"/> and <seealso cref="GrahamScan"/>.
  /// </para></summary>
  /// <remarks><para>
  /// For additional documentation, see <a href="http://algs4.cs.princeton.edu/99hull">Section 9.9</a> of
  /// <i>Algorithms, 4th Edition</i> by Robert Sedgewick and Kevin Wayne.</para>
  /// <para>This class is a C# port from the original Java class 
  /// <a href="http://algs4.cs.princeton.edu/code/edu/princeton/cs/algs4/FarthestPair.java.html">FarthestPair</a>
  /// implementation by the respective authors.</para></remarks>
  ///
  //public class FarthestPair
  //{

  //  // farthest pair of points and distance
  //  private Point2D best1, best2;
  //  private double bestDistanceSquared = double.NegativeInfinity;

  //  /// <summary>
  //  /// Computes the farthest pair of points in the specified array of points.</summary>
  //  /// <param name="points">the array of points</param>
  //  /// <exception cref="NullReferenceException">if <c>points</c> is <c>null</c> or if any
  //  /// entry in <c>points[]</c> is <c>null</c></exception>
  //  ///
  //  public FarthestPair(Point2D[] points)
  //  {
  //    GrahamScan graham = new GrahamScan(points);

  //    // single point
  //    if (points.Length <= 1) return;

  //    // number of points on the hull
  //    int M = 0;
  //    foreach (Point2D p in graham.Hull())
  //      M++;

  //    // the hull, in counterclockwise order
  //    Point2D[] hull = new Point2D[M + 1];
  //    int m = 1;
  //    foreach (Point2D p in graham.Hull())
  //    {
  //      hull[m++] = p;
  //    }

  //    // all points are equal
  //    if (M == 1) return;

  //    // points are collinear
  //    if (M == 2)
  //    {
  //      best1 = hull[1];
  //      best2 = hull[2];
  //      bestDistanceSquared = best1.DistanceSquaredTo(best2);
  //      return;
  //    }

  //    // k = farthest vertex from edge from hull[1] to hull[M]
  //    int k = 2;
  //    while (Point2D.Area2(hull[M], hull[k + 1], hull[1]) > Point2D.Area2(hull[M], hull[k], hull[1]))
  //    {
  //      k++;
  //      if (k == hull.Length-1) break;
  //    }

  //    int j = k;
  //    for (int i = 1; i <= k; i++)
  //    {
  //      //Console.WriteLine(hull[i] + " and " + hull[j] + " are antipodal");
  //      if (hull[i].DistanceSquaredTo(hull[j]) > bestDistanceSquared)
  //      {
  //        best1 = hull[i];
  //        best2 = hull[j];
  //        bestDistanceSquared = hull[i].DistanceSquaredTo(hull[j]);
  //      }
  //      while ((j < M) && Point2D.Area2(hull[i], hull[j + 1], hull[i + 1]) > Point2D.Area2(hull[i], hull[j], hull[i + 1]))
  //      {
  //        j++;
  //        //Console.WriteLine(hull[i] + " and " + hull[j] + " are antipodal");
  //        double distanceSquared = hull[i].DistanceSquaredTo(hull[j]);
  //        if (distanceSquared > bestDistanceSquared)
  //        {
  //          best1 = hull[i];
  //          best2 = hull[j];
  //          bestDistanceSquared = hull[i].DistanceSquaredTo(hull[j]);
  //        }
  //      }
  //    }
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
  //  /// Returns the Eucliden distance between the closest pair of points.
  //  /// This quantity is also known as the <c>Diameter</c> of the set of points.</summary>
  //  /// <returns>the Euclidean distance between the closest pair of points
  //  /// <c>double.PositiveInfinity</c> if no such pair of points
  //  /// exist (because there are fewer than 2 points)</returns>
  //  ///
  //  public double Distance()
  //  {
  //    return Math.Sqrt(bestDistanceSquared);
  //  }

  //  /// <summary>
  //  /// Demo test the <c>FarthestPair</c> data type.
  //  /// Reads in an integer <c>N</c> and <c>N</c> points (specified by
  //  /// their <c>X</c>- and <c>Y</c>-coordinates) from standard input;
  //  /// computes a farthest pair of points; and prints the pair to standard
  //  /// output.</summary>
  //  /// <param name="args">Place holder for user arguments</param>
  //  /// 
  //  [HelpText("algscmd FarthestPair < rs1423.txt", "The number of points followed by x y coordinates")]
  //  public static void MainTest(string[] args)
  //  {
  //    TextInput StdIn = new TextInput();
  //    int N = StdIn.ReadInt();
  //    Point2D[] points = new Point2D[N];
  //    for (int i = 0; i < N; i++)
  //    {
  //      int x = StdIn.ReadInt();
  //      int y = StdIn.ReadInt();
  //      points[i] = new Point2D(x, y);
  //    }
  //    FarthestPair farthest = new FarthestPair(points);
  //    Console.WriteLine(farthest.Distance() + " from " + farthest.Either + " to " + farthest.Other);
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
