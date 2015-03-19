﻿/*! 
@author Terence Slot. <Tryan18@gmail.com>
		<http://github.com/tryan18/C#>
@date March 19, 2015
@version 1.0
@section LICENSE

The MIT License (MIT)

Copyright (c) 2013 Terence Slot

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
// The following code was generated by Microsoft Visual Studio 2005.
// The test owner should check each test for validity.
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Collections.Generic;
using Grid;
namespace Test
{
    /// <summary>
    ///This is a test class for Grid.Grid&lt;T&gt; and is intended
    ///to contain all Grid.Grid&lt;T&gt; Unit Tests
    ///</summary>
    [TestClass()]
    public class GridTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for addElement (T, IPoint)
        ///</summary>
        [TestMethod()]
        public void addElementTest()
        {
            // Grid<T> target = new Grid<T>();
            // 
            // T element = 0; // TODO: Initialize to an appropriate value
            // 
            // IPoint p = null; // TODO: Initialize to an appropriate value
            // 
            // target.addElement(element, p);
            // 
            // Assert.Inconclusive("A method that does not return a value cannot be verified.");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

        /// <summary>
        ///A test for elements
        ///</summary>
        [TestMethod()]
        public void elementsTest()
        {
            // Grid<T> target = new Grid<T>();
            // 
            // System.Collections.Generic.List<T> val = null; // TODO: Assign to an appropriate value for the property
            // 
            // 
            // Assert.AreEqual(val, target.elements, "Grid.Grid<T>.elements was not set correctly.");
            // Assert.Inconclusive("Verify the correctness of this test method.");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

        /// <summary>
        ///A test for getContainerAt (IPoint)
        ///</summary>
        [TestMethod()]
        public void getContainerAtTest()
        {
            // Unit Test Generation Error: A private accessor could not be created for Grid.Grid<T>.getContainerAt: Private accessors cannot be created for generic types
            Assert.Fail("Unit Test Generation Error: A private accessor could not be created for Grid.Grid" +
                    "<T>.getContainerAt: Private accessors cannot be created for generic types");
        }

        /// <summary>
        ///A test for getElementAt (IPoint)
        ///</summary>
        [TestMethod()]
        public void getElementAtTest()
        {
            // Grid<T> target = new Grid<T>();
            // 
            // IPoint p = null; // TODO: Initialize to an appropriate value
            // 
            // T expected = 0;
            // T actual;
            // 
            // actual = target.getElementAt(p);
            // 
            // Assert.AreEqual(expected, actual, "Grid.Grid<T>.getElementAt did not return the expected value.");
            // Assert.Inconclusive("Verify the correctness of this test method.");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

        /// <summary>
        ///A test for getElementPositions (T)
        ///</summary>
        [TestMethod()]
        public void getElementPositionsTest()
        {
            // Grid<T> target = new Grid<T>();
            // 
            // T element = 0; // TODO: Initialize to an appropriate value
            // 
            // System.Collections.Generic.List<Grid.IPoint> expected = null;
            // System.Collections.Generic.List<Grid.IPoint> actual;
            // 
            // actual = target.getElementPositions(element);
            // 
            // Assert.AreEqual(expected, actual, "Grid.Grid<T>.getElementPositions did not return the expected value.");
            // Assert.Inconclusive("Verify the correctness of this test method.");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

        /// <summary>
        ///A test for Grid ()
        ///</summary>
        [TestMethod()]
        public void ConstructorTest()
        {
            // Grid<T> target = new Grid<T>();
            // 
            // // TODO: Implement code to verify target
            // Assert.Inconclusive("TODO: Implement code to verify target");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

        /// <summary>
        ///A test for indexToLocation (int)
        ///</summary>
        [TestMethod()]
        public void indexToLocationTest()
        {
            // Unit Test Generation Error: A private accessor could not be created for Grid.Grid<T>.indexToLocation: Private accessors cannot be created for generic types
            Assert.Fail("Unit Test Generation Error: A private accessor could not be created for Grid.Grid" +
                    "<T>.indexToLocation: Private accessors cannot be created for generic types");
        }

        /// <summary>
        ///A test for isAvailable (IPoint)
        ///</summary>
        [TestMethod()]
        public void isAvailableTest()
        {
            // Grid<T> target = new Grid<T>();
            // 
            // IPoint p = null; // TODO: Initialize to an appropriate value
            // 
            // bool expected = false;
            // bool actual;
            // 
            // actual = target.isAvailable(p);
            // 
            // Assert.AreEqual(expected, actual, "Grid.Grid<T>.isAvailable did not return the expected value.");
            // Assert.Inconclusive("Verify the correctness of this test method.");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

        /// <summary>
        ///A test for isInBounds (IPoint)
        ///</summary>
        [TestMethod()]
        public void isInBoundsTest()
        {
            // Grid<T> target = new Grid<T>();
            // 
            // IPoint p = null; // TODO: Initialize to an appropriate value
            // 
            // bool expected = false;
            // bool actual;
            // 
            // actual = target.isInBounds(p);
            // 
            // Assert.AreEqual(expected, actual, "Grid.Grid<T>.isInBounds did not return the expected value.");
            // Assert.Inconclusive("Verify the correctness of this test method.");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

        /// <summary>
        ///A test for locationToIndex (IPoint)
        ///</summary>
        [TestMethod()]
        public void locationToIndexTest()
        {
            // Unit Test Generation Error: A private accessor could not be created for Grid.Grid<T>.locationToIndex: Private accessors cannot be created for generic types
            Assert.Fail("Unit Test Generation Error: A private accessor could not be created for Grid.Grid" +
                    "<T>.locationToIndex: Private accessors cannot be created for generic types");
        }

        /// <summary>
        ///A test for removeElement (T)
        ///</summary>
        [TestMethod()]
        public void removeElementTest()
        {
            // Grid<T> target = new Grid<T>();
            // 
            // T element = 0; // TODO: Initialize to an appropriate value
            // 
            // target.removeElement(element);
            // 
            // Assert.Inconclusive("A method that does not return a value cannot be verified.");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

        /// <summary>
        ///A test for removeElementAt (IPoint)
        ///</summary>
        [TestMethod()]
        public void removeElementAtTest()
        {
            // Grid<T> target = new Grid<T>();
            // 
            // IPoint p = null; // TODO: Initialize to an appropriate value
            // 
            // target.removeElementAt(p);
            // 
            // Assert.Inconclusive("A method that does not return a value cannot be verified.");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

        /// <summary>
        ///A test for resize (uint, uint)
        ///</summary>
        [TestMethod()]
        public void resizeTest()
        {
            // Unit Test Generation Error: A private accessor could not be created for Grid.Grid<T>.resize: Private accessors cannot be created for generic types
            Assert.Fail("Unit Test Generation Error: A private accessor could not be created for Grid.Grid" +
                    "<T>.resize: Private accessors cannot be created for generic types");
        }

        /// <summary>
        ///A test for xSections
        ///</summary>
        [TestMethod()]
        public void xSectionsTest()
        {
            // Grid<T> target = new Grid<T>();
            // 
            // uint val = 0; // TODO: Assign to an appropriate value for the property
            // 
            // target.xSections = val;
            // 
            // 
            // Assert.AreEqual(val, target.xSections, "Grid.Grid<T>.xSections was not set correctly.");
            // Assert.Inconclusive("Verify the correctness of this test method.");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

        /// <summary>
        ///A test for ySections
        ///</summary>
        [TestMethod()]
        public void ySectionsTest()
        {
            Grid<string> target = new Grid<string>();
             
            uint val = 0; // TODO: Assign to an appropriate value for the property 
            
            target.ySections = val;
            Assert.AreEqual(val, target.ySections, "Grid.Grid<T>.ySections was not set correctly.");
            Assert.Inconclusive("Verify the correctness of this test method.");
            Assert.Inconclusive("Generics testing must be manually provided.");
        }

    }


}