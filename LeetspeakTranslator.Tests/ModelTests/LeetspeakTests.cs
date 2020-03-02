using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests 
{
  [TestClass]
  public class LeetspeakTests
  {
    public LeetspeakTranslator testTranslator = new LeetspeakTranslator();

    [TestMethod]
    public void Translate_NoLeetspeakCharacters_SameAsInput()
    {
      //LeetspeakTranslator testTranslator = new LeetspeakTranslator();
      Assert.AreEqual("Bring", testTranslator.Translate("Bring"));
    }

    [TestMethod]
    public void Translate_WordsWithE_ChangeTo3()
    {
      LeetspeakTranslator testTranslator = new LeetspeakTranslator();
      Assert.AreEqual("gr33n", testTranslator.Translate("green"));
    }

    [TestMethod]
    public void Translate_WordsWithO_ChangeTo0()
    {
      LeetspeakTranslator testTranslator = new LeetspeakTranslator();
      Assert.AreEqual("0kay", testTranslator.Translate("okay"));
    }

    [TestMethod]

    public void Translate_WordWithCapitalI_ChangeTo1()
    {
      LeetspeakTranslator testTranslator = new LeetspeakTranslator();

      Assert.AreEqual("1c333", testTranslator.Translate("Iceee"));

    }

    [TestMethod]
    public void Translate_WordWithT_ChangeTo7()
    {
      LeetspeakTranslator testTranslator = new LeetspeakTranslator();

      Assert.AreEqual("7a7", testTranslator.Translate("Tat"));
    }

    [TestMethod]
    public void Translate_SInside_ChangeToZ()
    {
      Assert.AreEqual("kickz", testTranslator.Translate("kicks"));
    }

    [TestMethod]
    public void Translate_SInFirstPosition_SameAsInput()
    {
      Assert.AreEqual("wha sup?", testTranslator.Translate("wha sup?"));
    }

    [TestMethod]
    public void Translate_DoubleS_SameAsInput()
    {
    Assert.AreEqual("class", testTranslator.Translate("class"));
    }
  } 
}