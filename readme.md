## ก่อนติดตั้ง
ต้องมีโปรแกรมดังต่อไปนี้
1. Microsoft Visual Studio 2022
2. .NET desktop development Workloads

จากนั้นรันคำสั่งใน Command Prompt ดังนี้
`setx CONNECTION_STRING <connection-string>`
โดยให้เปลี่ยน `<connection-string>` เป็น connection string ที่ต้องการ
เช่น
```powershell
setx CONNECTION_STRING "Data Source=.\SQLEXPRESS;Initial Catalog=wellmeadows;Integrated Security=True;Pooling=False;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Name=vscode-mssql;Connect Retry Count=1;Connect Retry Interval=10;Command Timeout=30"
```

**จากนั้น restart เครื่อง (สำคัญ)**

## การติดตั้งและการดีบัก
1. Clone repository นี้ด้วยวิธีใดก็ได้
2. เปิดไฟล์ Solution (`.sln`)
3. เริ่มดีบักได้

## รายละเอียด
โปรแกรมนี้พัฒนาโดยใช้ Visual Basic WinForm .NET Framework 4.8
### Nuget Package ที่ใช้
- [Dapper](https://github.com/DapperLib/Dapper)
- [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)

