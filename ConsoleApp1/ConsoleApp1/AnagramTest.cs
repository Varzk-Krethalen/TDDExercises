using NUnit.Framework;

[TestFixture]
public class AnagramTest
{
    [Test]
    public void Generate_ShouldOutputTheInput()
    {
        Anagram testGen = new Anagram("biro");
        StringAssert.Contains("biro", testGen.Generate());
    }

    [Test]
    public void Generate_ShouldOutputADifferentInput()
    {
        Anagram testGen = new Anagram("test");
        StringAssert.Contains("test", testGen.Generate());
        StringAssert.DoesNotContain("biro", testGen.Generate());
    }

    [Test]
    public void Generate_ShouldOutputAnagramBeginningFirstLetter()
    {
        Anagram testGen = new Anagram("biro");
        string result = testGen.Generate();
        StringAssert.Contains("bior", result);
        StringAssert.Contains("brio", result);
        StringAssert.Contains("broi", result);
        StringAssert.Contains("boir", result);
        StringAssert.Contains("bori", result);
    }

    [Test]
    public void Generate_ShouldOutputAnagramBeginningFirstLetter_WithDifferentInput()
    {
        Anagram testGen = new Anagram("test");
        string result = testGen.Generate();
        StringAssert.Contains("tets", result);
        StringAssert.Contains("tset", result);
        StringAssert.Contains("tste", result);
        StringAssert.Contains("ttes", result);
        StringAssert.Contains("ttse", result);
    }

    [Test]
    public void Generate_ShouldOutputAnagramBeginningFirstLetter_WithLongerInput()
    {
        Anagram testGen = new Anagram("test2");
        string result = testGen.Generate();
        StringAssert.Contains("test2", result);
        StringAssert.Contains("tes2t", result);
        StringAssert.Contains("tets2", result);
        StringAssert.Contains("tet2s", result);
        StringAssert.Contains("te2st", result);
        StringAssert.Contains("te2ts", result);
        StringAssert.Contains("tse2t", result);
        StringAssert.Contains("tset2", result);
        StringAssert.Contains("tst2e", result);
        StringAssert.Contains("tste2", result);
        StringAssert.Contains("ts2te", result);
        StringAssert.Contains("ts2et", result);
        StringAssert.Contains("ttes2", result);
        StringAssert.Contains("tte2s", result);
        StringAssert.Contains("ttse2", result);
        StringAssert.Contains("tts2e", result);
        StringAssert.Contains("tt2es", result);
        StringAssert.Contains("tt2se", result);
        StringAssert.Contains("t2ets", result);
        StringAssert.Contains("t2est", result);
        StringAssert.Contains("t2ste", result);
        StringAssert.Contains("t2set", result);
        StringAssert.Contains("t2tse", result);
        StringAssert.Contains("t2tes", result);
    }

    [Test]
    public void Generate_ShouldOutputAllAnagrams()
    {
        Anagram testGen = new Anagram("biro");
        string result = testGen.Generate();
        StringAssert.Contains("biro", result);
        StringAssert.Contains("bior", result);
        StringAssert.Contains("brio", result);
        StringAssert.Contains("broi", result);
        StringAssert.Contains("boir", result);
        StringAssert.Contains("bori", result);

        StringAssert.Contains("ibro", result);
        StringAssert.Contains("ibor", result);
        StringAssert.Contains("irbo", result);
        StringAssert.Contains("irob", result);
        StringAssert.Contains("iobr", result);
        StringAssert.Contains("iorb", result);

        StringAssert.Contains("rbio", result);
        StringAssert.Contains("rboi", result);
        StringAssert.Contains("ribo", result);
        StringAssert.Contains("riob", result);
        StringAssert.Contains("roib", result);
        StringAssert.Contains("robi", result);

        StringAssert.Contains("obir", result);
        StringAssert.Contains("obri", result);
        StringAssert.Contains("oibr", result);
        StringAssert.Contains("oirb", result);
        StringAssert.Contains("orbi", result);
        StringAssert.Contains("orib", result);
    }
}
