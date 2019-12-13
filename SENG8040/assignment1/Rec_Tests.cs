using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using assignment1_part1;

namespace assignment1_part2
{
    [TestFixture]
    public class Rec_Tests
    {
        [Test]
        public void GetLength_input1_expectedLengthEquals1()
        {
            //Arrange
            int l = 1;
            int w = 2;
            Rectangle r = new Rectangle(l, w);
            
            //Act
            int length = r.GetLength();
            
            //Assert
            Assert.AreEqual(l, length);
        }
        [Test]
        public void GetWidth_input10_expectedWidthEquals10()
        {
            //Arrange
            int l = 1;
            int w = 10;

            Rectangle r = new Rectangle(l, w);
            
            //Act
            int width = r.GetWidth();
            
            //Assert
            Assert.AreEqual(w, width);
        }
        [Test]
        public void SetLength_input5_expectedLengthEquals5()
        {
            //Arrange
            int l = 5;

            Rectangle r = new Rectangle();
            
            //Act
            r.SetLength(l);
            
            //Assert
            Assert.AreEqual(l, r.GetLength());
        }
        [Test]
        public void SetWidth_input50_expectedWidthEquals50()
        {
            //Arrange
            int w = 50;
            Rectangle r = new Rectangle();
            
            //Act
            r.SetWidth(w);
            
            //Assert
            Assert.AreEqual(w, r.GetWidth());
        }
        [Test]
        public void GetPerimiter_length8width5_expectedPerimiter26()
        {
            //Arrange
            int l = 8;
            int w = 5;

            int expected = l * 2 + w * 2;

            Rectangle r = new Rectangle(l, w);
                        
            //Assert
            Assert.AreEqual(expected, r.GetPerimiter());
        }
        [Test]
        public void GetArea_length45width32_expectedArea1440()
        {
            //Arrange
            int l = 45;
            int w = 32;
            int expected = l * w;
            Rectangle r = new Rectangle(l, w); 
             
            //Assert
            Assert.AreEqual(expected, r.GetArea());
        }
    }
}
