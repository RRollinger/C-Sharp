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
using Sokoban;
using Sokoban.Utils;
using Grid;
namespace Test
{
    /// <summary>
    ///This is a test class for Sokoban.SokobanGame and is intended
    ///to contain all Sokoban.SokobanGame Unit Tests
    ///</summary>
    [TestClass()]
    public class SokobanGameTest
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
        ///A test for addSokobanObject (SokobanType, IPoint)
        ///</summary>
        [TestMethod()]
        public void addSokobanObjectTest()
        {
            SokobanGame target = new SokobanGame();

            SokobanType type = SokobanType.Player; // TODO: Initialize to an appropriate value

            IPoint position = null; // TODO: Initialize to an appropriate value

            bool expected = false;
            bool actual;

            actual = target.addSokobanObject(type, position);

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.addSokobanObject did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for addState (string)
        ///</summary>
        [DeploymentItem("Sokoban.dll")]
        [TestMethod()]
        public void addStateTest()
        {
            SokobanGame target = new SokobanGame();

            Test.Sokoban_SokobanGameAccessor accessor = new Test.Sokoban_SokobanGameAccessor(target);

            string state = null; // TODO: Initialize to an appropriate value

            accessor.addState(state);

            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for applyState (string)
        ///</summary>
        [DeploymentItem("Sokoban.dll")]
        [TestMethod()]
        public void applyStateTest()
        {
            SokobanGame target = new SokobanGame();

            Test.Sokoban_SokobanGameAccessor accessor = new Test.Sokoban_SokobanGameAccessor(target);

            string state = null; // TODO: Initialize to an appropriate value

            accessor.applyState(state);

            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for charToDirection (char)
        ///</summary>
        [DeploymentItem("Sokoban.dll")]
        [TestMethod()]
        public void charToDirectionTest()
        {
            SokobanGame target = new SokobanGame();

            Test.Sokoban_SokobanGameAccessor accessor = new Test.Sokoban_SokobanGameAccessor(target);

            char direction = '\0'; // TODO: Initialize to an appropriate value

            SokobanDirection expected = SokobanDirection.Up;
            SokobanDirection actual;

            actual = accessor.charToDirection(direction);

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.charToDirection did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for clear ()
        ///</summary>
        [TestMethod()]
        public void clearTest()
        {
            SokobanGame target = new SokobanGame();

            target.clear();

            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for containsState (string)
        ///</summary>
        [DeploymentItem("Sokoban.dll")]
        [TestMethod()]
        public void containsStateTest()
        {
            SokobanGame target = new SokobanGame();

            Test.Sokoban_SokobanGameAccessor accessor = new Test.Sokoban_SokobanGameAccessor(target);

            string state = null; // TODO: Initialize to an appropriate value

            bool expected = false;
            bool actual;

            actual = accessor.containsState(state);

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.containsState did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for directionToPoint (SokobanDirection)
        ///</summary>
        [DeploymentItem("Sokoban.dll")]
        [TestMethod()]
        public void directionToPointTest()
        {
            SokobanDirection direction = SokobanDirection.Up; // TODO: Initialize to an appropriate value

            IPoint expected = null;
            IPoint actual;

            actual = Test.Sokoban_SokobanGameAccessor.directionToPoint(direction);

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.directionToPoint did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getState (IGrid&lt;SokobanType&gt;, IPoint)
        ///</summary>
        [DeploymentItem("Sokoban.dll")]
        [TestMethod()]
        public void getStateTest()
        {
            SokobanGame target = new SokobanGame();

            Test.Sokoban_SokobanGameAccessor accessor = new Test.Sokoban_SokobanGameAccessor(target);

            Grid.IGrid<Sokoban.Utils.SokobanType> boxes = null; // TODO: Initialize to an appropriate value

            IPoint player = null; // TODO: Initialize to an appropriate value

            string expected = null;
            string actual;

            actual = accessor.getState(boxes, player);

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.getState did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for grid
        ///</summary>
        [TestMethod()]
        public void gridTest()
        {
            SokobanGame target = new SokobanGame();

            Grid.IGrid<Sokoban.Utils.SokobanType> val = null; // TODO: Assign to an appropriate value for the property

            target.grid = val;


            Assert.AreEqual(val, target.grid, "Sokoban.SokobanGame.grid was not set correctly.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for height
        ///</summary>
        [TestMethod()]
        public void heightTest()
        {
            SokobanGame target = new SokobanGame();

            uint val = 0; // TODO: Assign to an appropriate value for the property

            target.height = val;


            Assert.AreEqual(val, target.height, "Sokoban.SokobanGame.height was not set correctly.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for isSolved ()
        ///</summary>
        [TestMethod()]
        public void isSolvedTest()
        {
            SokobanGame target = new SokobanGame();

            bool expected = false;
            bool actual;

            actual = target.isSolved();

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.isSolved did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for isStuck (IPoint)
        ///</summary>
        [DeploymentItem("Sokoban.dll")]
        [TestMethod()]
        public void isStuckTest()
        {
            SokobanGame target = new SokobanGame();

            Test.Sokoban_SokobanGameAccessor accessor = new Test.Sokoban_SokobanGameAccessor(target);

            IPoint boxPosition = null; // TODO: Initialize to an appropriate value

            bool expected = false;
            bool actual;

            actual = accessor.isStuck(boxPosition);

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.isStuck did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for isWalkable (IPoint)
        ///</summary>
        [DeploymentItem("Sokoban.dll")]
        [TestMethod()]
        public void isWalkableTest()
        {
            SokobanGame target = new SokobanGame();

            Test.Sokoban_SokobanGameAccessor accessor = new Test.Sokoban_SokobanGameAccessor(target);

            IPoint position = null; // TODO: Initialize to an appropriate value

            bool expected = false;
            bool actual;

            actual = accessor.isWalkable(position);

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.isWalkable did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for loadGame (string)
        ///</summary>
        [TestMethod()]
        public void loadGameTest()
        {
            SokobanGame target = new SokobanGame();

            string loadPath = null; // TODO: Initialize to an appropriate value

            bool expected = false;
            bool actual;

            actual = target.loadGame(loadPath);

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.loadGame did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for movePlayer (SokobanDirection)
        ///</summary>
        [TestMethod()]
        public void movePlayerTest()
        {
            SokobanGame target = new SokobanGame();

            SokobanDirection direction = SokobanDirection.Up; // TODO: Initialize to an appropriate value

            bool expected = false;
            bool actual;

            actual = target.movePlayer(direction);

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.movePlayer did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for movePlayer (SokobanDirection, IGrid&lt;SokobanType&gt;, out IPoint)
        ///</summary>
        [DeploymentItem("Sokoban.dll")]
        [TestMethod()]
        public void movePlayerTest1()
        {
            SokobanGame target = new SokobanGame();

            Test.Sokoban_SokobanGameAccessor accessor = new Test.Sokoban_SokobanGameAccessor(target);

            SokobanDirection direction = SokobanDirection.Up; // TODO: Initialize to an appropriate value

            Grid.IGrid<Sokoban.Utils.SokobanType> boxes = null; // TODO: Initialize to an appropriate value

            IPoint boxPosition;
            IPoint boxPosition_expected = null; // TODO: Initialize to an appropriate value

            bool expected = false;
            bool actual;

            actual = accessor.movePlayer(direction, boxes, out boxPosition);

            Assert.AreEqual(boxPosition_expected, boxPosition, "boxPosition_movePlayer_expected was not set correctly.");
            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.movePlayer did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for saveGame (string)
        ///</summary>
        [TestMethod()]
        public void saveGameTest()
        {
            SokobanGame target = new SokobanGame();

            string savePath = null; // TODO: Initialize to an appropriate value

            target.saveGame(savePath);

            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SokobanGame ()
        ///</summary>
        [TestMethod()]
        public void ConstructorTest()
        {
            SokobanGame target = new SokobanGame();

            // TODO: Implement code to verify target
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for solve ()
        ///</summary>
        [TestMethod()]
        public void solveTest()
        {
            SokobanGame target = new SokobanGame();

            System.Collections.Generic.List<Sokoban.Utils.SokobanDirection> expected = null;
            System.Collections.Generic.List<Sokoban.Utils.SokobanDirection> actual;

            actual = target.solve();

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.solve did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for stringToDirections (string)
        ///</summary>
        [DeploymentItem("Sokoban.dll")]
        [TestMethod()]
        public void stringToDirectionsTest()
        {
            SokobanGame target = new SokobanGame();

            Test.Sokoban_SokobanGameAccessor accessor = new Test.Sokoban_SokobanGameAccessor(target);

            string route = null; // TODO: Initialize to an appropriate value

            System.Collections.Generic.List<Sokoban.Utils.SokobanDirection> expected = null;
            System.Collections.Generic.List<Sokoban.Utils.SokobanDirection> actual;

            actual = accessor.stringToDirections(route);

            Assert.AreEqual(expected, actual, "Sokoban.SokobanGame.stringToDirections did not return the expected value.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for width
        ///</summary>
        [TestMethod()]
        public void widthTest()
        {
            SokobanGame target = new SokobanGame();

            uint val = 0; // TODO: Assign to an appropriate value for the property

            target.width = val;


            Assert.AreEqual(val, target.width, "Sokoban.SokobanGame.width was not set correctly.");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

    }


}