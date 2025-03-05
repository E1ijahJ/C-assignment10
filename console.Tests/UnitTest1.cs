namespace console.Tests;

public class UnitTest1
{
    [Fact]
    public void QuarterTest()
    {
List<Quarter> quarters = new()
            {
                new Quarter(0.1), // First Quarter
                new Quarter(0.2), // First Quarter
                new Quarter(0.3), // Second Quarter
                new Quarter(0.7), // Third Quarter
                new Quarter(0.9)  // Fourth Quarter
            };

            // Capture Console Output
            using StringWriter sw = new();
            Console.SetOut(sw);

            // Act
            ConApp.DisplayQuarters(quarters);
            string output = sw.ToString();

            // Assert: Check that each quarter group appears in the output
            Assert.Contains("[0.0 - 0.25): 0.1, 0.2", output);
            Assert.Contains("[0.25 - 0.5): 0.3", output);
            Assert.Contains("[0.5 - 0.75): 0.7", output);
            Assert.Contains("[0.75 - 1.0]: 0.9", output);
    }
}
