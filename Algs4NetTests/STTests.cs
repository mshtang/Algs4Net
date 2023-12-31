﻿/******************************************************************************
 *  File name :  STTests.cs
 *  Purpose   :  Contains basic unit tests for the ST class
 *
 ******************************************************************************/
using Algs4Net;
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algs4NetUnitTests
{
    [TestClass]
    public class STTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void STTest1()
        {
            // testing Get/Put semantics
            ST<string, int> st = new ST<string, int>();
            Assert.IsTrue(st.IsEmpty);

            string[] keys = { "to", "be", "or", "not", "to", "be", "is", "quest" };
            for (int i = 0; i < keys.Length; i++)
            {
                st.Put(keys[i], i);
            }
            Assert.IsTrue(!(st.IsEmpty) && (st.Count == 6));

            string key = "not";
            Assert.IsTrue(st.Contains(key));
            st.Delete(key);
            Assert.IsFalse(st.Contains(key));
            Assert.IsNull(st.Get(key));

            object value = st.Get("is");
            Assert.AreEqual(6, value);

            value = st.Get("world");
            Assert.IsNull(value);

            int dummy = (int)st.Get("hello"); // generate null exception
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void STTest2()
        {
            // testing indexer semantics
            ST<int, string> st = new ST<int, string>();
            st[99] = null;
            Assert.AreEqual(st.Count, 0);
            st[3] = "abc";
            st[2] = "cde";
            Assert.AreEqual(st[2], "cde");
            st[99] = null;
            st[2] = null;
            Assert.AreEqual(st.Count, 1);
            st.Delete(3);
            Assert.AreEqual(st.Count, 0);
            try
            {
                string dummyS = st[99];
                Assert.IsNull(dummyS);
            }
            catch (Exception)
            {
                Assert.Fail("it is possible to look up an empty table");
            }

            st[4] = "def";
            Assert.IsNull(st[99]);
            Assert.IsNull(st[3]);
            Assert.IsNull(st[2]);
            st[3] = "101";
            int oldCount = st.Count;
            // delete non-existing key does nothing
            st.Delete(123456);
            Assert.AreEqual(oldCount, st.Count);

            ST<int, int> st2 = new ST<int, int>();
            st2[3] = 22;
            st2[2] = 33;
            st2[99] = 44;
            st2[2] = 55;
            st2.Delete(3);
            Assert.IsFalse(st2.Contains(3));
            st2[3] = 101;
            Assert.AreEqual(101, st2[3]);
            st2.Delete(99);
            int dummy = st2[99]; // generate null exception
        }
    }
}

/******************************************************************************
 *  Copyright 2016, Thai Nguyen.
 *  Copyright 2002-2015, Robert Sedgewick and Kevin Wayne.
 *
 *  This file is part of a unit test module for Algs4Net.dll, a .NET library 
 *  that ports algs4.jar, which accompanies the textbook
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
