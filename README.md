# BÀI TẬP VỀ NHÀ 01:
**TẠO SOLUTION GỒM CÁC PROJECT SAU:**
1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis). <br>
2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE<br>
3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE<br>
4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.<br>


# Bài làm<br>

 **Tên đề tài: MÁY TÍNH **<br>

Sử dụng Visual Studio 2022<br>

1. Tạo class library
   - Tạo Class Library( NET framework)
     <img width="1262" height="842" alt="image" src="https://github.com/user-attachments/assets/87cd0303-cfa9-40fd-add1-8cdf8627faa0" />
   - Sửa tên file từ class1.cs sang MaytinhCalculator.cs, sau đó viết code, build solution
     <img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/daba3889-bb59-4b3d-afbe-f5687eeccfa5" />

     <img width="1067" height="840" alt="image" src="https://github.com/user-attachments/assets/0eaa59c8-7273-4270-9943-2dae6299a4a6" />

2. Consoleapp
   - Tạo project consoleapp
     + Chuột phải vào maytinh solution, chọn add, chọn new project
       <img width="877" height="852" alt="image" src="https://github.com/user-attachments/assets/945852ce-f019-400e-bb66-564b2de42a0c" />

     + Tìm consoleapp(net framework), create giống như khi tạo class library
       <img width="1278" height="833" alt="image" src="https://github.com/user-attachments/assets/c15a78b0-b60d-4247-874d-ef8442206d14" />
   
     + Thêm referance: click chuột phải vào console app vừa tạo, chọn referance, browse, add maytinh.dll vừa build là đc
       <img width="1458" height="822" alt="image" src="https://github.com/user-attachments/assets/382e391e-cd37-47fa-8cbe-dc87cb482e02" />

     + Build và check kết quả
       <img width="1920" height="991" alt="image" src="https://github.com/user-attachments/assets/e1ed0c6d-fb36-4eff-a754-e539d904db3b" />

       <img width="1072" height="842" alt="image" src="https://github.com/user-attachments/assets/5736445c-d029-48d2-b0f9-7952f7d7ee99" />

       <img width="1087" height="628" alt="image" src="https://github.com/user-attachments/assets/d77f5d9b-9011-4cdb-88e8-9fce221e8287" />
  
  3. WindowForm Application
    - Tạo project window forms
     <img width="1250" height="822" alt="image" src="https://github.com/user-attachments/assets/98ee360d-4f8f-4893-a1dc-2da83a2987f5" />

    - tạo referance như với consoleapp
    <img width="1433" height="908" alt="image" src="https://github.com/user-attachments/assets/71eb89a2-41c8-4103-bc74-f35567a4ba7f" />

    - Design với toolbox

     <img width="917" height="802" alt="image" src="https://github.com/user-attachments/assets/205f957f-df20-419a-adb6-e902a09e0ab9" />
