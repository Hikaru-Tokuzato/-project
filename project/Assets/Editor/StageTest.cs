using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.TestTools;
using UnityEditor.VersionControl;
using UnityAssert = UnityEngine.Assertions;
using Scripts;
namespace Tests
{
    public class StageTest
    {
        private Stage stage;
        [OneTimeSetUp]
        public void テスト前の初期化()
        {
            stage = new Stage();
            var characters =  new List<Character>();
            characters.Add(new Character("Player1", new TestDice(2)));

            stage.Characters = characters;
            
            List<IGrid> grids = new List<IGrid>(){ new NonActionGrid(), new NonActionGrid(), new NonActionGrid(), new NonActionGrid(), new NonActionGrid()};
            
            stage.MakeStage(grids);
            stage.MakeOrder();
        }
        
        
        
        [Test]
        public void 正しいマスメにいるかどうか()
        {
            var value = stage.ForceAction(1, 0);
            UnityAssert.Assert.AreEqual(2,stage.Characters[0].dice.Roll());
            UnityAssert.Assert.AreEqual(0,stage.order[0]);
            UnityAssert.Assert.AreEqual(2, value);
            UnityAssert.Assert.AreEqual(2, stage.Characters[0].coordinate);
            
            
            value = stage.ForceAction(1, 0);
            UnityAssert.Assert.AreEqual(4, stage.Characters[0].coordinate);
            
            value = stage.ForceAction(1, 0);
            UnityAssert.Assert.AreEqual(-1,value);
            UnityAssert.Assert.AreEqual(4, stage.Characters[0].coordinate);
            UnityAssert.Assert.IsTrue(stage.IfFinishGame());
        }
    }
    
    
    public class TestDice : IDice
    {
        public int value { set; get; }

        public TestDice(int value)
        {
            this.value = value;
        }
        
        public int Roll()
        {
            return value;
        }
    }
}