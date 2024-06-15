namespace PrototypeSample;
public interface IPrototype
{
    // Trả về Object để có thể Implement ở mọi Class
    object Clone();
}
