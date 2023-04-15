using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DomainTest
    {
        //Initial values 
        [Test]
        public void StrikeSumTest()
        {
            int[] shoots = { 10,5,4}; 
            
            Game game = new Game();
            
            Assert.Equals(game.GameScore(shoots), 28);
        }
        
        [Test]
        public void SpareSumTest()
        {
            int[] shoots = { 6,4,7}; 
            
            Game game = new Game();
            
            Assert.Equals(game.GameScore(shoots), 24);
        }
        
        
        //GameTest
        
        [Test]
        public void WithOutSpecialShoots()
        {
            int[] shoots = { 5,4,1,5,6,3,1,2,4,5 };
            
            Game game = new Game();
            
            Assert.Equals(game.GameScore(shoots), 41);
        }
        
        [Test]
        public void WithStike()
        {
            int[] shoots = { 5,4,3,6,10,8,6,1,5 };
            
            Game game = new Game();
            
            Assert.Equals(game.GameScore(shoots), 62);
        }
        
        [Test]
        public void WithSpare()
        {
            int[] shoots = { 5,5,3,4,5,4,2,6,2,5 };
            
            Game game = new Game();
            
            Assert.Equals(game.GameScore(shoots), 44);
        }
        
        [Test]
        public void WithStrikeInTheLastTurn()
        {
            int[] shoots = {5,4,2,3,5,4,1,2,3,10,5,3};
            
            Game game = new Game();
            
            Assert.Equals(game.GameScore(shoots), 55);
        }
        
        [Test]
        public void WithSpareInTheLastTurn()
        {
            int[] shoots = {5,4,2,3,5,4,1,2,6,4,8};
            
            Game game = new Game();
            
            Assert.Equals(game.GameScore(shoots), 52);
        }
        
    }
}
