namespace TemplateEngine.Tests;

public class TestTemplateEngine
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldWorkForOneVariable()
    {   
        // ARRANGE
        TemplateEngine templateEngine = new();
        templateEngine.setTemplate("My school name is {schoolName}");
        templateEngine.setVariables("schoolName", "GHS");

        // ACT
        string result = templateEngine.parse();

        // ASSERT
        Assert.That(result, Is.EqualTo("My school name is GHS"));
        
        
    }

    [Test]
    public void ShouldWorkForAnotherVariable()
    {   
        // ARRANGE
        TemplateEngine templateEngine = new();
        templateEngine.setTemplate("My school name is {schoolName}");
        templateEngine.setVariables("schoolName", "ABC");

        // ACT
        string result = templateEngine.parse();

        // ASSERT
        Assert.That(result, Is.EqualTo("My school name is ABC"));
        
        
    }

    [Test]
    
    public void ShouldWorkForTwoVariable()
    {   
        // ARRANGE
        TemplateEngine templateEngine = new();
        templateEngine.setTemplate("My school name is {schoolName}. My teacher is {teacherName}");
        templateEngine.setVariables("schoolName", "GHS");
        templateEngine.setVariables("teacherName", "Uma");

        // ACT
        string result = templateEngine.parse();

        // ASSERT
        Assert.That(result, Is.EqualTo("My school name is GHS. My teacher is Uma"));
        
        
    }
}