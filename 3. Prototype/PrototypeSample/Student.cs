namespace PrototypeSample;
public class Student : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    private string IdCard { get; set; }
    public Student(string name, int age, string city, string idCard)
    {
        Name = name;
        Age = age;
        City = city;
        IdCard = idCard;
    }
    public object Clone()
    {
        var student = this.MemberwiseClone();
        return student;
    }
    public void GetDetail()
    {
        Console.WriteLine($"Student info:\n - Name {Name}\n - Age: {Age}\n - City: {City}\n - IdCard: {IdCard}");
    }
}