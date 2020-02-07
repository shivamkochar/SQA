using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Assignment01.Tests
{
   [TestFixture]
   public class RectangleTest
    {
        [Test]
        public void GetPerimeter_Input_2_2_Output_8()
        {
            Rectangle r = new Rectangle(2,2);
            Assert.AreEqual(8,r.GetPerimeter());
        }

        [Test]
        public void GetPerimeter_Input_4_4_Output_16()
        {
            Rectangle r = new Rectangle(4, 4);
            Assert.AreEqual(16, r.GetPerimeter());
        }

        [Test]
        public void GetRectangleLength_Input_1_Output_1()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(1,r.GetLength());
        }

        [Test]
        public void GetRectangleLength_Input_10_Output_10()
        {
            Rectangle r = new Rectangle();
            r.SetLength(10);
            Assert.AreEqual(10, r.GetLength());
        }

        [Test]
        public void GetRectangleWidth_Input_1_Output_1()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(1, r.GetWidth());
        }

        [Test]
        public void GetRectangleWidth_Input_15_Output_15()
        {
            Rectangle r = new Rectangle();
            r.SetWidth(15);
            Assert.AreEqual(15, r.GetWidth());
        }

        [Test]
        public void ChangeRectangleLength_Input_10_Output_10()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(10, r.SetLength(10));
        }


        [Test]
        public void ChangeRectangleLength_Input_20_Output_20()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(20, r.SetLength(20));
        }

        [Test]
        public void ChangeRectangleWidth_Input_20_Output_20()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(20, r.SetWidth(20));
        }

        [Test]
        public void ChangeRectangleWidth_Input_30_Output_30()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(30, r.SetWidth(30));
        }

        [Test]
        public void GetRectangleArea_Input_10_20_Output_200()
        {
            Rectangle r = new Rectangle(10,20);
            Assert.AreEqual(200, r.GetArea());
        }

        [Test]
        public void GetRectangleArea_Input_15_10_Output_150()
        {
            Rectangle r = new Rectangle(15, 10);
            Assert.AreEqual(150, r.GetArea());
        }
    }
}
