using PrototypeSample;
var student = new Student("Tran Cao Hai", 18, "Thai Binh", "123456789");
var cloneStudent = student.Clone() as Student; // Vì Clone trả về object nên cần ép kiểu về Student
cloneStudent.GetDetail();