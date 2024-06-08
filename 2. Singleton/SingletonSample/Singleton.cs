namespace SingletonSample;

// sealed để ngăn chặn việc kế thừa class Singleton
public sealed class Singleton
{
    // Lưu instance hiện tại, volatile để đảm bảo tính toàn vẹn khi truy cập từ nhiều luồng
     private static volatile Singleton? _instance = null;
    public string InitialValue { get; set; }
    // sử dụng để đồng bộ hóa các luồng trong lần truy cập đầu tiên vào lớp singleton
    private static readonly object _lock = new object();

    // Không thể khởi tạo Singleton ở class khác
    private Singleton(string value)
    {
        InitialValue = value;
    }
    // Kiểm tra nếu không có _instance thì tạo mới, ngược lại trả về _instance hiện tại
    public static Singleton GetInstance(string value)
    {
        // lock để trong 1 thời điểm chỉ cho phép 1 Thread truy cập
        lock (_lock)
        {
            if (_instance == null)
                _instance = new Singleton(value);
            return _instance;
        }
    }
    public void Speak()
    {
        Console.WriteLine(InitialValue);
    }
}
