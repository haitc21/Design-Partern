using SingletonSample;

var proc1 = new Thread(() => {
    var s1 = Singleton.GetInstance("Singleton 1");
    s1.Speak();
});
var proc2 = new Thread(() => {
    var s2 = Singleton.GetInstance("Singleton 2");
    s2.Speak();
});

// Khởi chạy các process
proc1.Start();
proc2.Start();
// Chờ cho process chạy xong
proc1.Join();
proc2.Join();
