using Game;
using NUnit.Framework;

public class ScoreModelTest
{
    private ScoreModel _scoreModel;
    
    [SetUp]
    public void Setup()
    {
        _scoreModel = new ScoreModel();
    }


    [Test]
    public void _01ScoreAddTest()
    {
        _scoreModel.AddScore(1);
    }
}
